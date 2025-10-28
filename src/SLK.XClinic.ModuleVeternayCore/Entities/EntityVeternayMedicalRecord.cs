using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[Table("VETERNAY_MEDICAL_RECORD")]
public class EntityVeternayMedicalRecord : EntityBase
{
    public Guid GuidPet { get; set; }
    public string CustomerName { get; set; }
    public int ? PetId { get; set; }
    [ForeignKey("PetId")]
    public EntityveternayPet Pet { get; set; }
    public DateTime? VisitDate { get; set; } = DateTime.Now;
    public Guid VetId { get; set; } 
    public string Diagnosis { get; set; }
    public string Notes { get; set; }
    public decimal TotalAmount { get; set; }
    public Guid GuidCustomer { get; set; }
    public bool IsDeleted { get; set; } = false;
    public ICollection<EntityVeternayMedicalService> Services { get; set; } = new List<EntityVeternayMedicalService>();
    public ICollection<EntityVeternayMedicalPrescription> Prescriptions { get; set; } = new List<EntityVeternayMedicalPrescription>();
    public ICollection<EntityVeternayMedicalDisease> Diseases { get; set; } = new List<EntityVeternayMedicalDisease>();
    public ICollection<EntityVeternayMedicalAttachment> Attachments { get; set; } = new List<EntityVeternayMedicalAttachment>();
}
