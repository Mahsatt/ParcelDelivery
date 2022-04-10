using System;
using System.Threading.Tasks;
using ParcelDelivery.Core.ParcelManagement;
using ParcelDelivery.DataLayer.Model;


namespace ParcelDelivery.Core.Department
{
    public abstract class BaseDepartment
    {
        /// <summary>
        /// Process the Parcel base on Value and Weight
        /// </summary>
        /// <param name="newParcel"></param>
        /// <returns>ParcelProcess</returns>
        public async Task<ParcelProcess> StartParcelProcessAsync(Parcel newParcel)
        {
            ParcelProcess parcelProcess = DeliverParcel();
            try
            {
                if (newParcel != null && newParcel.Value >= 1000)
                {
                    await parcelProcess.SignedOffParcel(newParcel);
                }
                await parcelProcess.ParcelBoxing();
                await parcelProcess.ParcelControl();
                await parcelProcess.LableParcel(newParcel);
            }
            catch (Exception ex)
            {
                Console.WriteLine("This Exception: " + ex.Message + " has been accurd! ");
            }
            return parcelProcess;
        }

        /// <summary>
        ///Add Parcel department
        /// </summary>
        protected abstract void AddToDepartment();

        /// <summary>
        /// Deliver parcel to destination
        /// </summary>
        /// <returns>ParcelProcess</returns>
        protected abstract ParcelProcess DeliverParcel();
    }
}
