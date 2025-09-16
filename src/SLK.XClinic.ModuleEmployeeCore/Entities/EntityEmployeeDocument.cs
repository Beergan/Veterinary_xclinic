using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleEmployeeCore;

[Table("EMPLOYEE_DOCUMENT")]
public class EntityEmployeeDocument : EntityBase
{
    public Guid GuidEmployeePost { get; set; }

    public string NameEmployeePost { get; set; }

    public Guid GuidEmployee { get; set; }

    public string NameFile { get; set; }

    public string TypeFile { get; set; }

    public string FolderName { get; set; }
}