using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Artikel
    {
        private int id;
        private string bezeichnung;
        private string description;
        private string price;
        private int wg_nr;

        public Artikel (int id, string bezeichnung, string description, string price, int wg_nr)
        {
            this.id = id;
            this.bezeichnung = bezeichnung;
            this.description = description;
            this.price = price;
            this.wg_nr = wg_nr;
        }

        public int Id { get => id; set => id = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public string Description { get => description; set => description = value; }
        public string Price { get => price; set => price = value; }
        public int Wg_nr { get => wg_nr; set => wg_nr = value; }
    }
}
