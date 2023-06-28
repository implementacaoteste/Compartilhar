using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace SAEP
{
    public partial class FormFazerVenda : Form
    {
        private readonly int idArea;
        private readonly int idAutomovel;

        public FormFazerVenda(int _idArea, int _idAutomovel, string _modelo)
        {
            InitializeComponent();
            label1.Text = _modelo;
            idArea = _idArea;
            idAutomovel = _idAutomovel;
        }
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            new VendaBLL().Vender(((Concessionarias)concessionariasBindingSource.Current).Alocacao, idAutomovel, (int)nomeComboBox.SelectedValue, (int)concessionariaComboBox.SelectedValue, idArea);
            this.Close();
        }
        private void FormFazerVenda_Load(object sender, EventArgs e)
        {
            clientesBindingSource.DataSource = new ClienteBLL().BuscarTodos();
            concessionariasBindingSource.DataSource = new ConcessionariasBLL().BuscarPorCarroEArea(idAutomovel, idArea);
        }
    }
}
