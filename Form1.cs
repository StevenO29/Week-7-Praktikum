using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7_Praktikum
{
    public partial class FormQuizPanda : Form
    {
        public FormQuizPanda()
        {
            InitializeComponent();
        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            string inputKalimat = txtBoxInputKalimat.Text.ToUpper();
            string hurufPertama = txtBoxHurufAwal.Text.ToUpper();
            string hurufKedua = txtBoxHurufDiganti.Text.ToUpper();
            int indexHurufPertama = hurufPertama.ToCharArray()[0];
            int indexHurufKedua = hurufKedua.ToCharArray()[0];
            int selisih = indexHurufKedua - indexHurufPertama;
            for (int i = 0; i < inputKalimat.Length; i++)
            {
                int convertToAscii = inputKalimat[i];
                if (inputKalimat[i] != ' ')
                {
                    if (convertToAscii + selisih < 65 && inputKalimat[i] != ' ')
                        inputKalimat = inputKalimat.Substring(0, i) + (char)(convertToAscii + selisih + 26) + inputKalimat.Substring(i + 1);
                    else if (convertToAscii + selisih > 90 && inputKalimat[i] != ' ')
                        inputKalimat = inputKalimat.Substring(0, i) + (char)(convertToAscii + selisih - 26) + inputKalimat.Substring(i + 1);
                    else
                        inputKalimat = inputKalimat.Substring(0, i) + (char)(convertToAscii + selisih) + inputKalimat.Substring(i + 1);
                }
                else inputKalimat = inputKalimat.Substring(0, i) + ' ' + inputKalimat.Substring(i + 1);
            }
            lblOutput.Text = inputKalimat.ToUpper();
        }
    }
}
