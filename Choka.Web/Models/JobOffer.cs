using System;
using System.ComponentModel.DataAnnotations;

namespace Choka.Web.Models
{
    public class JobOffer : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime PublishedAt { get; set; } = DateTime.Now;

        public string Channel { get; set; }

        public string Status { get; set; } = "Draft";

        public ICollection<JobApplication> Applications { get; set; } //kolekcja aplikacji do tego konkretnego ogłoszenia

    }
}
