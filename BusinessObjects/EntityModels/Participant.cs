using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessObjects.EntityModels;

[PrimaryKey("UserId", "GroupId")]
[Table("Participant")]
public partial class Participant
{
    [Key]
    [Column("userId")]
    public int UserId { get; set; }

    [Key]
    [Column("groupId")]
    public int GroupId { get; set; }

    [Column("status")]
    public int Status { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("Participants")]
    public virtual Group Group { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Participants")]
    public virtual User User { get; set; } = null!;
}
