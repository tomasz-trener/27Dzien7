using P04Zawodnicy.Shared.Services;
using P06Zawodnicy.Shared.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09DynamiczneGenerowanieKontrolerk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "OK";
            b.Location = new Point(100, 100);
            b.Click += przyciskDynamiczny_Click;
            Controls.Add(b);    
        }

        private void przyciskDynamiczny_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Text);
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            IManagerZawodnikow mz = new ManagerZawodnikow();
            var zawodnicy = mz.WczytajZawodnikow();

            int x = 200;
            int y = 10;
            int k = 0;

            foreach (var z in zawodnicy)
            {
                Button b = new Button();
                b.Text = z.ImieNazwisko;
                b.Location=new Point(x, y);
                b.Click += przyciskDynamiczny_Click;
                Controls.Add((b));
                b.Width = 50;
                b.Height = 50;
                x += 60;
                k++;
                if (k == 4)
                {
                    x = 200;
                    y += 60;
                    k = 0;
                }
            }
        }
    }
}
