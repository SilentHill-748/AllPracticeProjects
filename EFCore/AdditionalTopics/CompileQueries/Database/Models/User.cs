﻿namespace CompileQueries.Database.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }


        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
}