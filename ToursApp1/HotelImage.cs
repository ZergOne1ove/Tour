//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToursApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class HotelImage
    {
        public int id { get; set; }
        public int HotelId { get; set; }
        public byte[] ImageSource { get; set; }
    
        public virtual Hotel1 Hotel1 { get; set; }
    }
}
