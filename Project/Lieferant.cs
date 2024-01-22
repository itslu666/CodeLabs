using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Lieferant
    {
        private int id;
        private string name;
        private string straße;
        private string plz;
        private string ort;
        private string mail;
        private int tel;

        public Lieferant() { }
        public Lieferant(int id, string name, string straße, string plz, string ort, string mail, int tel)
        {
            this.id = id;
            this.name = name;
            this.straße = straße;
            this.plz = plz;
            this.ort = ort;
            this.mail = mail;
            this.tel = tel;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Straße { get => straße; set => straße = value; }
        public string Plz { get => plz; set => plz = value; }
        public string Ort { get => ort; set => ort = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Tel { get => tel; set => tel = value; }
    }
}
