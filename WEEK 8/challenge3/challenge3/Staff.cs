using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace challenge3
{
    public class Staff : person
    {
        private string school;
        private double pay;

        public Staff(string name, string address, string school, double pay)
            : base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }

        public string GetSchool() => school;
        public void SetSchool(string school) => this.school = school;
        public double GetPay() => pay;
        public void SetPay(double pay) => this.pay = pay;
        public override string ToString() =>
        $"Staff[name={name}, address={address}, school={school}, pay={pay}]";
    }

}
