using System;
using MediatR;

namespace SLK.XClinic.Base;

public class Event_NewMonth : INotification
{
    public DateTime Date { get; set; }
}