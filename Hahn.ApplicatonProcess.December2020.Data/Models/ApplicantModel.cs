﻿namespace Hahn.ApplicatonProcess.December2020.Data.Models
{
    public class ApplicantModel
    {
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Address { get; set; }
        public string CountryOfOrigin { get; set; }
        public string EMailAdress { get; set; }
        public int Age { get; set; }
        public bool Hired { get; set; } = false;
    }
}
