namespace ParcelDelivery.DataLayer.Model
{
    public class Parcel
    {
        public Person Sender { get; set; }
        public Person Recipient { get; set; }
        public double Weight { get; set; }
        public double Value { get; set; }
        public Parcel()
        {
            this.Sender = new Person();
            this.Recipient = new Person();
        }
    }
}
