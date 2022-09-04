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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader("userblock.txt"))
            {
                while (!r.EndOfStream)
                {
                    string line = r.ReadLine();
                    user.Text += line + "\r\n";
                }

            }
            savefile.Enabled = !true;
        }

        private void Savefile_Click(object sender, EventArgs e)
        {

            try
            {
                StreamWriter sw; // поток дя записи

                File.WriteAllText("userblock.txt", String.Empty);
                // Запись в файл: 
                FileInfo fi = new FileInfo("userblock.txt"); // информация о файле 
                if (fi.Exists)
                    sw = fi.AppendText(); // открыть поток для добавления
                else
                    sw = fi.CreateText(); // или поток для записи 


                for (int j = 0; j < user.Lines.Length; j++)
                    if (user.Lines[j] != "") sw.WriteLine(user.Lines[j]); // запись строк в файл

                // sw.WriteLine(s1.ToString());
                sw.Close();
                savefile.Enabled = false;
                MessageBox.Show("Сохраненно", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch { }
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            savefile.Enabled = true;
        }
    }
}
