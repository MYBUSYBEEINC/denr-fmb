﻿namespace FMB_CIS.Models
{
    public class ViewModel
    {
        public IEnumerable<tbl_chainsaw>? tbl_Chainsaws { get; set; }
        public IEnumerable<ApplicationModel>? applicationModels { get; set; }
        public ChainsawSeller? chainsawSeller { get; set; }
        public tbl_application? tbl_Application { get; set; }

    }
}
