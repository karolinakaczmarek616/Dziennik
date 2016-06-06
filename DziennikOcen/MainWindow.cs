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
        DataGridView dataGridView;
        SplitContainer splitContainer;
        TableLayoutPanel tableLayoutPanel;
        // Podczas logowania musi zostać tu wpisany userId.
        // Utwórz obiekt MainWindow a potem wpisz mu wartość userId przed usunięciem okna logowania.
        public int userId { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            doe = new dziennik_ocenEntities();
            userId = 2; // DO USUNIĘCIA!!!
            //ocenyprojektBindingSource.DataSource = (from temp in doe.oceny_projekt
            //                     select new { temp.student_id, temp.projekt_id, temp.ocena, temp.data }).ToList();
            //studenciBindingSource.DataSource = (from temp in doe.studenci select new { temp.student_id, temp.imie, temp.nazwisko, temp.nr_indexu, temp.kierunek, temp.grupa, temp.email, temp.haslo }).ToList();

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Wywołanie metody, która tworzy menu główne (zrobione przeze mnie).
            createMainMenu();
        }

        private void buttonZmienOcene_Click(object sender, EventArgs e)
        {
            //var query = from temp in doe.oceny_projekt where temp.student_id == 1 select temp;
            //foreach(var x in query)
            //{
            //    if(textBoxOcena.Text != "")
            //        x.ocena = Convert.ToDecimal(textBoxOcena.Text);
            //}
            //try
            //{
            //    doe.SaveChanges();
            //} catch (InvalidOperationException exc)
            //{
            //    Console.WriteLine(exc);
            //}
        }

        private void buttonStudenci_Click(object sender, EventArgs e)
        {
            // Usuwanie layoutu z przyciskami (menu główne)
            Controls.RemoveAt(0);
            // Tworzenie nowego dzielonego kontenera (on ma tylko dwa panele: Panel1 i Panel2).
            splitContainer = new SplitContainer();
            // Ustawienie dokowania tak, żeby zajmowało przestrzeń całego MainWindow.
            splitContainer.Dock = DockStyle.Fill;
            // Ustawienie orientacji paneli.
            splitContainer.Orientation = Orientation.Horizontal;
            // Dodanie dzielonego kontenera do MainWindow.
            Controls.Add(splitContainer);
            // Tworzenie tabeli, w której wyświetlą się wyniki.
            dataGridView = new DataGridView();
            // Ustawienie dokowania na "wypełnienie", żeby tabelka zajmowała całe okno.
            dataGridView.Dock = DockStyle.Fill;
            // Wysłanie zapytania do bazy danych.
            dataGridView.DataSource = (from temp in doe.oceny_przedmiot
                                       select new { temp.student_id, temp.przedmiot_id, temp.ocena, temp.data }).ToList();
            // Dodanie tabelki do pierwszego panelu dzielonego kontenera, żeby było je widać.
            splitContainer.Panel1.Controls.Add(dataGridView);
            // Utworzenie przycisku, który umożliwi powrót do menu głównego.
            Button buttonWroc = new Button();
            // Wpisanie tekstu do przycisku.
            buttonWroc.Text = "Wróć";
            // Ustawienie eventu dla przycisku (funkcji) o nazwie butonWroc_Click.
            buttonWroc.Click += buttonWroc_Click;
            // Dodanie przycisku do drugiego panelu dzielonego kontenera.
            splitContainer.Panel2.Controls.Add(buttonWroc);
        }

        private void buttonWroc_Click(object sender, EventArgs e)
        {
            createMainMenu();
        }

        private void buttonOceny_Click(object sender, EventArgs e)
        {
            Controls.RemoveAt(0);
            // Tworzenie tabeli, w której wyświetlą się wyniki.
            dataGridView = new DataGridView();
            // Ustawienie dokowania na "wypełnienie", żeby tabelka zajmowała całe okno.
            dataGridView.Dock = DockStyle.Fill;
            // Wysłanie zapytania do bazy danych.
            dataGridView.DataSource = (from temp in doe.oceny_przedmiot
                                           // Wybieramy tylko te oceny, które należą do danego studenta.
                                       where temp.student_id == userId
                                       select new { temp.przedmiot_id, temp.ocena, temp.data }).ToList();
            // Dodanie tabelki do MainWindow, żeby było je widać.
            Controls.Add(dataGridView);
            // Utworzenie przycisku, który umożliwi powrót do menu głównego.
            Button buttonWroc = new Button();
            // Wpisanie tekstu do przycisku.
            buttonWroc.Text = "Wróć";
            // Ustawienie eventu dla przycisku (funkcji) o nazwie butonWroc_Click.
            buttonWroc.Click += buttonWroc_Click;
            Controls.Add(buttonWroc);
        }
        // Metoda tworząca główne menu.
        private void createMainMenu()
        {
            // Domyślnie w MainWindow jest tylko jedna kontrolka (layout), więc usuwamy pierwszy element z listy kontrolek
            // czyli ten layout. Musi tak być, ponieważ za każdym razem może być co innego.
            Controls.RemoveAt(0);
            // Tworzymy layout tabelkowy.
            tableLayoutPanel = new TableLayoutPanel();
            // Ustawiamy dokowanie tak, żeby się rozciągało na całe MainWindow.
            tableLayoutPanel.Dock = DockStyle.Fill;
            // Dodajemy layout do MainWindow.
            Controls.Add(tableLayoutPanel);

            // Tworzymy przycisk.
            Button button = new Button();
            // Wstawiamy tekst.
            button.Text = "Studenci";
            // Ustawiamy event, czyli funkcję, która zostanie wywołana, kiedy się go wciśnie.
            button.Click += buttonStudenci_Click;
            // Dodajemy przycisk do layoutu (podajemy referencję do przycisku, numer kolumny i numer wiersza).
            tableLayoutPanel.Controls.Add(button, 0, 0);

            button = new Button();
            button.Text = "Projekty";
            button.Click += buttonStudenci_Click; // ZMIEŃ
            tableLayoutPanel.Controls.Add(button, 1, 0);

            button = new Button();
            button.Text = "Oceny";
            button.Click += buttonOceny_Click;
            tableLayoutPanel.Controls.Add(button, 0, 1);

            button = new Button();
            button.Text = "Przedmioty";
            button.Click += buttonStudenci_Click; // ZMIEŃ
            tableLayoutPanel.Controls.Add(button, 1, 1);
        }
    }
}
