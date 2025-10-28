using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[Table("VETERNAY_PET_TYPE")]
public class EntityVeternayPetType : EntityBase
{
    [Required]
    [MaxLength(200)]
    public string Name { get; set; }  
    [MaxLength(500)]
    public string Description { get; set; }
    public ICollection<EntityveternayPet> Pets { get; set; } = new List<EntityveternayPet>();
}
