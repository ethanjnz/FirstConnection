#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace firstConnection.Models;

public class Pet
{
    [Key]
    public int UserId { get; set; }
    public string Name { get; set; }

    public int Age { get; set; }

    public bool HasFur { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdateAt { get; set; } = DateTime.Now;
}