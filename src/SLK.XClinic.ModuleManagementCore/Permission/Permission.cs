using System;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.ModuleManagementCore;

[Feature(Name = "ModuleManagement", TextEn = "", TextVi = "MODULE QUẢN TRỊ")]
public enum PERMISSION
{
    [Function(TextEn = "", TextVi = "Quản trị")]
    ADMIN_ACCOUNTS,

    [Function(TextEn = "", TextVi = "Xem logs hệ thống")]
    AUDIT_LOG,
}