
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace QuanLyNhanSu.Models
{

using System;
    using System.Collections.Generic;
    
public partial class CapNhatLuong
{

    public int id { get; set; }

    public string MaNhanVien { get; set; }

    public int LuongHienTai { get; set; }

    public int LuongSauCapNhat { get; set; }

    public Nullable<double> BHXH { get; set; }

    public Nullable<double> BHYT { get; set; }

    public Nullable<double> BHTN { get; set; }

    public Nullable<double> PhuCap { get; set; }

    public Nullable<double> ThueThuNhap { get; set; }

    public Nullable<System.DateTime> NgayCapNhat { get; set; }

    public Nullable<double> HeSoLuong { get; set; }



    public virtual Luong Luong { get; set; }

}

}
