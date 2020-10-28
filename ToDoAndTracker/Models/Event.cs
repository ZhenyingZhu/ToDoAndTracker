using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Models
{
    public enum EventEfficiency
    {
        High,
        Medium,
        Low
    }

    [Authorize]
    public class Event
    {
        public int Id { get; set; }

        public string OwnerId { get; set; }

        // One-to-Many Child.
        public int TaskId { get; set; }
        public Task Task { get; set; }

        [DataType(DataType.DateTime),Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }

        [DataType(DataType.DateTime),Display(Name = "End Time")]
        public DateTime EndTime { get; set; }

        // One-to-Many Child.
        public int DiaryId { get; set; }
        public Diary Diary { get; set; }

        public EventEfficiency Efficiency { get; set; }


    }
}
