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
    
    public partial class Product
    {
        public Product()
        {
            this.Tests = new HashSet<Tests>();
        }
    
        public int id_Products { get; set; }
        public string Name { get; set; }
        public Nullable<int> id_Category { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual ICollection<Tests> Tests { get; set; }
    }
}
