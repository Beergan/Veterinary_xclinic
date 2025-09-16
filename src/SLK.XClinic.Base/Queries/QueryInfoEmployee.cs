using System;
using MediatR;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.Base;

public class QueryInfoEmployee : IRequest<ModelInfoEmployee>
{
    public Guid Guid { get; set; }
}