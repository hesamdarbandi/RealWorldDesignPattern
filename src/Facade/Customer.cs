using System;
namespace Facade
{
    public class Customer
    {
        private string _name;
        public Customer(string name)
        {
            _name = name;
        }
       
        public string Name
        {
            get { return _name; }
        }
    }
}
