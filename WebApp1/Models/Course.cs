using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace WebApp1.Models
{
    public class Course
    {
        public int CourseID {get; set;}
        public string? CourseName {get; set;}
        public string? Semester {get; set;}
        public int Academic_Year {get; set;}
    }

    public class CourseEvaluation
    {
        public int CourseID {get; set;}
        public int EvaluationID {get; set;}
        public Course? Course {get; set;}
        public Evaluation? Evaluation {get; set;}
    }
}