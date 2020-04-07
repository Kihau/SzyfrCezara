using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ZaładujZnaki();
            textBoxCiąg.Text = AktualizujZnaki();
            textBoxCiąg.ScrollBars = ScrollBars.Vertical;
        }

        List<char> znaki = new List<char>();
        List<char> małe = new List<char>();

        List<char> małe_polskie = new List<char> { 'ą', 'ć', 'ę', 'ł', 'ń', 'ó', 'ś', 'ź', 'ż' };
        List<char> duże_polskie = new List<char> { 'Ą', 'Ć', 'Ę', 'Ł', 'Ń', 'Ó', 'Ś', 'Ź', 'Ż' };

        bool JestSpacja { get; set; }
        bool SąPolskie { get; set; }
        bool SąMałe { get; set; }

        private void ZaładujZnaki()
        {
            for (int i = 97; i <= 122; i++)
                małe.Add((char)i);

            for (int i = 65; i <= 90; i++)
                znaki.Add((char)i);
        }

        private string AktualizujZnaki()
        {
            textBoxZnakiIlość.Text = znaki.Count.ToString();

            string napis = "";

            foreach (char c in znaki)
                if (c == ' ') napis += "spacja, ";
                else napis += c.ToString() + ", ";
            
            return napis;
        }

        private void buttonZaszyfruj_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder builder = new StringBuilder(textBoxWejście.Text);
                int klucz = Int32.Parse(textBoxKlucz.Text);

                for (int i = 0; i < builder.Length && klucz <= znaki.Count; i++)
                {
                    if ((builder[i] != ' ' || JestSpacja) && (!duże_polskie.Contains(builder[i]) || SąPolskie) &&
                        (!małe.Contains(builder[i]) || SąMałe) && (!małe_polskie.Contains(builder[i]) || (SąPolskie && SąMałe)))
                    {
                        int nowyindex = znaki.IndexOf(builder[i]) + klucz;
                        if (nowyindex >= znaki.Count) builder[i] = znaki[nowyindex - znaki.Count];
                        else builder[i] = znaki[nowyindex];
                    }
                }

                textBoxWyjście.Text = builder.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Wprowadzono niepoprawne dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOdszyfruj_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder builder = new StringBuilder(textBoxWejście.Text);
                int klucz = Int32.Parse(textBoxKlucz.Text);

                for (int i = 0; i < builder.Length && klucz <= znaki.Count; i++)
                {
                    if ((builder[i] != ' ' || JestSpacja) && (!duże_polskie.Contains(builder[i]) || SąPolskie) &&
                        (!małe.Contains(builder[i]) || SąMałe) && (!małe_polskie.Contains(builder[i]) || (SąPolskie && SąMałe)))
                    {
                        int nowyindex = znaki.IndexOf(builder[i]) - klucz;
                        if (nowyindex < 0) builder[i] = znaki[nowyindex + znaki.Count];
                        else builder[i] = znaki[nowyindex];
                    }
                }

                textBoxWyjście.Text = builder.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadzono niepoprawne dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxSpacja_CheckedChanged(object sender, EventArgs e)
        {
            if (!JestSpacja) znaki.Add(' ');
            else znaki.Remove(' ');
            textBoxCiąg.Text = AktualizujZnaki();
            JestSpacja = !JestSpacja;
        }

        private void checkBoxPolski_CheckedChanged(object sender, EventArgs e)
        {
            if (!SąPolskie)
            {
                znaki.AddRange(duże_polskie);
                if (SąMałe) znaki.AddRange(małe_polskie);
            }
            else
            {
                znaki.RemoveRange(znaki.IndexOf(duże_polskie[0]), duże_polskie.Count);
                if (SąMałe) znaki.RemoveRange(znaki.IndexOf(małe_polskie[0]), małe_polskie.Count);
            }

            textBoxCiąg.Text = AktualizujZnaki();
            SąPolskie = !SąPolskie;
        }

        private void checkBoxMałe_CheckedChanged(object sender, EventArgs e)
        {
            if (!SąMałe)
            {
                if(SąPolskie) znaki.AddRange(małe_polskie);
                znaki.AddRange(małe);
            }
            else
            {
                if (SąPolskie) znaki.RemoveRange(znaki.IndexOf(małe_polskie[0]), małe_polskie.Count);
                znaki.RemoveRange(znaki.IndexOf(małe[0]), małe.Count);
            }

            textBoxCiąg.Text = AktualizujZnaki();
            SąMałe = !SąMałe;
        }
    }
}
