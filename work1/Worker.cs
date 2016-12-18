using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    public class Worker
    {
        public Worker(string id,string name,string lastname,string email,string phone,string adress,int salary)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastname;
            this.email = email;
            this.phone = phone;
            this.address = adress;
            this.salary = salary;

        }
        public string id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public int salary { get; set; }
    }
}
