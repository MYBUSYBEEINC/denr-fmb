﻿namespace FMB_CIS.Models
{
    public class tbl_brand
    {
        public int id { get; set; }
        public string name { get; set; } // Stihl, Makita, Hitachi
        public string description { get; set; }
        public bool? is_active { get; set; }
        public int createdBy { get; set; }
        public int modifiedBy { get; set; }
        public DateTime? date_created { get; set; }
        public DateTime? date_modified { get; set; }
    }
}