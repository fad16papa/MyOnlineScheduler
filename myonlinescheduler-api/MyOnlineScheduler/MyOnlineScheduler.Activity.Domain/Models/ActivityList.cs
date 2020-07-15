using System;
using System.Collections.Generic;
using System.Text;

namespace MyOnlineScheduler.Activity.Domain.Models
{
    public class ActivityList
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}
