
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ShipmentProducts
{

using System;
    using System.Collections.Generic;
    
public partial class FAS_Shipped_Table
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public FAS_Shipped_Table()
    {

        this.FAS_Shipped_Report = new HashSet<FAS_Shipped_Report>();

    }


    public int ID { get; set; }

    public Nullable<int> count { get; set; }

    public Nullable<System.DateTime> Date { get; set; }

    public Nullable<int> LOTID { get; set; }

    public Nullable<short> Status { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<FAS_Shipped_Report> FAS_Shipped_Report { get; set; }

}

}
