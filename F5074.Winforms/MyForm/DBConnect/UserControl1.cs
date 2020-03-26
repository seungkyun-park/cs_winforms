using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Winforms.MyForm.DBConnect
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            button1.KeyUp += Button1_KeyUp;
            maskedTextBox1.KeyUp += MaskedTextBox1_KeyUp;
        }

        private void MaskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals( Keys.Enter))
            {
                for (int x = 0; x < 2; x++)
                {
                    MessageBox.Show(x.ToString());
                }
            }

        }

        private void Button1_KeyUp(object sender, KeyEventArgs e)
        {
            for (int x = 0; x < 10; x++)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("click");
        }

    }
}
