
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DoAnCSDL_WebBanGiay.Models
{

using System;
    using System.Collections.Generic;
    
public partial class SoLuongSize
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public SoLuongSize()
    {

        this.ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();

    }


    public int MaSizeSP { get; set; }

    public Nullable<int> MaSP { get; set; }

    public string Size { get; set; }

    public Nullable<int> SoLuong { get; set; }



    public virtual BangSize BangSize { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }

    public virtual SanPham SanPham { get; set; }

}

}
