using System;
using System.Collections.Generic;

namespace DbFirstProjesi.Data.Entities;

public partial class User
{
    public int Id { get; set; }

    public string NameSurname { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
