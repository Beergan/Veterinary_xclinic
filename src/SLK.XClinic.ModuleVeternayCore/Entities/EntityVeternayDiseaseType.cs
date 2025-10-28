using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[Table("VETERNAY_DISEASETYPE")]
public class EntityVeternayDiseaseType : EntityBase
{
    [Required(ErrorMessage = "Tên loại bệnh là bắt buộc.")]
    [MaxLength(200)]
    public string Name { get; set; }

    public string Description { get; set; }

    [MaxLength(50)]
    public string Species { get; set; }

    public bool IsDeleted { get; set; } = false;

    public ICollection<EntityveternayPet> Pets { get; set; } = new List<EntityveternayPet>();
}
