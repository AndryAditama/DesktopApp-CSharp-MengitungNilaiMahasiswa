using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NilaiMahasiswa
{
    public partial class FormNilaiMahasiswa : Form
    {
        public FormNilaiMahasiswa()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void nilaiAbsen_KeyUp(object sender, KeyEventArgs e)
        {
            if (nilaiAbsen.Value.ToString() == "")
            {
                lbNilaiAbsen.Text = "0";
            }
            else
            {
                var HitungNilaiAbsen = (nilaiAbsen.Value * 10) / 100;
                int intNilaiAbsen = (int)HitungNilaiAbsen;
                lbNilaiAbsen.Text =intNilaiAbsen.ToString();
            }            
        }

        private void nilaiAbsen_ValueChanged(object sender, EventArgs e)
        {
            if (nilaiAbsen.Value.ToString() == "")
            {
                lbNilaiAbsen.Text = "0";
            }
            else
            {
                var HitungNilaiAbsen = (nilaiAbsen.Value * 10) / 100;
                int intNilaiAbsen = (int)HitungNilaiAbsen;
                lbNilaiAbsen.Text = intNilaiAbsen.ToString();
            }   
        }

        private void nilaiTugas_KeyUp(object sender, KeyEventArgs e)
        {
            if (nilaiTugas.Value.ToString() == "")
            {
                lbNilaiTugas.Text = "0";
            }
            else
            {
                var HitungNilaiTugas = (nilaiTugas.Value * 20) / 100;
                int intNilaiTugas = (int)HitungNilaiTugas;
                lbNilaiTugas.Text = intNilaiTugas.ToString();
            }   
        }

        private void nilaiTugas_ValueChanged(object sender, EventArgs e)
        {
            if (nilaiTugas.Value.ToString() == "")
            {
                lbNilaiTugas.Text = "0";
            }
            else
            {
                var HitungNilaiTugas = (nilaiTugas.Value * 20) / 100;
                int intNilaiTugas = (int)HitungNilaiTugas;
                lbNilaiTugas.Text = intNilaiTugas.ToString();
            }  
        }

        private void nilaiUTS_KeyUp(object sender, KeyEventArgs e)
        {
            if (nilaiUTS.Value.ToString() == "")
            {
                lbNilaiUTS.Text = "0";
            }
            else
            {
                var HitungNilaiUTS = (nilaiUTS.Value * 30) / 100;
                int intNilaiUTS = (int)HitungNilaiUTS;
                lbNilaiUTS.Text = intNilaiUTS.ToString();
            } 
        }

        private void nilaiUTS_ValueChanged(object sender, EventArgs e)
        {
            if (nilaiUTS.Value.ToString() == "")
            {
                lbNilaiUTS.Text = "0";
            }
            else
            {
                var HitungNilaiUTS = (nilaiUTS.Value * 30) / 100;
                int intNilaiUTS = (int)HitungNilaiUTS;
                lbNilaiUTS.Text = intNilaiUTS.ToString();
            } 
        }

        private void nilaiUAS_KeyUp(object sender, KeyEventArgs e)
        {
            if (nilaiUAS.Value.ToString() == "")
            {
                lbNilaiUAS.Text = "0";
            }
            else
            {
                var HitungNilaiUAS = (nilaiUAS.Value * 40) / 100;
                int intNilaiUAS = (int)HitungNilaiUAS;
                lbNilaiUAS.Text = intNilaiUAS.ToString();
            } 
        }

        private void nilaiUAS_ValueChanged(object sender, EventArgs e)
        {
            if (nilaiUAS.Value.ToString() == "")
            {
                lbNilaiUAS.Text = "0";
            }
            else
            {
                var HitungNilaiUAS = (nilaiUAS.Value * 40) / 100;
                int intNilaiUAS = (int)HitungNilaiUAS;
                lbNilaiUAS.Text = intNilaiUAS.ToString();
            } 
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
                    }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nilaiAbsen.Value.ToString() == "" || nilaiTugas.Value.ToString() == "" || nilaiUTS.Value.ToString() == "" || nilaiUAS.Value.ToString() == "")
            {
                MessageBox.Show("Data Belum Lengkap");
            }
            else {
                int jumlahHasilAkhir = int.Parse(lbNilaiAbsen.Text) + int.Parse(lbNilaiTugas.Text) + int.Parse(lbNilaiUTS.Text) + int.Parse(lbNilaiUAS.Text);
                NilaiAkhir.Text = jumlahHasilAkhir.ToString();

                if(int.Parse(NilaiAkhir.Text) > 85 && int.Parse(NilaiAkhir.Text) <= 100){
                    predikat.Text = "A";
                    predikat.BackColor = Color.LawnGreen;
                    keterangan.Text = "LULUS";
                }
                else if (int.Parse(NilaiAkhir.Text) >= 70 && int.Parse(NilaiAkhir.Text) <= 85)
                {
                    predikat.Text = "B";
                    predikat.BackColor = Color.LawnGreen;
                    keterangan.Text = "LULUS";
                }
                else if (int.Parse(NilaiAkhir.Text) >= 55 && int.Parse(NilaiAkhir.Text) < 70)
                {
                    predikat.Text = "C";
                    predikat.BackColor = Color.Yellow;
                    keterangan.Text = "LULUS";
                }
                else if (int.Parse(NilaiAkhir.Text) >= 45 && int.Parse(NilaiAkhir.Text) <55)
                {
                    predikat.Text = "D";
                    predikat.BackColor = Color.Red;
                    keterangan.Text = "TIDAK LULUS";
                }
                else if (int.Parse(NilaiAkhir.Text) <45)
                {
                    predikat.Text = "E";
                    predikat.BackColor = Color.Red;
                    keterangan.Text = "TIDAK LULUS";
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nilaiAbsen.Value = 0;
            lbNilaiAbsen.Text = "0";
            nilaiTugas.Value = 0;
            lbNilaiTugas.Text = "0";
            nilaiUTS.Value = 0;
            lbNilaiUTS.Text = "0";
            nilaiUAS.Value = 0;
            lbNilaiUAS.Text = "0";
            NilaiAkhir.Text = "0";
            predikat.Text = "0";
            keterangan.Text = "0";

        }
    }
}
