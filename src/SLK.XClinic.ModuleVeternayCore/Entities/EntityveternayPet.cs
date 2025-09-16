using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;
[Table("VETERNAY_PET")]
public class EntityveternayPet : EntityBase
{
    public Guid GuidCustomer { get; set; }
    [Required(ErrorMessage = "Tên thú cưng là bắt buộc.")]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "Loại thú cưng là bắt buộc.")]
    public string Species { get; set; }

    public string Breed { get; set; }
    [Range(0, 100, ErrorMessage = "Tuổi phải từ 0 đến 100.")]
    public int Age { get; set; }
    [Required(ErrorMessage = "Giới tính là bắt buộc.")]
    public string Gender { get; set; }              
    public string Color { get; set; }              
    public string Microchip { get; set; }           
    public string MedicalNotes { get; set; }       
    public bool IsDeleted { get; set; } = false;

}
