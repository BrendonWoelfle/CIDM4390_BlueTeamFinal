#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.Models
{
    public class Form
    {
        public int FormID {get; set;}

        public ICollection<Instructor> Instructors {get; set;}
    }
}