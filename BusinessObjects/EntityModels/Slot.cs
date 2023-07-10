using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessObjects.EntityModels;

[Table("Slot")]
public partial class Slot
{
    [Key]
    [Column("slotId")]
    public int SlotId { get; set; }

    [Column("groupId")]
    public int? GroupId { get; set; }

    [Column("slotIndex")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SlotIndex { get; set; }

    [Column("slotName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SlotName { get; set; }

    [Column("status")]
    public bool Status { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("Slots")]
    public virtual Group? Group { get; set; }

    [InverseProperty("Slot")]
    public virtual ICollection<Progress> Progresses { get; set; } = new List<Progress>();

    [InverseProperty("Slot")]
    public virtual ICollection<StudyMaterial> StudyMaterials { get; set; } = new List<StudyMaterial>();
}
