namespace ParcelDelivery.DataLayer.Model
{
    public class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public Person()
        {
            Address = new Address();
        }
    }
}
