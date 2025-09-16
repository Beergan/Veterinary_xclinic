using System;
using System.Collections.Generic;
using MediatR;
using SLK.XClinic.Abstract;

namespace SLK.XClinic.Base;

public class QueryOptionCompany : IRequest<OptionItem<Guid>>
{
}