using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.MyBatisDataMapper.Service.Dashboard;

namespace F5074.Winforms.MyForm.DBConnect
{
    public partial class UserControl2 : UserControl
    {

        public UserControl2()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IList<DashboardDTO> resultList = DashboardDAO.SelectList(new DashboardDTO());
            //MessageBox.Show(resultList[0].NAME);
            //textBox1.Text = resultList[0].NAME;
            //textBox2.Text = resultList[0].AGE;
            //textBox3.Text = resultList[0].DEPT;

            dataGridView1.DataSource = resultList;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IList<DashboardDTO> resultList = (IList<DashboardDTO>)dataGridView1.DataSource;

            //MessageBox.Show(resultList[0].NAME);
            textBox1.Text = resultList[e.RowIndex].NAME;
            textBox2.Text = resultList[e.RowIndex].AGE;
            textBox3.Text = resultList[e.RowIndex].DEPT;
        }
    }
}
