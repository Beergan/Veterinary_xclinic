using System;
using System.ComponentModel.DataAnnotations.Schema;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[Table("VETERNAY_MEDICAL_PRESCRIPTION")]
public class EntityVeternayMedicalPrescription : EntityBase
{
    public Guid GuidMedicalRecord { get; set; }
    public int? MedicalRecordId { get; set; }
    [ForeignKey("MedicalRecordId")]
    public EntityVeternayMedicalRecord MedicalRecord { get; set; }
    public Guid GuidMedication { get; set; }
    public int? MedicationId { get; set; }
    [ForeignKey("MedicationId")]
    public EntityVeternayMedication Medication { get; set; }
    public int Quantity { get; set; }
    public string DosageInstruction { get; set; }
    public decimal Price { get; set; }
    public decimal Amount => Price * Quantity;
}

