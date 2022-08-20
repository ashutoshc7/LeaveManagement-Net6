﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class EmployeeListVM
    {
        public int Id { get; set; }
        [Display(Name ="First Name")]
        public string Firstname { get; set; }
        [Display(Name ="Last Name")]
        public string Lastname { get; set; }
        [Display(Name ="Date Joined")]
        public string DateJoined { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
}