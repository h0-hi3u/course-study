using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessObjects.EntityModels;

[Table("Subject")]
public partial class Subject
{
    [Key]
    [Column("subjectId")]
    [StringLength(10)]
    [Unicode(false)]
    public string SubjectId { get; set; } = null!;

    [Column("subjectName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SubjectName { get; set; }

    [Column("description", TypeName = "text")]
    public string? Description { get; set; }

    [Column("status")]
    public bool Status { get; set; }

    [InverseProperty("Subject")]
    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
}
