using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsCovid19
{
    public partial class frm_covid : MetroFramework.Forms.MetroForm
    {
        public frm_covid()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("https://api.memleketyazilim.com/covid-19-turkey-master/dataset/timeline.xml");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
