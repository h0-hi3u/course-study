using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessObjects.EntityModels;

[PrimaryKey("UserId", "SlotId")]
[Table("Progress")]
public partial class Progress
{
    [Key]
    [Column("userId")]
    public int UserId { get; set; }

    [Key]
    [Column("slotId")]
    public int SlotId { get; set; }

    [Column("status")]
    public bool Status { get; set; }

    [ForeignKey("SlotId")]
    [InverseProperty("Progresses")]
    public virtual Slot Slot { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Progresses")]
    public virtual User User { get; set; } = null!;
}
