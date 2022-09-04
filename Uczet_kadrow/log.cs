using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Uczet_kadrow
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        private void Btn_log_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 & pass.Text == "admin")
            {
                main main = new main();
                main.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex == 0) MessageBox.Show("Неверный пароль");

            if (comboBox1.SelectedIndex != 0 )
            {
                bool b = true;
                using (StreamReader r = new StreamReader("userblock.txt"))
                {
                    while (!r.EndOfStream)
                    {
                        string line = r.ReadLine();
                       if ( comboBox1.Text == line) { b = false; }
                    }

                }
                if (!b)
                {
                    main2 main2 = new main2();
                    main2.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Отказано в доступе!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            }
        }

        private void Log_Load(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Items[0].ToString();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                pass.Text = "";
                comboBox1.Text = "";


            }
            else
            {
                pass.Text = "admin";
                comboBox1.Text = comboBox1.Items[0].ToString();

            }


        }


        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                pass.Text = "";
                comboBox1.Text = "";


            }
            else
            {
                pass.Text = "admin";
                comboBox1.Text = comboBox1.Items[0].ToString();

            }
        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                pass.Text = "";
                comboBox1.Text = "";


            }
            else
            {
                pass.Text = "admin";
                comboBox1.Text = comboBox1.Items[0].ToString();

            }
        }
    }
}
