namespace Customer_API
{
    public class CustomerType
    {
        public CustomerType(string name, int age, bool isSuperMember)
        {
            Name = name;
            Age = age;
            IsSuperMember = isSuperMember;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsSuperMember { get; set; }

    }
}
