using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLK.XClinic.Abstract;
using Syncfusion.Blazor.Gantt.Internal;

namespace SLK.XClinic.ModuleVeternayCore;
[Table("VETERNAY_SERVICES")]
public class EntityVeternayServices :EntityBase
{
    public Guid GuidServices { get; set; }
    public string Code { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; }
    public decimal Price { get; set; } = 0;
    public bool IsActive { get; set; } = true;
    public ICollection<EntityVeternayBooking> Bookings { get; set; } = new List<EntityVeternayBooking>();
}
