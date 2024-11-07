﻿using CleanDDDCQRS.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanDDDCQRS.Application
{
    public class GetCustomersQuery : IRequest<List<Customer>>
    {
    }

}
