using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleVeternayCore; 

[Feature(Name = "ModuleCustomer", TextEn = "", TextVi = "MODULE KHÁCH HÀNG")]
public enum PERMISSION
{
    [Function(TextEn = "", TextVi = "Xem danh sách khách hàng")]
    CUSTOMER_VIEW,

    [Function(TextEn = "", TextVi = "Xem hồ sơ khách hàng")]
    FILE_CUSTOMER_VIEW,

    [Function(TextEn = "", TextVi = "Tạo mới/ hiệu chỉnh khách hàng")]
    CUSTOMER_CREATE_UPDATE,

    [Function(TextEn = "", TextVi = "Kích hoạt tài khoản khách hàng")]
    CUSTOMER_ACTIVE_ACCOUNT,
}