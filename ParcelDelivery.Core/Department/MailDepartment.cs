
using ParcelDelivery.Core.ParcelManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery.Core.Department
{
    /// <summary>
    /// This department allocated for parcel weight under 0.5
    /// </summary>
    public class MailDepartment : BaseDepartment
    {
        protected override void AddToDepartment()
        {
            Console.WriteLine("The parcel added to the MailDepartment!");
        }
        /// <summary>
        /// Each DeliveryParcel Method creats a Pacel Object
        /// </summary>
        /// <returns>ParcelProcess Object</returns>
        protected override ParcelProcess DeliverParcel()
        {
            ParcelProcess parcel = new MailParcelProcess();
            return parcel;
        }
    }
}
