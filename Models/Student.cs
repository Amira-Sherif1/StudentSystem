﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }
        //relations
        public List<StudentCourse> StudentCourses { get; set; } // students and courses m -> m 
        public List<Homework> Homeworks { get; set; }           // student and homworks 1 -> m
       
    }
}
