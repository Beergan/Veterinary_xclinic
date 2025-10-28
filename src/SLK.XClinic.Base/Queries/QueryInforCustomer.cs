using System;
using System.Collections.Generic;
using MediatR;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.Base;

public class QueryInforCustomer : IRequest<ModelListCustomer>
{
    public Guid Guid { get; set; }
    public string Id { get; set; }
}