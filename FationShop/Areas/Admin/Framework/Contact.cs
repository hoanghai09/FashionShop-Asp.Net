﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class Contact
    {
        public int ID { get; set; }
        [Display(Name ="Tiêu đề")]
        public string SubTitle { get; set; }
        [AllowHtml]
        [Display(Name = "Nội dung")]
        public string Content { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        public string Hotline { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Iframe Google Map")]
        public string GoogleMap { get; set; }
        [Display(Name = "Trạng thái hiển thị")]
        public bool Status { get; set; }
    }
}
