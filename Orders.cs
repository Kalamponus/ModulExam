//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModulExam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public int placeId { get; set; }
    
        public virtual DeliveryPlaces DeliveryPlaces { get; set; }
        public virtual Order Order { get; set; }
    }
}
