using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist
{
    public partial class RestMoney : Form
    {
        public RestMoney()
        {
            InitializeComponent();
        }

        private void RestMoney_Load(object sender, EventArgs e)
        {
            DentistEntities2 dentist = new DentistEntities2();
            
            var lstPatients = dentist.TbPatients.Where(a => a.TheRest > 0).ToList();
            dataGridView1.DataSource = lstPatients;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
