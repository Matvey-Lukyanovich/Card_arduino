using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Uczet_kadrow
{
    public partial class add2 : Form
    {

        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=base_ber_pek;password=12345;");


        public add2()
        {
            InitializeComponent();
        }

        private void Add2_Load(object sender, EventArgs e)
        {

        }

        private void Tb3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            connection.Open();
            string insert = "INSERT INTO otdel (name,naczal_name,phone) VALUES ('" + tb1.Text + "', '" + tb2.Text + "', '" + tb3.Text  + "')";


            MySqlCommand command = new MySqlCommand(insert, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Добавленно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connection.Close();

                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
