namespace ContactBook.Core
{
    public class Contact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public NationalityType Nationality { get; set; }
    }
}
