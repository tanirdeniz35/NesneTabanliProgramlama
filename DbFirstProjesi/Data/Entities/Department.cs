using System;
using System.Collections.Generic;

namespace DbFirstProjesi.Data.Entities;

public partial class Department
{
    public int Id { get; set; }

    public string DeptName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
