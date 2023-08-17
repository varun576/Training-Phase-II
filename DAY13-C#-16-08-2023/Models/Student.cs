using System;
using System.Collections.Generic;

namespace JwtAuth.Models;

public partial class Student
{
    public int Rollno { get; set; }

    public string Stuname { get; set; } = null!;

    public string Addr { get; set; } = null!;

    public long Phno { get; set; }
}
