namespace Prototype
{
    //You can use Newton for Serilizer and De Serilizer for Clone
    public class Address : ICloneable
    {
        public string State
        { get; set; }
        public string City
        { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    public class Author : ICloneable
    {
        public string Name
        { get; set; }
        public string TwitterAccount
        { get; set; }
        public string Website
        { get; set; }
        public Address HomeAddress
        { get; set; }
        public object Clone()
        {
            Author objPriCopy = (Author)this.MemberwiseClone();
            objPriCopy.HomeAddress = (Address)this.HomeAddress.Clone();
            return objPriCopy;
        }
    }
}
