//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Klient
    {
        public Klient()
        {
            this.Cars = new HashSet<Car>();
            this.Zakazs = new HashSet<Zakaz>();
        }
    
        public int IdKlient { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<Zakaz> Zakazs { get; set; }
    }
}
