using ParcelDelivery.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParcelDelivery.Core.ParcelManagement
{
    /// <summary>
    /// ParcelControl, ParcelBoxing and LableParcel are common between all departments.
    /// Retrieve informations about xontroling, boxing and lablig parcel.
    /// </summary>
    public abstract class ParcelProcess 
    {
        public virtual async Task SignedOffParcel(Parcel parcel)
        {
            await Task.Delay(1);
            Console.WriteLine("The Parcel had been signed off by the Insurance Department");
        }
        public virtual async Task ParcelControl()
        {
            await Task.Delay(1);
            Console.WriteLine("Parcel Control Is Done!");
        }
        public virtual async Task ParcelBoxing()
        {
            await Task.Delay(1);
            Console.WriteLine("Parcel Boxing Is Done!");
        }

        public virtual async Task LableParcel(Parcel parcel)
        {
            await Task.Delay(1);
            Console.WriteLine($"Parcel Has a lable now! Its going to send from: {parcel.Sender.Name} to: {parcel.Recipient.Name} \n");
        }
    }

}
