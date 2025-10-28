using System;
using System.ComponentModel.DataAnnotations.Schema;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[Table("VETERNAY_MEDICAL_DISEASE")]
public class EntityVeternayMedicalDisease : EntityBase
{
    public Guid GuidMedicalRecord { get; set; }
    public int? MedicalRecordId { get; set; }
    [ForeignKey("MedicalRecordId")]
    public EntityVeternayMedicalRecord MedicalRecord { get; set; }
    public Guid GuidDiseaseType { get; set; }
    public int? DiseaseTypeId { get; set; }
    [ForeignKey("DiseaseTypeId")]
    public EntityVeternayDiseaseType DiseaseType { get; set; }
}

