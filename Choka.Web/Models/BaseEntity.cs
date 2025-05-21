using System;
using System.ComponentModel.DataAnnotations;

namespace Choka.Web.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; } // Primary key (auto-incremented)

        [Required]
        public Guid RowId { get; set; } = Guid.NewGuid(); // Globally unique identifier

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        public bool IsActive { get; set; } = true; // Soft delete flag

        [Timestamp]
        public byte[] Version { get; set; } // Concurrency token
    }
}