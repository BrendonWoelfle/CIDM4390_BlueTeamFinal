#nullable disable
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace webapp.Models
{
    public class Course
    {
        public int CourseID {get; set;}
        public string Title {get; set;}
        public int Credits {get; set;}
        public int InstructorID {get; set;}
        public Season Season {get; set;}

        public Instructor Instructor {get; set;}

    }
}