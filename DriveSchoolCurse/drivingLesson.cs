//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DriveSchoolCurse
{
    using System;
    using System.Collections.Generic;
    
    public partial class drivingLesson
    {
        public int id { get; set; }
        public Nullable<System.DateTime> dateLesson { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<int> idEmployee { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual Students Students { get; set; }
    }
}
