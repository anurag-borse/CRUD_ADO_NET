﻿using System.ComponentModel.DataAnnotations;

namespace CRUD_ADO_NET.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "Employee ID")]
        public int ID { get; set; }

        [Display(Name = "Employee Name")]
        public string Name { get; set; }


        [Display(Name = "Employee Age")]
        public int Age { get; set; }


        [Display(Name = "Employee Email")]
        public string Email { get; set; }


        [Display(Name = "Employee Mobile")]
        public string Mobile { get; set; }

        [Display(Name = "Employee Department")]
        public string Department { get; set; }

    }
}
