//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRW
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tests
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Nullable<int> id_Products { get; set; }
        public Nullable<int> id_Laboratory { get; set; }
        public Nullable<int> id_UsedE { get; set; }
        public Nullable<System.DateTime> Begining_time { get; set; }
        public Nullable<System.DateTime> Ending_time { get; set; }
    
        public virtual Laboratories Laboratories { get; set; }
        public virtual Product Product { get; set; }
        public virtual Used_Enviroments Used_Enviroments { get; set; }
    }
}