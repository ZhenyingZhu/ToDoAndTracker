using Microsoft.AspNetCore.Authorization;
using System;

namespace ToDoAndTracker.Models
{
    [Authorize]
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}