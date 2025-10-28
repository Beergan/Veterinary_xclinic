using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLK.XClinic.Abstract;
using Syncfusion.Blazor.Gantt.Internal;

namespace SLK.XClinic.ModuleVeternayCore;
[Table("VETERNAY_BOOKING_SERVICE")]
public class EntityVeternayBookingService : EntityBase
{
    public Guid GuidBooking { get; set; }
    public string TitleService { get; set; }
    public int ? BookingId { get; set; }
    [ForeignKey("BookingId")]
    public EntityVeternayBooking  Booking { get; set; }
    public decimal Price { get; set; }
    public Guid GuidService { get; set; }
    public int ? ServiceId { get; set; }
    [ForeignKey("ServiceId")]
    public EntityVeternayServices Service { get; set; }
}
