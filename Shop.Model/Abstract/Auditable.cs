﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public  DateTime? CreateDate { get; set; }

        [MaxLength(256)]
        public  string CreateBy { get; set; }

        public  DateTime? UpdateDate { get; set; }

        [MaxLength(256)]
        public  string UpdateBy { get; set; }

        [MaxLength(256)]
        public  string MetaKeyword { get; set; }

        [MaxLength(256)]
        public  string MetaDescription { get; set; }

        public  bool Status { get; set; }
    }
}