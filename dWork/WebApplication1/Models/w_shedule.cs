//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class w_shedule
    {
        public int ID_line { get; set; }
        public System.DateTime sh_date { get; set; }
        public int ID_worker { get; set; }
        public bool visit { get; set; }
        public double day_gain { get; set; }
    
        public virtual workers workers { get; set; }
    }
}