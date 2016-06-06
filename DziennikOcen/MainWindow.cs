using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DziennikOcen
{
    public partial class MainWindow : Form
    {
        dziennik_ocenEntities doe;

        public MainWindow()
        {
            InitializeComponent();
            doe = new dziennik_ocenEntities();
            //ocenyprojektBindingSource.DataSource = doe.oceny_projekt;

            ocenyprojektBindingSource.DataSource = (from temp in doe.oceny_projekt
                                 select new { temp.student_id, temp.projekt_id, temp.ocena, temp.data }).ToList();
            studenciBindingSource.DataSource = (from temp in doe.studenci select new { temp.student_id, temp.imie, temp.nazwisko, temp.nr_indexu, temp.kierunek, temp.grupa, temp.email, temp.haslo }).ToList();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonZmienOcene_Click(object sender, EventArgs e)
        {
            var query = from temp in doe.oceny_projekt where temp.student_id == 1 select temp;
            foreach(var x in query)
            {
                if(textBoxOcena.Text != "")
                    x.ocena = Convert.ToDecimal(textBoxOcena.Text);
            }
            try
            {
                doe.SaveChanges();
            } catch (InvalidOperationException exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}
