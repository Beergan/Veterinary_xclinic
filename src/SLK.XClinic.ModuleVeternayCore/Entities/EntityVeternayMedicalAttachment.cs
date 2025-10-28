using System;
using System.ComponentModel.DataAnnotations.Schema;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[Table("VETERNAY_MEDICAL_ATTACHMENT")]
public class EntityVeternayMedicalAttachment : EntityBase
{
    public Guid GuidMedicalRecord { get; set; }
    public int? MedicalRecordId { get; set; }
    [ForeignKey("MedicalRecordId")]
    public EntityVeternayMedicalRecord MedicalRecord { get; set; }
    public string FilePath { get; set; }
    public string FileType { get; set; }
    public string Description { get; set; }
}
