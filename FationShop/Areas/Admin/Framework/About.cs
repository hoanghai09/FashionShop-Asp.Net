//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FationShop.Areas.Admin.Framework
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public partial class About
    {
        public int ID { get; set; }
        public string MetaTitle { get; set; }
        [AllowHtml]
        public string Description { get; set; }
        [AllowHtml]
        public string Content { get; set; }
        public string Avartar { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
