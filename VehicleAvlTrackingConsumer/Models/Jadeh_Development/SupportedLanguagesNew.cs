using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("SupportedLanguagesNew")]
[Index("Language", Name = "IX_SupportedLanguagesNew_Language", IsUnique = true)]
public partial class SupportedLanguagesNew
{
    [Key]
    public int Id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Language { get; set; } = null!;

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string Direction { get; set; } = null!;

    public bool Active { get; set; }
}
