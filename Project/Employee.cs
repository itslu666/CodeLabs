using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Employee
    {
        private string id;
        private string anrede;
        private string name;
        private string vorname;
        private string passwd;
        
        Employee() { }

        Employee(string id, string anrede, string name, string vorname, string passwd)
        {
            this.id = id;
            this.anrede = anrede;
            this.name = name;
            this.vorname = vorname;
            this.passwd = passwd;
        }

        public string Id { get => id; set => id = value; }
        public string Anrede { get => anrede; set => anrede = value; }
        public string Name { get => name; set => name = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Passwd { get => passwd; set => passwd = value; }
    }
}
