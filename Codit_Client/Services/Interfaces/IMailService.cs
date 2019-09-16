using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codit_Client.Models;

namespace Codit_Client.Services
{
    interface IMailService
    {

        /// <summary>
        /// Client send email to contact 
        /// </summary>
        /// <param name="model"></param>
        void SendMail(Client model);


    }
}
