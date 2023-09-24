using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApp.MVC.Data;

public class CourseMetadata
{
    [Display(Name="Name")]
    public string Name { get; set; } = null!;
    [Display(Name="Code")]
    public string? Code { get; set; }
    [Display(Name="Credit")]
    public int? Credit { get; set; }
}

[ModelMetadataType(typeof(CourseMetadata))]
public partial class Course
{

}