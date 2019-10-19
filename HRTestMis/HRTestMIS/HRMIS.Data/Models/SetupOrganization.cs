using System;
using System.Collections.Generic;

namespace HRMIS.Data.Models
{
    public partial class SetupOrganization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortHandName { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string SiteUrl { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
