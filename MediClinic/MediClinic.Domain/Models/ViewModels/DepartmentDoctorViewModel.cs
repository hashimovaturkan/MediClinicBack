﻿using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.ViewModels
{
    public class DepartmentDoctorViewModel
    {
        public IEnumerable<Doctor> Doctors { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<WeekDay> WeekDays { get; set; }
        public string CurrentDepartment { get; set; }
    }
}
