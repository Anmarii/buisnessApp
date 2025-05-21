using System;
using System.ComponentModel.DataAnnotations;

public enum ApplicationStatus
{
    New,
    Accepted,
    Rejected,
    PreInterview
}

namespace Choka.Web.Models
{
    public class JobApplication : BaseEntity
    {
        [Required]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public string CvFilePath { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.Now;

        public ApplicationStatus Status { get; set; } = ApplicationStatus.New;

        public int JobOfferId { get; set; }  // klucz obcy(EF Core automatycznie tworzy klucz obcy (Foreign Key) w tabeli JobApplication, wskazujący na JobOffer.Id)

        public JobOffer JobOffer { get; set; }  // nawigacja do konkretnego ogłoszenia

    }
}

