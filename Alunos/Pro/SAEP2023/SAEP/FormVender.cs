using BLL;
using Models;
using System.Windows.Forms;

namespace SAEP
{
    public partial class FormVender : Form
    {
        private readonly int idArea;

        public FormVender(int _idArea)
        {
            InitializeComponent();
            automoveisBindingSource.DataSource = new AutomoveisBLL().BuscarPorArea(_idArea);
            label1.Text = $"Area {_idArea}";
            idArea = _idArea;
        }
        private void automoveisDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == automoveisDataGridView.Columns["buttonVender"].Index && e.RowIndex >= 0)
            {
                int idAutomovel = ((Automoveis)automoveisBindingSource.Current).Id;
                string modelo = ((Automoveis)automoveisBindingSource.Current).Modelo;

                using (FormFazerVenda frm = new FormFazerVenda(idArea, idAutomovel, modelo))
                {
                    frm.ShowDialog();
                }
                automoveisBindingSource.DataSource = new AutomoveisBLL().BuscarPorArea(idArea);
            }
        }
    }
}
