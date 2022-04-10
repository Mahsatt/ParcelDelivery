using NUnit.Framework;
using ParcelDelivery.Core.Department;
using ParcelDelivery.Util;

namespace ParcelDelivery.Test.Util
{
    public class DetectDepartmentTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test to detect right department by different weight
        /// </summary>
        [Test]
        public void DetectDepartmentByWeightTest()
        {
            var result = DetectDepartment.ByWeight(0.5);
            Assert.IsInstanceOf(typeof(MailDepartment), result);

            result = DetectDepartment.ByWeight(1.5);
            Assert.IsInstanceOf(typeof(RegularDepartment), result);

            result = DetectDepartment.ByWeight(14);
            Assert.IsInstanceOf(typeof(HeavyDepartment), result);
        }
    }
}