using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManage
{
    internal class Customer
    {
        private string stk;
        private string name;
        private string address;
        private DateTime dob;
        private string citizenId;
        private string phoneNumber;
        private int monney;
        private DateTime createdAt;
        private DateTime updatedAt;

        public Customer(string stk, string name, string address, DateTime dob, string citizenId, string phoneNumber, int monney)
        {
            this.stk = stk;
            this.name = name;
            this.address = address;
            this.dob = dob;
            this.citizenId = citizenId;
            this.phoneNumber = phoneNumber;
            this.monney = monney;
        }
        public string Stk { get { return stk; } }
        public string Name { get { return name; } }
        public string Address { get { return address; } }
        public DateTime Dob { get { return dob; } }
        public string CitizenId { get { return citizenId; } }
        public string PhoneNumber { get { return phoneNumber; } }
        public int Monney { get { return monney; } }
        public DateTime CreatedAt { get { return createdAt; } }
        public DateTime UpdatedAt { get { return updatedAt; } }

    }
}
