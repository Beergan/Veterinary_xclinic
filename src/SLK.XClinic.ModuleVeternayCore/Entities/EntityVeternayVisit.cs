using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLK.XClinic.Abstract;


namespace SLK.XClinic.ModuleVeternayCore;
[Table("VETERNAY_VISIT")]
public class EntityVeternayVisit : EntityBase
{
    public Guid GuidVisit { get; set; }
    public Guid GuidBooking { get; set; }
    public string VisitDate { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    public string Reason { get; set; }
    public string Diagnosis { get; set; }
    public string Treatment { get; set; }
    public string Notes { get; set; }
    public bool IsFollowUpNeeded { get; set; } = false;
    public decimal Cost { get; set; } = 0;
    public bool IsPaid { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
}
