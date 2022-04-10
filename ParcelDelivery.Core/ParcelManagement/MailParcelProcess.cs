using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ParcelDelivery.DataLayer.Model;

namespace ParcelDelivery.Core.ParcelManagement
{
   public class MailParcelProcess : ParcelProcess
    {
        public override async Task ParcelBoxing()
        {
            await Task.Delay(1);
            Console.WriteLine("Mail Parcel Boxing Is Done!");
        }
    }
}
