﻿using System.ComponentModel.DataAnnotations;

namespace FMB_CIS.Models
{
    public class Workflow
    {
        public int id { get; set; }
        public string workflow_id { get; set; }
        //public string permit_type_code { get; set; }
        //public string workflow_code { get; set; }
        public string workflow_code { get; set; }
        public string permit_type_code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool? is_active { get; set; }
        public int createdBy { get; set; }
        public int modifiedBy { get; set; }
        public DateTime? date_created { get; set; }
        public DateTime? date_modified { get; set; }
        public IEnumerable<WorkflowStep> steps { get; set; }
    }
}
