using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParcelDelivery.Core.ParcelManagement
{
    public class RegularParcelProcess : ParcelProcess
    {
        public override async Task ParcelBoxing()
        {
            await Task.Delay(1);
            Console.WriteLine("Regular Parcel Boxing Is Done!");
        }
    }
}
