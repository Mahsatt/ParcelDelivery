using ParcelDelivery.Core.Department;
using ParcelDelivery.DataLayer.Util;
using ParcelDelivery.Util;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ParcelDelivery
{
    public class Program
    {
        static BaseDepartment shipmentProcess = null;

        /// <summary>
        /// Recieve file path, read file and fill list of parcel.
        /// Finde the right department base on parcel weight and check it needs Insurance or not
        /// </summary>
        /// <param name="args"></param>
        static async Task Main(string[] args)
        {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"..\\..\\..\\Files\\ContainerSample.xml");
            var parcelsList = ReadFromFile.ReadParcelXml(filePath);

            if (parcelsList == null || parcelsList.Count() == 0)
                Console.WriteLine("No parcel to shipment!");
            else
            {
                //Find the right for each parcel department base on weight
                //Check Insurance need or not
                foreach (var parcel in parcelsList)
                {
                    shipmentProcess = DetectDepartment.ByWeight(parcel.Weight);
                    await shipmentProcess.StartParcelProcessAsync(parcel);
                }
            }

            Console.ReadLine();
        }
    }
}
