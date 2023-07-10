using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessObjects.EntityModels;

[Table("Comment")]
public partial class Comment
{
    [Key]
    [Column("commentId")]
    public int CommentId { get; set; }

    [Column("groupID")]
    public int GroupId { get; set; }

    [Column("userId")]
    public int UserId { get; set; }

    [Column("comment", TypeName = "text")]
    public string Comment1 { get; set; } = null!;

    [ForeignKey("GroupId")]
    [InverseProperty("Comments")]
    public virtual Group Group { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Comments")]
    public virtual User User { get; set; } = null!;
}
