using System;

namespace SLK.XClinic.Abstract;

public class ModelNotification
{
    public DateTime NotityTime { get; set; }

    public string Message { get; set; }

    public string Href { get; set; }

    public DateTime Expired { get; set; }
}