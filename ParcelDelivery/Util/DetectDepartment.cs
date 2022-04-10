using ParcelDelivery.Core.Department;

namespace ParcelDelivery.Util
{

    public static class DetectDepartment
    {
        /// <summary>
        /// Find True department based on weight
        /// </summary>
        /// <param name="weight">Weight of the parcel</param>
        /// <returns>An object of The found department</returns>
        public static BaseDepartment ByWeight(double weight)
        {
            BaseDepartment shipmentProcess = null;
            switch (weight)
            {
                case double n when n <= 1: { shipmentProcess = new MailDepartment(); break; }
                case double n when n > 1 && n <= 10: { shipmentProcess = new RegularDepartment(); break; }
                case double n when n > 10: { shipmentProcess = new HeavyDepartment(); break; }
                default: { shipmentProcess = new MailDepartment(); break; }
            }
            return shipmentProcess;
        }
    }
}
