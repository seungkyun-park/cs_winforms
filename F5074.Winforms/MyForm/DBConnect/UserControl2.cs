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
using F5074.MyBatisDataMapper.Service.School;

namespace F5074.Winforms.MyForm.DBConnect
{
    public partial class UserControl2 : UserControl
    {

        public UserControl2()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DashboardDTO tempDTO = new DashboardDTO();
            tempDTO.NAME = textBox1.Text;
            tempDTO.AGE = textBox2.Text;
            tempDTO.DEPT = textBox3.Text;
            DashboardDTO resultDTO = DashboardDAO.DeleteCompany(tempDTO);
            MessageBox.Show(resultDTO.isSuccess.ToString());

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            DashboardDTO tempDTO = new DashboardDTO();
            tempDTO.NAME = textBox1.Text;
            tempDTO.AGE = textBox2.Text;
            tempDTO.DEPT = textBox3.Text;
            DashboardDTO resultDTO = DashboardDAO.UpdateCompany(tempDTO);
            MessageBox.Show(resultDTO.isSuccess.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DashboardDTO tempDTO = new DashboardDTO();
            tempDTO.NAME = textBox1.Text;
            tempDTO.AGE = textBox2.Text;
            tempDTO.DEPT = textBox3.Text;
            DashboardDTO resultDTO = DashboardDAO.InsertCompany(tempDTO);
            MessageBox.Show(resultDTO.isSuccess.ToString());

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //1
            DashboardDTO tempDTO = new DashboardDTO();
            if(!String.IsNullOrWhiteSpace(textBox4.Text)) tempDTO.NAME = textBox4.Text;



            IList<DashboardDTO> resultList = DashboardDAO.SelectList(tempDTO);


            // 2
            //IList<DashboardDTO> resultList2 = DashboardDAO.SelectList(new DashboardDTO() { NAME = textBox4.Text });


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
