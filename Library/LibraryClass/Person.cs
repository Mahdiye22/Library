namespace Library.LibraryClass
{
    public abstract class Person
    {
        public Person(string Name,string LName)
        {
            Email = null;
            PhoneNumber = default;
        }
        public string Name { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}
