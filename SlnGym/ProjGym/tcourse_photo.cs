//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjGym
{
    using System;
    using System.Collections.Generic;
    
    public partial class tcourse_photo
    {
        public int course_photo_id { get; set; }
        public Nullable<int> class_schedule_id { get; set; }
        public string course_photo { get; set; }
    
        public virtual tclass_schedule tclass_schedule { get; set; }
    }
}
