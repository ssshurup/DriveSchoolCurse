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
    
    public partial class employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee()
        {
            this.drivingLesson = new HashSet<drivingLesson>();
            this.theoryLesson = new HashSet<theoryLesson>();
            this.studGroup = new HashSet<studGroup>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public Nullable<int> idPost { get; set; }
        public Nullable<int> idVehicle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drivingLesson> drivingLesson { get; set; }
        public virtual vehicles vehicles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<theoryLesson> theoryLesson { get; set; }
        public virtual post post { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<studGroup> studGroup { get; set; }
    }
}
