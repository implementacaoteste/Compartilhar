using BLL;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SAEP
{
    public partial class Form1 : Form
    {
        BindingSource alocacaoBindingSource;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PintarAreas();
        }
        private void PintarAreas()
        {
            buttonArea1.BackColor =
                        buttonArea2.BackColor =
                        buttonArea3.BackColor =
                        buttonArea4.BackColor =
                        buttonArea5.BackColor =
                        buttonArea6.BackColor =
                        buttonArea7.BackColor =
                        buttonArea8.BackColor =
                        buttonArea9.BackColor =
                        buttonArea10.BackColor =
                        buttonArea11.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            alocacaoBindingSource = new BindingSource();
            alocacaoBindingSource.DataSource = new AlocacaoBLL().BuscarTodos();

            foreach (var item in alocacaoBindingSource)
            {
                switch (((Alocacao)item).Area)
                {
                    case 1:
                        buttonArea1.BackColor = ColorTranslator.FromHtml("#0000FF");
                        break;
                    case 2:
                        buttonArea2.BackColor = ColorTranslator.FromHtml("#0000FF");
                        break;
                    case 3:
                        buttonArea3.BackColor = ColorTranslator.FromHtml("#0000FF");
                        break;
                    case 4:
                        buttonArea4.BackColor = ColorTranslator.FromHtml("#0000FF");
                        break;
                    case 5:
                        buttonArea5.BackColor = ColorTranslator.FromHtml("#0000FF");
                        break;
                    case 6:
                        buttonArea6.BackColor = ColorTranslator.FromHtml("#0000FF");
                        break;
                    case 7:
                        buttonArea7.BackColor = ColorTranslator.FromHtml("#0000FF");
                        break;
                    case 8:
                        buttonArea8.BackColor = ColorTranslator.FromHtml("#0000FF");
                        break;
                    case 9:
                        buttonArea9.BackColor = ColorTranslator.FromHtml("#0000FF");
                        break;
                    case 10:
                        buttonArea10.BackColor = ColorTranslator.FromHtml("#0000FF");
                        break;
                    case 11:
                        buttonArea11.BackColor = ColorTranslator.FromHtml("#0000FF");
                        break;
                    default:
                        break;
                }
            }
        }
        private void buttonArea1_Click(object sender, EventArgs e)
        {
            if (buttonArea1.BackColor.Name != "ff0000ff")
            {
                MessageBox.Show("Essa área está vazia");
                return;
            }
            VenderCarro(1);
        }
        private void VenderCarro(int _idArea)
        {
            alocacaoBindingSource.Filter = $"area = {_idArea}";
            using (FormVender frm = new FormVender(_idArea))
            {
                frm.ShowDialog();
            }
            PintarAreas();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[4];
            points[0] = new Point(100, 50);
            points[1] = new Point(this.Width - 50, 50);
            points[2] = new Point(this.Width - 50, this.Height - 50);
            points[3] = new Point(50, this.Height - 50);
            e.Graphics.FillPolygon(Brushes.Silver, points);

            e.Graphics.DrawPolygon(Pens.Silver, points);
        }
        private void buttonArea11_Click(object sender, EventArgs e)
        {
            if (buttonArea11.BackColor.Name != "ff0000ff")
            {
                MessageBox.Show("Essa área está vazia");
                return;
            }
            VenderCarro(11);
        }
        private void buttonArea6_Click(object sender, EventArgs e)
        {
            if (buttonArea6.BackColor.Name != "ff0000ff")
            {
                MessageBox.Show("Essa área está vazia");
                return;
            }
            VenderCarro(6);
        }
        private void buttonArea10_Click(object sender, EventArgs e)
        {
            if (buttonArea10.BackColor.Name != "ff0000ff")
            {
                MessageBox.Show("Essa área está vazia");
                return;
            }
            VenderCarro(10);
        }
    }
}
