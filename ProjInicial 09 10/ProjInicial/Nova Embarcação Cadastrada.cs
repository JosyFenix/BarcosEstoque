using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjInicial
{
    public partial class Nova_Embarcação_Cadastrada : Form
    {
        public Nova_Embarcação_Cadastrada()
        {
            InitializeComponent();
        }

        private void Nova_Embarcação_Cadastrada_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basetesteDataSet.barcos' table. You can move, or remove it, as needed.
            this.barcosTableAdapter.Fill(this.basetesteDataSet.barcos);

        }

        private void mostraBarcosToolStripButton_Click(object sender, EventArgs e)
        {
           /* try
            {
                this.barcosTableAdapter.MostraBarcos(this.basetesteDataSet.barcos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
