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
        [Key]
        public int ProjectId;

        public string ProjectName;

        public ProjectType ProjectType;

        public DateTime ProjectCreateTime;

        public DateTime ProjectStartTime;

        public DateTime ProjectDeadline;
    }
}
