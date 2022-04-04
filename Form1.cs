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
            string simpanKalimat = "";
            string hurufPertama = "";
            string hurufKedua = "";
            int indexArray = 0;
            int indexArray2 = 0;
            int count = 0;
            char[] alphabetArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            simpanKalimat = txtBoxInputKalimat.Text.ToUpper();
            hurufPertama = txtBoxHurufAwal.Text.ToUpper();
            hurufKedua = txtBoxHurufDiganti.Text.ToUpper();
            simpanKalimat.ToCharArray();
            hurufPertama.ToCharArray();
            hurufKedua.ToCharArray();
            for (int i = 0; i < alphabetArray.Length; i++)
            {
                if (hurufPertama == alphabetArray[i].ToString())
                    indexArray = i;
            }
            for (int j = 0; j < alphabetArray.Length; j++)
            {
                if (hurufKedua == alphabetArray[j].ToString())
                    indexArray2 = j;
            }
            if (indexArray < indexArray2)
                count = indexArray - indexArray2;
            else
                count = indexArray + indexArray2;
            
        }
    }
}
