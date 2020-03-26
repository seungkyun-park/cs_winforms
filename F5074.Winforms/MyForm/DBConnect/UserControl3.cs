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
            button4.Click += Button4_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
        }


        //추가
        private void Button4_Click(object sender, EventArgs e)
        {
            SchoolDTO tempDTO = new SchoolDTO();
            tempDTO.NAME = textBox1.Text;
            tempDTO.LOCATION = textBox2.Text;
            tempDTO.GRADE = textBox3.Text;
            SchoolDTO resultDTO = SchoolDAO.InsertSchool(tempDTO);
            MessageBox.Show(resultDTO.isSuccess.ToString());
            Refresh();
            Console.WriteLine("Remote Commit Test");
        }

        //삭제
        private void Button3_Click(object sender, EventArgs e)
        {
            SchoolDTO tempDTO = new SchoolDTO();
            tempDTO.NAME = textBox1.Text;
            tempDTO.LOCATION = textBox2.Text;
            tempDTO.GRADE = textBox3.Text;
            SchoolDTO resultDTO = SchoolDAO.DeleteSchool(tempDTO);
            MessageBox.Show(resultDTO.isSuccess.ToString());
            Refresh();
        }

        //수정
        private void Button2_Click(object sender, EventArgs e)
        {
            SchoolDTO tempDTO = new SchoolDTO();
            tempDTO.NAME = textBox1.Text;
            tempDTO.LOCATION = textBox2.Text;
            tempDTO.GRADE = textBox3.Text;
            SchoolDTO resultDTO = SchoolDAO.UpdateSchool(tempDTO);
            MessageBox.Show(resultDTO.isSuccess.ToString());
            Refresh();
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
