using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_AutomotivoS_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            double Valor = 0;
            double Hora;
            double Roda;

             Hora = double.Parse(ND_horas.Text);
             Roda = double.Parse(ND_rodas.Text);



            #region Nacional

            if (RB_nacional.Checked && CB_alinhamento.Checked && CB_balanceamento.Checked && CB_camber.Checked && CB_cáster.Checked)
            {
                Valor = (Hora * 60) + 25 + (Roda * 12) + 30 + 20;
            }
            else if (RB_nacional.Checked && CB_alinhamento.Checked && CB_balanceamento.Checked && CB_camber.Checked)
            {
                Valor = (Hora * 60) + 25 + (Roda * 12) + 30;
            }
            else if (RB_nacional.Checked && CB_alinhamento.Checked && CB_balanceamento.Checked && CB_cáster.Checked)
            {
                Valor = (Hora * 60) + 25 + (Roda * 12)  + 20;
            }
            else if (RB_nacional.Checked && CB_alinhamento.Checked && CB_balanceamento.Checked)
            {
                Valor = (Hora * 60) + 25 + (Roda * 12);
            }
            else if (RB_nacional.Checked && CB_alinhamento.Checked && CB_cáster.Checked)
            {
                Valor = (Hora * 60) + 25 + 20;
            }
            else if (RB_nacional.Checked && CB_alinhamento.Checked && CB_camber.Checked)
            {
                Valor = (Hora * 60) + 25 + 30;
            }
            else if (RB_nacional.Checked && CB_alinhamento.Checked )
            {
                Valor = (Hora * 60) + 25;
            }
            else if (RB_nacional.Checked && CB_cáster.Checked)
            {
                Valor = (Hora * 60) + 20;
            }
            else if (RB_nacional.Checked && CB_camber.Checked)
            {
                Valor = (Hora * 60) + 30;
            }
            else if (RB_nacional.Checked && CB_balanceamento.Checked)
            {
                Valor = (Hora * 60) + 30;
            }
            else if (RB_nacional.Checked && CB_cáster.Checked && CB_camber.Checked)
            {
                Valor = (Hora * 60) + 20 + 30;
            }
            #endregion



            #region Importado

            if (RB_importado.Checked && CB_alinhamento.Checked && CB_balanceamento.Checked && CB_camber.Checked && CB_cáster.Checked)
            {
                Valor = (Hora * 85) + 25 + (Roda * 12) + 30 + 20;
            }
            else if (RB_importado.Checked && CB_alinhamento.Checked && CB_balanceamento.Checked && CB_camber.Checked)
            {
                Valor = (Hora * 85) + 25 + (Roda * 12) + 30;
            }
            else if (RB_importado.Checked && CB_alinhamento.Checked && CB_balanceamento.Checked && CB_cáster.Checked)
            {
                Valor = (Hora * 85) + 25 + (Roda * 12) + 20;
            }
            else if (RB_importado.Checked && CB_alinhamento.Checked && CB_balanceamento.Checked)
            {
                Valor = (Hora * 85) + 25 + (Roda * 12);
            }
            else if (RB_importado.Checked && CB_alinhamento.Checked && CB_cáster.Checked)
            {
                Valor = (Hora * 85) + 25 + 20;
            }
            else if (RB_importado.Checked && CB_alinhamento.Checked && CB_camber.Checked)
            {
                Valor = (Hora * 85) + 25 + 30;
            }
            else if (RB_importado.Checked && CB_alinhamento.Checked)
            {
                Valor = (Hora * 85) + 25;
            }
            else if (RB_importado.Checked && CB_cáster.Checked)
            {
                Valor = (Hora * 85) + 20;
            }
            else if (RB_importado.Checked && CB_camber.Checked)
            {
                Valor = (Hora * 85) + 30;
            }
            else if (RB_importado.Checked && CB_balanceamento.Checked)
            {
                Valor = (Hora * 85) + 30;
            }
            else if (RB_importado.Checked && CB_cáster.Checked && CB_camber.Checked)
            {
                Valor = (Hora * 85) + 20 + 30;
            }
            #endregion


            txtvalor.Text = Valor.ToString();




        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           txtvalor.Clear();

            CB_alinhamento.Checked = false;

            CB_balanceamento.Checked = false;

            CB_camber.Checked = false;

            CB_cáster.Checked = false;

            RB_nacional.Checked = false;

            RB_importado.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
