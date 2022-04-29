using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public enum Season
{
    Fall,
    Spring,
}

public class AcademicYearPeriod
{
    public int Year {get; set;}
    public Season Season {get; set;}
}