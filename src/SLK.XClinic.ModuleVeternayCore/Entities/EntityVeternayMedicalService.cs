using System;
using System.ComponentModel.DataAnnotations.Schema;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[Table("VETERNAY_MEDICAL_SERVICE")]
public class EntityVeternayMedicalService : EntityBase
{
    public Guid GuidMedicalRecord { get; set; }
    public int? MedicalRecordId { get; set; }
    [ForeignKey("MedicalRecordId")]
    public EntityVeternayMedicalRecord MedicalRecord { get; set; }
    public Guid GuidService { get; set; }
    public int? ServiceId { get; set; }
    [ForeignKey("ServiceId")]
    public EntityVeternayServices Service { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; } = 1;
    public decimal Amount => Price * Quantity;
}
