using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanDDDCQRS.Application
{
    public class UpdateCustomerCommand : IRequest
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
    }

}
