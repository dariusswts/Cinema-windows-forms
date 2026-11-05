using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Cinema
{
    public partial class FilmeForm : Form
    {
        List<Film> lista = new List<Film>();
        private void IncarcaFisier()
        {
            lista.Clear();

            StreamReader streamreader = new StreamReader("Filme.txt");

            streamreader.ReadLine();

            string linie;

            while ((linie = streamreader.ReadLine()) != null)
            {
                if (linie == "")
                {
                    continue;
                }

                lista.Add(new Film(linie));
            }

            
        }
        public FilmeForm()
        {
            InitializeComponent();
        }

        private void FilmeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
