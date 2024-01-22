using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Kunde
    {
        private int id;
        private string anrede;
        private string name;
        private string vorname;
        private string straße;
        private int plz;
        private string ort;
        private string mail;
        private int tel;
        private int kat_nr;

        public Kunde() { }

        public Kunde(int id, string anrede, string name, string vorname, string straße, int plz, string ort, string mail, int tel, int kat_nr)
        {
            this.id = id;
            this.anrede = anrede;
            this.name = name;
            this.vorname = vorname;
            this.straße = straße;
            this.plz = plz;
            this.ort = ort;
            this.mail = mail;
            this.tel = tel;
            this.kat_nr = kat_nr;
        }

        public int Id { get => id; set => id = value; }
        public string Anrede { get => anrede; set => anrede = value; }
        public string Name { get => name; set => name = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Straße { get => straße; set => straße = value; }
        public int Plz { get => plz; set => plz = value; }
        public string Ort { get => ort; set => ort = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Tel { get => tel; set => tel = value; }
        public int Kat_nr { get => kat_nr; set => kat_nr = value; }
    }
}
