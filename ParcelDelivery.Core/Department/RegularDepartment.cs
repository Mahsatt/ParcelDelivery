
using ParcelDelivery.Core.ParcelManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDelivery.Core.Department
{

    /// <summary>
    /// This department allocated for parcel weight between 0.5 and 10
    /// </summary>
    public class RegularDepartment : BaseDepartment
    {
        protected override void AddToDepartment()
        {
            Console.WriteLine("The parcel added to the RegularDepartment!");
        }
        protected override ParcelProcess DeliverParcel()
        {
            ParcelProcess parcel = new RegularParcelProcess();
            return parcel;
        }
    }
}
