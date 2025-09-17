using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore; 

[Table("VETERNAY_CUSTOMER")]
public class EntityVeternayCustomer : EntityBase
{

    public string FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public string Avatar { get; set; }
    public string Address { get; set; }

    public string CitizenID { get; set; }
    public DateTime? DateOfBirth  { get; set; }
    public string Note { get; set; }
    public bool IsDeleted { get; set; } = false;
    public ICollection<EntityveternayPet> Pets { get; set; } = new List<EntityveternayPet>();

}