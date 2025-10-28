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
    public Guid GuidCustomer { get; set; }
    public EntityVeternayCustomer Customer { get; set; }
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string Code { get; set; } = DateTime.Now.ToString("'BK-'yyyyMMddHHmmssfff");
    public Guid GuidPet { get; set; }
    public Guid GuidEmployee { get; set; }
    public string Status { get; set; } = "Scheduled";
    public string Notes { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime? AppointmentDate { get; set; }
    public int ? PetId { get; set; }
    [ForeignKey("PetId")]
    public EntityveternayPet Pet { get; set; }
    public Guid? GuidMedicalRecord { get; set; }

    public int ? MedicalRecordId { get; set; }
    [ForeignKey("MedicalRecordId")]
    public EntityVeternayMedicalRecord MedicalRecord { get; set; }

    public ICollection<EntityVeternayBookingService> BookingServices { get; set; } = new List<EntityVeternayBookingService>();
}
