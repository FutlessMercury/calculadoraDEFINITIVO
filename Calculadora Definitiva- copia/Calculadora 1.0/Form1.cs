using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.calitha.goldparser;
using GemBox.Document.Drawing;

namespace Calculadora_1._0
{
    public partial class Form1 : Form
    {
        MyParser parser;
        public Form1()
        {
            parser = new MyParser(Application.StartupPath + "\\Calculadora.cgt");
            InitializeComponent();
        }

        private void boton1_Click (object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "2";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + ")";
        }

        private void textopantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton0_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "0";
            this.boton0.BackColor = ColorTranslator.FromHtml("#ffc1d3");
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "3";
            this.boton0.BackColor = ColorTranslator.FromHtml("#ffc1d3");
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "4";
            
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "9";
        }

        private void botonPunto_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + ",";
        }

        private void botonMAS_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "+";
        }

        private void botonMENOS_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "-";
        }

        private void botonDIV_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "/";
        }

        private void botonParentesis1_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "(";
        }

        private void botonIGUAL_Click(object sender, EventArgs e)
        {
            parser.Parse(textopantalla.Text);
            CajaResultado.Text = parser.resultado;
        }

        private void botonMUL_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "*";
        }

        private void CajaResultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void botonRESET_Click(object sender, EventArgs e)
        {
            textopantalla.Clear();
            CajaResultado.Clear();
        }

        private void BotonBORRAR_Click(object sender, EventArgs e)
        {
            if (textopantalla.Text.Length == 1)
                textopantalla.Text = "";

            else
                textopantalla.Text = textopantalla.Text.Substring(0, textopantalla.Text.Length - 1);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boton0_MouseEnter(object sender, EventArgs e)
        {
            boton0.BackColor = ColorTranslator.FromHtml("#FFB9D0");
        }

        private void boton0_MouseLeave(object sender, EventArgs e)
        {
            boton0.BackColor = ColorTranslator.FromHtml("#ff0080");
        }

        private void boton1_MouseEnter(object sender, EventArgs e)
        {
            boton1.BackColor = ColorTranslator.FromHtml("#FFB9D0");
        }

        private void boton1_MouseLeave(object sender, EventArgs e)
        {
            boton1.BackColor = ColorTranslator.FromHtml("#ff0080");
        }

        private void boton2_MouseEnter(object sender, EventArgs e)
        {
            boton2.BackColor = ColorTranslator.FromHtml("#FFB9D0");
        }

        private void boton2_MouseLeave(object sender, EventArgs e)
        {
            boton2.BackColor = ColorTranslator.FromHtml("#ff0080");
        }

        private void boton3_MouseEnter(object sender, EventArgs e)
        {
            boton3.BackColor = ColorTranslator.FromHtml("#FFB9D0");
        }

        private void boton3_MouseLeave(object sender, EventArgs e)
        {
            boton3.BackColor = ColorTranslator.FromHtml("#ff0080");
        }

        private void boton4_MouseEnter(object sender, EventArgs e)
        {
            boton4.BackColor = ColorTranslator.FromHtml("#FFB9D0");
        }

        private void boton4_MouseLeave(object sender, EventArgs e)
        {
            boton4.BackColor = ColorTranslator.FromHtml("#ff0080");
        }

        private void boton5_MouseEnter(object sender, EventArgs e)
        {
            boton5.BackColor = ColorTranslator.FromHtml("#FFB9D0");
        }

        private void boton5_MouseLeave(object sender, EventArgs e)
        {
            boton5.BackColor = ColorTranslator.FromHtml("#ff0080");
        }

        private void boton6_MouseEnter(object sender, EventArgs e)
        {
            boton6.BackColor = ColorTranslator.FromHtml("#FFB9D0");
        }

        private void boton6_MouseLeave(object sender, EventArgs e)
        {
            boton6.BackColor = ColorTranslator.FromHtml("#ff0080");
        }

        private void boton7_MouseLeave(object sender, EventArgs e)
        {
            boton7.BackColor = ColorTranslator.FromHtml("#ff0080");
        }

        private void boton7_MouseEnter(object sender, EventArgs e)
        {
            boton7.BackColor = ColorTranslator.FromHtml("#FFB9D0");
        }

        private void boton8_MouseLeave(object sender, EventArgs e)
        {
            boton8.BackColor = ColorTranslator.FromHtml("#ff0080");
        }

        private void boton8_MouseEnter(object sender, EventArgs e)
        {
            boton8.BackColor = ColorTranslator.FromHtml("#FFB9D0");
        }

        private void boton9_MouseEnter(object sender, EventArgs e)
        {
            boton9.BackColor = ColorTranslator.FromHtml("#FFB9D0");
        }

        private void boton9_MouseLeave(object sender, EventArgs e)
        {
            boton9.BackColor = ColorTranslator.FromHtml("#ff0080");
        }

        private void botonRESET_MouseEnter(object sender, EventArgs e)
        {
            botonRESET.BackColor = ColorTranslator.FromHtml("#c5aaff");
        }

        private void botonRESET_MouseLeave(object sender, EventArgs e)
        {
            botonRESET.BackColor = ColorTranslator.FromHtml("#7D00FF");
        }

        private void botonPunto_MouseEnter(object sender, EventArgs e)
        {
            botonPunto.BackColor = ColorTranslator.FromHtml("#c5aaff");
        }

        private void botonPunto_MouseLeave(object sender, EventArgs e)
        {
            botonPunto.BackColor = ColorTranslator.FromHtml("#7D00FF");
        }

        private void BotonBORRAR_MouseEnter(object sender, EventArgs e)
        {
            BotonBORRAR.BackColor = ColorTranslator.FromHtml("#c5aaff");
        }

        private void BotonBORRAR_MouseLeave(object sender, EventArgs e)
        {
            BotonBORRAR.BackColor = ColorTranslator.FromHtml("#7D00FF");
        }

        private void botonIGUAL_MouseLeave(object sender, EventArgs e)
        {
            botonIGUAL.BackColor = ColorTranslator.FromHtml("#7D00FF");
        }

        private void botonIGUAL_MouseEnter(object sender, EventArgs e)
        {
            botonIGUAL.BackColor = ColorTranslator.FromHtml("#c5aaff");
        }

        private void botonMAS_MouseEnter(object sender, EventArgs e)
        {
            botonMAS.BackColor = ColorTranslator.FromHtml("#d9ffb7");
        }

        private void botonMAS_MouseLeave(object sender, EventArgs e)
        {
            botonMAS.BackColor = ColorTranslator.FromHtml("#82ff11");
        }

        private void botonMENOS_MouseEnter(object sender, EventArgs e)
        {
            botonMENOS.BackColor = ColorTranslator.FromHtml("#d9ffb7");
        }

        private void botonMENOS_MouseLeave(object sender, EventArgs e)
        {
            botonMENOS.BackColor = ColorTranslator.FromHtml("#82ff11");
        }

        private void botonMUL_MouseLeave(object sender, EventArgs e)
        {
            botonMUL.BackColor = ColorTranslator.FromHtml("#82ff11");
        }

        private void botonMUL_MouseEnter(object sender, EventArgs e)
        {
            botonMUL.BackColor = ColorTranslator.FromHtml("#d9ffb7");
        }

        private void botonDIV_MouseEnter(object sender, EventArgs e)
        {
            botonDIV.BackColor = ColorTranslator.FromHtml("#d9ffb7");
        }

        private void botonDIV_MouseLeave(object sender, EventArgs e)
        {
            botonDIV.BackColor = ColorTranslator.FromHtml("#82ff11");
        }

        private void botonParentesis1_MouseLeave(object sender, EventArgs e)
        {
            botonParentesis1.BackColor = ColorTranslator.FromHtml("#82ff11");
        }

        private void botonParentesis1_MouseEnter(object sender, EventArgs e)
        {
            botonParentesis1.BackColor = ColorTranslator.FromHtml("#d9ffb7");
        }

        private void botonParentesis2_MouseEnter(object sender, EventArgs e)
        {
            botonParentesis2.BackColor = ColorTranslator.FromHtml("#d9ffb7");
        }

        private void botonParentesis2_MouseLeave(object sender, EventArgs e)
        {
            botonParentesis2.BackColor = ColorTranslator.FromHtml("#82ff11");
        }

        private void elevado_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "^";
        }

        private void seno_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "sin(";
        }

        private void log_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "In(";
        }

        private void log_MouseEnter(object sender, EventArgs e)
        {
            log.BackColor = ColorTranslator.FromHtml("#d9ffb7");
        }

        private void log_MouseLeave(object sender, EventArgs e)
        {
            log.BackColor = ColorTranslator.FromHtml("#82ff11");
        }

        private void seno_MouseEnter(object sender, EventArgs e)
        {
            seno.BackColor = ColorTranslator.FromHtml("#d9ffb7");
        }

        private void seno_MouseLeave(object sender, EventArgs e)
        {
            seno.BackColor = ColorTranslator.FromHtml("#82ff11");
        }

        private void elevado_MouseEnter(object sender, EventArgs e)
        {
            elevado.BackColor = ColorTranslator.FromHtml("#d9ffb7");
        }

        private void elevado_MouseLeave(object sender, EventArgs e)
        {
            elevado.BackColor = ColorTranslator.FromHtml("#82ff11");
        }
    }

 }

