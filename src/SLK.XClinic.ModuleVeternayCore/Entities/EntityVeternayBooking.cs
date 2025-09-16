using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLK.XClinic.Abstract;


namespace SLK.XClinic.ModuleVeternayCore;
[Table("VETERNAY_BOOKING")]
public class EntityVeternayBooking : EntityBase
{
    public Guid GuidBooking { get; set; }
    public Guid GuidCustomer { get; set; }
    public EntityVeternayCustomer Customer { get; set; }

    public Guid GuidPet { get; set; }
    public EntityVeternayServices Services { get; set; }
    public Guid GuidVisit { get; set; }

    public Guid GuidEmployee
    {
        get; set;
    }
    public string Status { get; set; } = "Scheduled";
    public string Notes { get; set; }
    public ICollection<EntityVeternayVisit> Visits { get; set; } = new List<EntityVeternayVisit>();

}
