using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace SLK.XClinic.Abstract;

public class MailRequest
{
    public string ToEmail { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    public List<IFormFile> Attachments { get; set; }
}