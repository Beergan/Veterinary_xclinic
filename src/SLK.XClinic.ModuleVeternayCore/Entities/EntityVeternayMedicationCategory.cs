using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;
[Table("VETERNAY_MEDICATION_CATEGORY")]
public class EntityVeternayMedicationCategory : EntityBase
{
    [Display(Name = "Tên danh mục")]
    [Required(ErrorMessage = "Không được để trống")]
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsDeleted { get; set; } = false;
    public ICollection<EntityVeternayMedication> Medications { get; set; } = new List<EntityVeternayMedication>();

}
