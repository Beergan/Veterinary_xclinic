using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLK.XClinic.Abstract
{
    public interface IMailSettingService
    {
        Task SendMail(params MailRequest[] mails);
    }
}
