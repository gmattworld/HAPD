using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hahn.ApplicatonProcess.December2020.Data;
using Hahn.ApplicatonProcess.December2020.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hahn.ApplicatonProcess.December2020.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApplicantsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Applicants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Applicant>>> GetApplicants()
        {
            try
            {
                IEnumerable<Applicant> data = await _unitOfWork.Applicants.GetAllAsync();
                return Ok(data);
            }
            catch (Exception)
            {

                throw;
            }


        }

        // GET: api/Applicants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Applicant>> GetApplicant(int id)
        {
            var applicant = await _unitOfWork.Applicants.GetAsync(id);

            if (applicant == null)
            {
                return NotFound();
            }

            return applicant;
        }

        // PUT: api/Applicants/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicant(int id, Applicant applicant)
        {
            try
            {
                if (id != applicant.ID)
                {
                    return BadRequest();
                }

                _ = _unitOfWork.Applicants.UpdateAsync(applicant);

                await _unitOfWork.CompleteAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!(await _unitOfWork.Applicants.ExistsAsync(id)))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Applicants
        [HttpPost]
        public async Task<ActionResult<Applicant>> PostApplicant(Applicant applicant)
        {
            _ = _unitOfWork.Applicants.InsertAsync(applicant);
            await _unitOfWork.CompleteAsync();

            return CreatedAtAction("GetApplicant", new { id = applicant.ID }, applicant);
        }

        // DELETE: api/Applicants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicant(int id)
        {
            var applicant = await _unitOfWork.Applicants.GetAsync(id);
            if (applicant == null)
            {
                return NotFound();
            }

            _ = _unitOfWork.Applicants.DeleteFinallyAsync(applicant);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }
    }
}
