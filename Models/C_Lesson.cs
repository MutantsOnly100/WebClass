//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClass.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_Lesson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_Lesson()
        {
            this.C_LessonCheckTime = new HashSet<C_LessonCheckTime>();
            this.M_MessageBoard = new HashSet<M_MessageBoard>();
        }
    
        public int LessonID { get; set; }
        public string LessonName { get; set; }
        public string LessonVideo { get; set; }
        public string LessonContent { get; set; }
        public int ClassID { get; set; }
    
        public virtual C_Class C_Class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_LessonCheckTime> C_LessonCheckTime { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_MessageBoard> M_MessageBoard { get; set; }
    }
}
