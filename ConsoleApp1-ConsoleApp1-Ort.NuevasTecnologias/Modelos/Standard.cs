using System;
using System.Collections.Generic;

namespace ConsoleApp1_ConsoleApp1_Ort.NuevasTecnologias.Modelos;

public partial class Standard
{
    public int StandardId { get; set; }

    public string? StandardName { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
