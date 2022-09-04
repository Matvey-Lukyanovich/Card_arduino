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
    public partial class add4 : Form
    {

        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=base_ber_pek;password=12345;");


        public add4()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
                    }

        private void Add_Click(object sender, EventArgs e)
        {

            connection.Open();
            string b;
            if (cb1.Checked)
            {
                b = "1";
            }
            else b = "0";

            string insert = "INSERT INTO sotrudnik (card,FIO,date_bd,Pasp,Adress,phone,med_sprawka,dogowor,home_phone,strah_numb) VALUES ('" + comboBox1.Text + "', '" + tb3.Text + "', '" + tb1.Text + "', '" + tb2.Text + "', '" + tb4.Text + "', '" + tb5.Text + "', '" + med.Text + "', '" + b + "', '" + homephone.Text + "', '" + strah.Text + "')";


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
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add4_Load(object sender, EventArgs e)
        {


            try
            {

                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select card_sotr.idcard_sotr as `` from card_sotr", connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "card_sotr");
                data1.DataSource = ds.Tables[0];
                connection.Close();
                bool x = true;

                data1.Sort(data1.Columns[0], x ? ListSortDirection.Ascending : ListSortDirection.Descending);






                for (int i = 0; i < data1.RowCount - 1; i++)
                {
                    comboBox1.Items.Add(data1.Rows[i].Cells[0].Value);
                }

                try
                {
                    comboBox1.Text = comboBox1.Items[0].ToString();

                }
                catch
                { }

            }
            catch
            {
                MessageBox.Show("Отсутствует соединение или база уже загружена!");
            }
        }
    }
}
