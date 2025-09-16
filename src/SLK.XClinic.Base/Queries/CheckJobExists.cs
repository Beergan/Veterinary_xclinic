using System;
using System.Collections.Generic;
using MediatR;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.Base;

public class CheckJobExists : IRequest<bool>
{
    public Guid JobGuid { get; set; }
}