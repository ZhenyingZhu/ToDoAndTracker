using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public enum ProjectType
    {
        Work,
        Household,
        SelfImprove,
        Health,

    }

    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ProjectType Type { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime Deadline { get; set; }
    }
}
