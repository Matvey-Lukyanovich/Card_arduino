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
    public partial class add3 : Form
    {


        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=base_ber_pek;password=12345;");


        public add3()
        {
            InitializeComponent();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add3_Load(object sender, EventArgs e)
        {
            


            try
            {
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select otdel.idotdel as `` from otdel", connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "otdel");
                data2.DataSource = ds.Tables[0];
                connection.Close();
                bool x = true;

                data2.Sort(data2.Columns[0], x ? ListSortDirection.Ascending : ListSortDirection.Descending);

                for (int i = 0; i < data2.RowCount - 1; i++)
                {
                    comboBox2.Items.Add(data2.Rows[i].Cells[0].Value);
                }

                try
                {
                    comboBox2.Text = comboBox2.Items[0].ToString();

                }
                catch
                { }
            }
            catch
            { }


        }

        private void Add_Click(object sender, EventArgs e)
        {
            connection.Open();
            string insert = "INSERT INTO raspisanie (otdel,dolg,kol_sh_ed,work_h,oklad) VALUES ('" + comboBox2.Text + "', '" + tb1.Text + "', '" + tbkol.Text + "', '" + tb2.Text + "', '" + tb3.Text + "')";


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
    }
}
