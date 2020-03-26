using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.MyBatisDataMapper.Service.School;

namespace F5074.Winforms.MyForm.DBConnect
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IList<SchoolDTO> resultList2 = SchoolDAO.SelectSchoolList(new SchoolDTO());

            dataGridView1.DataSource = resultList2;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IList<SchoolDTO> resultList = (IList<SchoolDTO>)dataGridView1.DataSource;

            //MessageBox.Show(resultList[0].NAME);
            textBox1.Text = resultList[e.RowIndex].NAME;
            textBox2.Text = resultList[e.RowIndex].LOCATION;
            textBox3.Text = resultList[e.RowIndex].GRADE;
        }
    }
}
