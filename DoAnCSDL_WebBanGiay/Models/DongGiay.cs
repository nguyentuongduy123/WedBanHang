
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
    
public partial class DongGiay
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public DongGiay()
    {

        this.SanPhams = new HashSet<SanPham>();

    }


    public int MaDongGiay { get; set; }

    public string TenDongGiay { get; set; }

    public string Icon { get; set; }

    public string DongDB { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<SanPham> SanPhams { get; set; }

}

}