using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("ErrorsLocalization")]
[Index("Key", "Locale", Name = "UniqueKey_Key_Locale", IsUnique = true)]
public partial class ErrorsLocalization
{
    [Key]
    public int Id { get; set; }

    [StringLength(2)]
    public string Locale { get; set; } = null!;

    [StringLength(200)]
    public string Key { get; set; } = null!;

    [StringLength(200)]
    public string Text { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDefault { get; set; }
}
