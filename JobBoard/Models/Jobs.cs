using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;

namespace JobBoard.Models
{
    public class Jobs
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("TITLE")]
        public string Job_Title { get; set; }
        [DisplayName("DESCRIPTION")]
        public string Job_Description { get; set; }
        [DisplayName("CREATED")]
        public DateTime Job_CreatedAt { get; set; }
        [DisplayName("EXPIRED")]
        public DateTime Job_ExpiresAt { get; set; }
        [DisplayName("COMMENTS")]
        public string Job_Comments { get; set; }
    }
    public class JobsDBContext : DbContext
    {
        public DbSet<Jobs> Job { get; set; }

    }
}