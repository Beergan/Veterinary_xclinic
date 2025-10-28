using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore;

[Table("VETERNAY_MEDICATION")]
public class EntityVeternayMedication : EntityBase
{
    [Required(ErrorMessage = "Vui lòng nhập tên loại thuốc")]
    [Display(Name = "Tên loại thuốc")]
    public string Name { get; set; }
    [Display(Name = "Mô tả")]
    public string Description { get; set; }
    public string Unit { get; set; }
    [Range(0, double.MaxValue)]
    [Required(ErrorMessage = "Vui lòng nhập giá nhập")]
    [Display(Name = "Giá nhập")]
    public decimal ImportPrice { get; set; } = decimal.Zero;
    [Required(ErrorMessage = "Vui lòng nhập giá bán")]
    [Display(Name = "Giá bán")]
    public decimal Price { get; set; } = decimal.Zero;
    [Required(ErrorMessage = "Vui lòng nhập kiểu thuốc")]
    [Display(Name = "Kiểu thuốc")]
    public string Type { get; set; }
    public string RecommendedDosage { get; set; }
    [Display(Name = "Trạng thái")]
    public bool IsDeleted { get; set; } = true;
    [Required(ErrorMessage = "Vui lòng nhập số lượng")]
    public int StockQuantity { get; set; } = 0;
    [Display(Name = "Đơn giá")]
    [Required(ErrorMessage = "Vui lòng nhập đơn giá thuốc")]
    public string? UnitType { get; set; }
    [Display(Name = "Mã thuốc")]
    [Required(ErrorMessage = "Vui lòng nhập mã thuốc")]
    public string? MedicationCode { get; set; }
    [ForeignKey("CategoryId")]
    [Display(Name = "Danh muc")]
    public EntityVeternayMedicationCategory Category { get; set; }
    public int? CategoryId { get; set; }
}
