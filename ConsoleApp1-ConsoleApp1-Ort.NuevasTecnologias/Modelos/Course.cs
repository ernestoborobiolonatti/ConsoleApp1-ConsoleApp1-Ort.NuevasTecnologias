using System;
using System.Collections.Generic;

namespace ConsoleApp1_ConsoleApp1_Ort.NuevasTecnologias.Modelos;

public partial class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public int? TeacherId { get; set; }

    public virtual Teacher? Teacher { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
