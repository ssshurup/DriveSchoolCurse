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
    
    public partial class studGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public studGroup()
        {
            this.StudentAndGroup = new HashSet<StudentAndGroup>();
            this.theoryLesson = new HashSet<theoryLesson>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> idEmployee { get; set; }
        public Nullable<int> idResponsible { get; set; }
    
        public virtual employee employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentAndGroup> StudentAndGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<theoryLesson> theoryLesson { get; set; }
        public virtual users users { get; set; }
    }
}
