using System;

namespace Example_AspNetCore2_2_EfCore_QueryLogging.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}