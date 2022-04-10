
using ParcelDelivery.Core.ParcelManagement;
using System;

namespace ParcelDelivery.Core.Department
{
    /// <summary>
    /// This department allocated for parcel weight bigger than 10
    /// </summary>
    public class HeavyDepartment : BaseDepartment
    {
        protected override void AddToDepartment()
        {
            Console.WriteLine("The parcel added to the HeavyDepartment!");
        }

        protected override ParcelProcess DeliverParcel()
        {
            ParcelProcess parcel = new HeavyParcelProcess();
            return parcel;
        }
    }
} 
