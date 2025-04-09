using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge3
{
    public class person
    {
        protected string name;
        protected string address;

        public person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string GetName() => name;
        public string GetAddress() => address;
        public void SetAddress(string newAddress) => address = newAddress;

        public override string ToString() => $"Person[name={name}, address={address}]";
    }

}
