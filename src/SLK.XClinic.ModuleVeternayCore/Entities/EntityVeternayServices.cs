using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLK.XClinic.Abstract;
using Syncfusion.Blazor.Gantt.Internal;

namespace SLK.XClinic.ModuleVeternayCore;
[Table("VETERNAY_SERVICES")]
public class EntityVeternayServices : EntityBase
{
    [Required]
    public string Code { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; }
    public decimal Price { get; set; } = 0;
    public bool IsActive { get; set; } = true;

    public ICollection<EntityVeternayBookingService> BookingServices { get; set; }
        = new List<EntityVeternayBookingService>();

    public ICollection<EntityVeternayMedicalService> MedicalServices { get; set; }
        = new List<EntityVeternayMedicalService>();
}

