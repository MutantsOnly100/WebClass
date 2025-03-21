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
    
    public partial class U_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public U_User()
        {
            this.B_Order = new HashSet<B_Order>();
            this.B_ShoppingCar = new HashSet<B_ShoppingCar>();
            this.C_Class = new HashSet<C_Class>();
            this.C_LessonCheckTime = new HashSet<C_LessonCheckTime>();
            this.M_MessageBoard = new HashSet<M_MessageBoard>();
            this.M_Report = new HashSet<M_Report>();
            this.U_SmallBell = new HashSet<U_SmallBell>();
            this.U_UserSkill = new HashSet<U_UserSkill>();
            this.UC_Follow = new HashSet<UC_Follow>();
            this.UC_Score = new HashSet<UC_Score>();
        }
    
        public int UserID { get; set; }
        public string UserAccount { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public byte[] UserPhoto { get; set; }
        public Nullable<System.DateTime> Birth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int PermissionID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<B_Order> B_Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<B_ShoppingCar> B_ShoppingCar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_Class> C_Class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_LessonCheckTime> C_LessonCheckTime { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_MessageBoard> M_MessageBoard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_Report> M_Report { get; set; }
        public virtual U_Permission U_Permission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<U_SmallBell> U_SmallBell { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<U_UserSkill> U_UserSkill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UC_Follow> UC_Follow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UC_Score> UC_Score { get; set; }
    }
}
