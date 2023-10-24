using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidersDomain.ViewModels.Order
{
    public class OrderError
    {
        public OrderError(string message) { Message = message; }
        public string Message { get; set; } = string.Empty;
    }
}
