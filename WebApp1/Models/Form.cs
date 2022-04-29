#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp1.Models
{
    public class Form
    {
        public int FormID {get; set;}

        public ICollection<Instructor> Instructors {get; set;}
    }
}