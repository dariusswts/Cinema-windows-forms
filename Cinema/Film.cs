using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Film
    {
        public string titlu;
        public string gen;
        public int durata;
        public double pretBilet;
        public int locuriLibere;
        public bool in3D;
        public string regizor;

        
        public Film()
        {
            titlu = "Fara titlu";
            gen = "Necunoscut";
            durata = 90;
            pretBilet = 20;
            locuriLibere = 100;
            in3D = false;
            regizor = "Necunoscut";
        }

        
        public Film(string linie)
        {
            string[] v = linie.Split('#');

            titlu = v[0];
            gen = v[1];
            durata = int.Parse(v[2]);
            pretBilet = double.Parse(v[3]);
            locuriLibere = int.Parse(v[4]);
            in3D = bool.Parse(v[5]);
            regizor = v[6];
        }

        
        public Film(string titlu, string gen, int durata,
                    double pretBilet, int locuriLibere,
                    bool in3D, string regizor)
        {
            this.titlu = titlu;
            this.gen = gen;
            this.durata = durata;
            this.pretBilet = pretBilet;
            this.locuriLibere = locuriLibere;
            this.in3D = in3D;
            this.regizor = regizor;
        }

        public double IncasarePosibila()
        {
            return locuriLibere * pretBilet;
        }
        public string RandDeLista()
        {
            return titlu + " (" + gen + ") - " + durata +
                   " min - " + pretBilet + " lei";
        }
    }
}
