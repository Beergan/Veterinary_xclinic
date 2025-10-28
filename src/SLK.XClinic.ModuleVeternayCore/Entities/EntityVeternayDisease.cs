using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[Table("VETERNAY_DISEASE")]
public class EntityVeternayDisease : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsDeleted { get; set; } = false;
}
