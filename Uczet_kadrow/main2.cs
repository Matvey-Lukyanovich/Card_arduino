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
using System.Collections;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Drawing.Printing;

namespace Uczet_kadrow
{
    public partial class main2 : Form
    {
        int numbername = 0;
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;


        int k;
        int ind = 1;

        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=base_ber_pek;password=12345;");

    
        public main2()
        {
            InitializeComponent();
        }

        private void Main2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            cbyear.Text = cbyear.Items[0].ToString();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (k == 0)
                if (DialogResult.Yes == MessageBox.Show("Вы действительно хотите выйти ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    k++;
                    Application.Exit();

                }
                else
                {
                    e.Cancel = true;
                }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (k == 0)
                if (DialogResult.Yes == MessageBox.Show("Вы действительно хотите выйти ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    k++;
                    Application.Exit();

                }
                else
                {
                }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void load(int a)
        {

            string nametable;
            if (a == 1)
            {


                nametable = "card_sotr";
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select " + nametable + ".idcard_sotr as ``,  " + nametable + ".dolg as ``, " + nametable + ".kodotdel as ``," + nametable + ".start_work as ``," + nametable + ".end_work as `` from " + nametable + "", connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, nametable);
                data.DataSource = ds.Tables[0];
                connection.Close();

                data.Columns[0].HeaderText = "Код карты";
                data.Columns[1].HeaderText = "Должность";
                data.Columns[2].HeaderText = "Код отдела";
                data.Columns[3].HeaderText = "Начало смены";
                data.Columns[4].HeaderText = "Конец смены";

                data.Columns[1].CellTemplate.ValueType = typeof(string);


                data.Columns[0].ReadOnly = true;
                data.Columns[1].ReadOnly = true;
                data.Columns[2].ReadOnly = true;
                data.Columns[3].ReadOnly = true;
                data.Columns[4].ReadOnly = true;



            }

            if (a == 2)
            {
                nametable = "otdel";
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select " + nametable + ".idotdel as ``,  " + nametable + ".name as ``, " + nametable + ".naczal_name as ``," + nametable + ".phone as `` from " + nametable + "", connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, nametable);
                data.DataSource = ds.Tables[0];
                connection.Close();

                data.Columns[0].HeaderText = "Код отдела";
                data.Columns[1].HeaderText = "Наименование";
                data.Columns[2].HeaderText = "Начальник";
                data.Columns[3].HeaderText = "Телефон";

                data.Columns[0].ReadOnly = true;
                data.Columns[1].ReadOnly = true;
                data.Columns[2].ReadOnly = true;
                data.Columns[3].ReadOnly = true;
            }

            if (a == 3)
            {
                nametable = "raspisanie";
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select " + nametable + ".idraspisanie as ``,  " + nametable + ".otdel as ``, " + nametable + ".dolg as ``, " + nametable + ".kol_sh_ed as ``," + nametable + ".work_h as ``," + nametable + ".oklad as `` from " + nametable + "", connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, nametable);
                data.DataSource = ds.Tables[0];
                connection.Close();

                data.Columns[0].HeaderText = "Код расписания";
                data.Columns[1].HeaderText = "Код отедел";
                data.Columns[2].HeaderText = "Должность";
                data.Columns[3].HeaderText = "Задаействовано штатных едениц";
                data.Columns[4].HeaderText = "Количество рабочих часов";
                data.Columns[5].HeaderText = "Оклад, р";



                data.Columns[0].ReadOnly = true;
                data.Columns[1].ReadOnly = true;
                data.Columns[2].ReadOnly = true;
                data.Columns[3].ReadOnly = true;
                data.Columns[4].ReadOnly = true;
                data.Columns[5].ReadOnly = true;



                connection.Open();
                for (int i = 0; i < data.RowCount - 1; i++)
                {

                    string sql = "SELECT COUNT(*) FROM `card_sotr` WHERE `dolg`='" + data.Rows[i].Cells[0].Value.ToString() + "'";
                    MySqlCommand comand = new MySqlCommand(sql, connection);

                    data.Rows[i].Cells[3].Value = comand.ExecuteScalar().ToString();
                }
                connection.Close();

            }
            if (a == 4)
            {
                nametable = "sotrudnik";
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select " + nametable + ".idsotrudnik as ``,  " + nametable + ".card as ``, " + nametable + ".FIO as ``, " + nametable + ".date_bd as ``, " + nametable + ".Pasp as ``," + nametable + ".Adress as ``," + nametable + ".phone as ``," + nametable + ".Child as ``," + nametable + ".med_sprawka as ``," + nametable + ".dogowor as ``," + nametable + ".home_phone as ``," + nametable + ".strah_numb as `` from " + nametable + "", connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, nametable);
                data.DataSource = ds.Tables[0];
                connection.Close();

                data.Columns[0].HeaderText = "Код сотрудника";
                data.Columns[1].HeaderText = "Карта №";
                data.Columns[2].HeaderText = "ФИО";
                data.Columns[3].HeaderText = "Дата рождения";
                data.Columns[4].HeaderText = "Паспорт";
                data.Columns[5].HeaderText = "Адресс";
                data.Columns[6].HeaderText = "Телефон";
                data.Columns[7].HeaderText = "Количество детей";
                data.Columns[8].HeaderText = "Мед. справка №";
                data.Columns[9].HeaderText = "Договор подряда";
                data.Columns[10].HeaderText = "Домашний телефон";
                data.Columns[11].HeaderText = "Страховка №";


                data.Columns[0].Width = 120;
                data.Columns[1].Width = 120;

                data.Columns[0].ReadOnly = true;
                data.Columns[1].ReadOnly = true;
                data.Columns[2].ReadOnly = true;
                data.Columns[3].ReadOnly = true;
                data.Columns[4].ReadOnly = true;
                data.Columns[5].ReadOnly = true;
                data.Columns[6].ReadOnly = true;
                data.Columns[7].ReadOnly = true;
                data.Columns[8].ReadOnly = true;
                data.Columns[9].ReadOnly = true;
                data.Columns[10].ReadOnly = true;
                data.Columns[11].ReadOnly = true;


                connection.Open();
                for (int i = 0; i < data.RowCount - 1; i++)
                {

                    string sql = "SELECT COUNT(*) FROM `child` WHERE `daddy`='" + data.Rows[i].Cells[0].Value.ToString() + "'";
                    MySqlCommand comand = new MySqlCommand(sql, connection);

                    data.Rows[i].Cells[7].Value = comand.ExecuteScalar().ToString();
                }
                connection.Close();

            }
            if (a == 5)
            {
                nametable = "child";
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select " + nametable + ".idchild as ``, " + nametable + ".Famil as ``, " + nametable + ".Ima as ``, " + nametable + ".Otchest as ``," + nametable + ".date_bd as ``," + nametable + ".daddy as `` from " + nametable + "", connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, nametable);
                data.DataSource = ds.Tables[0];
                connection.Close();

                data.Columns[0].HeaderText = "Код ребенка";
                data.Columns[1].HeaderText = "Фамилия";
                data.Columns[2].HeaderText = "Имя";
                data.Columns[3].HeaderText = "Отчество";
                ///
                data.Columns[4].HeaderText = "Дата рождения";
                data.Columns[5].HeaderText = "Родитель";


                data.Columns[0].ReadOnly = true;
                data.Columns[1].ReadOnly = true;
                data.Columns[2].ReadOnly = true;
                data.Columns[3].ReadOnly = true;
                data.Columns[4].ReadOnly = true;
                data.Columns[5].ReadOnly = true;




            }


        }



        private void КартаСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ind = 1;
            load(ind);


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
            // printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void PrintPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void PrintDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /* try
          {*/
            // Graphics g = e.Graphics;
            //  e.Graphics.DrawImage(Image.FromFile("png.png"), 96, 240);
            //  e.Graphics.DrawImage(Image.FromFile("podpis.png"), 96, 980);
            //String act = "Акт сдачи-приемки вполненных работ по техническому обслуживанию и ремонту автотрансорта";
            //  g.DrawString(act, messageFont, Brushes.Black, 20, 20);
            //  e.Graphics.DrawImage(Image.FromFile("model.png"), 96, 270);
            //Set the left margin
            int iLeftMargin = e.MarginBounds.Left;
            //Set the top margin
            int iTopMargin = e.MarginBounds.Top;
            //Whether more pages have to print or not
            bool bMorePagesToPrint = false;
            int iTmpWidth = 0;

            //For the first page to print set the cell width and header height
            /////
            if (bFirstPage)
            {
                foreach (DataGridViewColumn GridCol in data.Columns)
                {
                    iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                   (double)iTotalWidth * (double)iTotalWidth *
                                   ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                    iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                GridCol.InheritedStyle.Font, iTmpWidth).Height) + 13;

                    // Save width and height of headres
                    arrColumnLefts.Add(iLeftMargin);
                    arrColumnWidths.Add(iTmpWidth);
                    iLeftMargin += iTmpWidth;
                }
            }
            //Loop till all the grid rows not get printed
            while (iRow <= data.Rows.Count - 2)  /////!!!!!!!!!!!!!!!!!!!!111
            {
                DataGridViewRow GridRow = data.Rows[iRow];
                //Set the cell height
                iCellHeight = GridRow.Height + 5;
                int iCount = 0;
                //Check whether the current page settings allo more rows to print
                if (iTopMargin + iCellHeight >= 850 + e.MarginBounds.Top)
                {
                    bNewPage = true;
                    bFirstPage = false;
                    bMorePagesToPrint = true;
                    break;
                }
                else
                {
                    if (bNewPage)
                    {


                        // e.MarginBounds.Left
                        /* e.Graphics.DrawString(this.Text, new Font(data.Font, FontStyle.Underline),
                         Brushes.Black, 500, 945 -
                          e.Graphics.MeasureString(Convert.ToString(this.Text), new Font(data.Font,
                          FontStyle.Underline), e.MarginBounds.Width).Height + 5);
                          */

                        // String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();


                        //Draw Columns                 
                        iTopMargin = 320;
                        foreach (DataGridViewColumn GridCol in data.Columns)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight));

                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight));

                            e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                            iCount++;
                        }

                        bNewPage = false;
                        iTopMargin += iHeaderHeight;
                    }
                    iCount = 0;
                    //Draw Columns Contents                
                    foreach (DataGridViewCell Cel in GridRow.Cells)
                    {
                        if (Cel.Value != null)
                        {
                            e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                        new SolidBrush(Cel.InheritedStyle.ForeColor),
                                        new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                        (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                        }
                        //Drawing Cells Borders 
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                        iCount++;
                    }
                }
                iRow++;
                iTopMargin += iCellHeight;
            }

            //If more lines exist, print another page.
            if (bMorePagesToPrint)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;


            /*
        }
        catch (Exception exc)
        {
            MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        */

            Graphics g = e.Graphics;
            /*  String nazvv = this.Text;
              String fioo = this.Text;
              String auto = "АВТОМОБИЛЬ" + "\n\r" + "\n\r" + this.Text;
              String org = "ЗАКАЗЧИК:" + "\n\r" + "\n\r" + this.Text;
              String progarage = "ИСПОЛНИТЕЛЬ:" + "\n\r" + "\n\r" + "ЧПУП «ПроГараж»" + "\n\r" + "Республика беларусь" + "\n\r" + "225406, Брестская область, г. Барановичи" + "\n\r" + "ул. Чернышевского 188" + "\n\r" + "УНП: 291642984" + "\n\r" + "р/с BY46PJCB30125133501000000933" + "\n\r" + "ОАО «Приорбанк» ЦБУ 505" + "\n\r" + "г. Барановичи, ул. Ленина, 71" + "\n\r" + "БИК PJCBBY2X" + "\n\r" + "email: progarrrage@gmail.com" + "\n\r" + "тел. +375336980187" + "\n\r" + "сайт: progarage.by";


              Font messageFont = new Font("Times New Roman", 9, System.Drawing.GraphicsUnit.Point);
              Font messageFont1 = new Font("Times New Roman", 16, FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

              String act = "Акт сдачи-приемки выполненных работ по техническому " + "\n\r" + "              обслуживанию и ремонту автотранспорта";
              String work = "Работы выполнены в полном обьеме, в установленные сроки с надлежащим качеством. Стороны" + "\n\r" + "притензий друг к другу не имеют.";
              String pisp = "ИСПОЛНИТЕЛЬ:" + "\n\r" + "\n\r" + "Директор" + "\n\r" + "Пономаренко А.Н.";
              String pzak = "ЗАКАЗЧИК:" + "\n\r" + "\n\r" + nazvv + "\n\r" + fioo;
              g.DrawString(pisp, messageFont, Brushes.Black, 105, 1030);
              g.DrawString(pzak, messageFont, Brushes.Black, 420, 1030);
              g.DrawString(work, messageFont, Brushes.Black, 105, 990);
              g.DrawString(act, messageFont1, Brushes.Black, 125, 245);
              g.DrawString(progarage, messageFont, Brushes.Black, 96, 20);
              g.DrawString(org, messageFont, Brushes.Black, 340, 20);
              g.DrawString(auto, messageFont, Brushes.Black, 620, 20);
              /* Bitmap bmp = new Bitmap(datazakaz.Size.Width, datazakaz.Size.Height);
               datazakaz.DrawToBitmap(bmp, datazakaz.Bounds);
               e.Graphics.DrawImage(bmp, 0, 0);*/

        }

        private void PrintDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in data.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            load(ind);
        }

        private void Poisk_Click(object sender, EventArgs e)
        {
            if (found.Visible == true)
            {

                found.Visible = false;
                poisk.BackColor = Color.FromArgb(224, 224, 224);
                year.Visible = false;
                cbyear.Visible = false;
                button3.Visible = false;
            }
            else
            {
                found.Visible = true;
                poisk.BackColor = Color.FromArgb(20, 184, 20);
                if (ind == 5)
                {
                    year.Visible = true;
                    cbyear.Visible = true;
                    button3.Visible = true;
                }
            }
        }

        private void ОтделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ind = 2;
            load(ind);
        }

        private void ШтатноеРасписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ind = 3;
            load(ind);
        }

        private void СотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ind = 4;
            load(ind);
        }

        private void ДетиСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ind = 5;
            load(ind);
        }

        private void Delete1_Click(object sender, EventArgs e)
        {

            /*

            try
            {
                connection.Open();
                string name_table = "client";

                string a1 = database.CurrentRow.Cells[0].Value.ToString();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM " + name_table + " WHERE id" + name_table + " = " + "'" + a1 + "'";
                cmd.ExecuteNonQuery();


                database.Rows.RemoveAt(database.CurrentRow.Index);
                database.Refresh();
                MessageBox.Show("Удалено");
            }
            catch { }
            connection.Close();*/
        }

        private void Found_KeyUp(object sender, KeyEventArgs e)
        {
            load(ind);
            string s1;
            string s2 = found.Text;

            for (int i = data.RowCount - 2; i >= 0; i--)
            {
                bool rezult = false;
                for (int j = 0; j < data.ColumnCount; j++)
                {
                    s1 = data.Rows[i].Cells[j].Value.ToString();
                    bool b = s1.Contains(s2);
                    if (b) rezult = true;
                }

                if (!rezult)
                {
                    data.Rows.RemoveAt(i);
                    data.Refresh();
                }
            }
        }

        private void Found_KeyUp_1(object sender, KeyEventArgs e)
        {

        }

        private void Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                string rez;
                string sql;
                MySqlCommand comand;

                if (ind == 1)
                {
                    if (data.SelectedCells[0].ColumnIndex == 1)
                    {
                        connection.Open();
                        sql = "SELECT dolg FROM `raspisanie` WHERE `idraspisanie`='" + data.SelectedCells[0].Value.ToString() + "'";
                        comand = new MySqlCommand(sql, connection);
                        rez = comand.ExecuteScalar().ToString();
                        MessageBox.Show(data.Columns[data.SelectedCells[0].ColumnIndex].HeaderText + ": " + rez, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }

                    if (data.SelectedCells[0].ColumnIndex == 2)
                    {
                        connection.Open();
                        sql = "SELECT name FROM `otdel` WHERE `idotdel`='" + data.SelectedCells[0].Value.ToString() + "'";
                        comand = new MySqlCommand(sql, connection);
                        rez = comand.ExecuteScalar().ToString();
                        MessageBox.Show("Название отдела : " + rez, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }

                }


                if (ind == 3)
                {


                    if (data.SelectedCells[0].ColumnIndex == 1)
                    {
                        connection.Open();
                        sql = "SELECT name FROM `otdel` WHERE `idotdel`='" + data.SelectedCells[0].Value.ToString() + "'";
                        comand = new MySqlCommand(sql, connection);
                        rez = comand.ExecuteScalar().ToString();
                        MessageBox.Show("Название отдела : " + rez, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }

                }
                if (ind == 4)
                {
                    if (data.SelectedCells[0].ColumnIndex == 1)
                    {
                        string s = "Карта № " + data.SelectedCells[0].Value.ToString() + "\r\n";


                        connection.Open();

                        sql = "SELECT dolg FROM `card_sotr` WHERE `idcard_sotr`='" + data.SelectedCells[0].Value.ToString() + "'";
                        comand = new MySqlCommand(sql, connection);

                        rez = comand.ExecuteScalar().ToString();

                        sql = "SELECT dolg FROM `raspisanie` WHERE `idraspisanie`='" + rez + "'";
                        comand = new MySqlCommand(sql, connection);
                        rez = comand.ExecuteScalar().ToString();

                        s += "Должность : " + rez + "\r\n";

                        ////

                        sql = "SELECT kodotdel FROM `card_sotr` WHERE `idcard_sotr`='" + data.SelectedCells[0].Value.ToString() + "'";
                        comand = new MySqlCommand(sql, connection);

                        rez = comand.ExecuteScalar().ToString();

                        sql = "SELECT name FROM `otdel` WHERE `idotdel`='" + rez + "'";
                        comand = new MySqlCommand(sql, connection);
                        rez = comand.ExecuteScalar().ToString();

                        s += "Отдел : " + rez + "\r\n";


                        sql = "SELECT start_work FROM `card_sotr` WHERE `idcard_sotr`='" + data.SelectedCells[0].Value.ToString() + "'";
                        comand = new MySqlCommand(sql, connection);

                        rez = comand.ExecuteScalar().ToString();
                        s += "Начало смены : " + rez + "\r\n";

                        sql = "SELECT end_work FROM `card_sotr` WHERE `idcard_sotr`='" + data.SelectedCells[0].Value.ToString() + "'";
                        comand = new MySqlCommand(sql, connection);

                        rez = comand.ExecuteScalar().ToString();
                        s += "Конец смены : " + rez + "\r\n";



                        MessageBox.Show(s, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }
                }
                if (ind == 5)
                {
                    if (data.SelectedCells[0].ColumnIndex == 5)
                    {
                        connection.Open();
                        sql = "SELECT FIO FROM `sotrudnik` WHERE `idsotrudnik`='" + data.SelectedCells[0].Value.ToString() + "'";
                        comand = new MySqlCommand(sql, connection);
                        rez = comand.ExecuteScalar().ToString();
                        MessageBox.Show("Ф.И.О. родителя : " + rez, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }
                }


            }
            catch { connection.Close(); }


        }

        private void РазработалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработал: Прозорович Павел Андреевич \r\n\r\nУчащийся 477 группы", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        
        private void ОДостиженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ежегодно филиал ОАО «Берестейский пекарь» Барановичский хлебозавод принимает достойное участие в республиканских выставках и международных конкурсах. Так в 2019 году филиал ОАО «Берестейский пекарь» Барановичский хлебозавод принимал участие в республиканском смотре качества хлебобулочных и кондитерских изделий «Смаката» и был удостоен наград за следующую продукцию:" + "\r\n— Гран - при III степени за торт «Шоколадный - шоколадный»" +
"\r\n— лаваш «Ролл классический»" +

"\r\nА также выпускаются новые виды продукции, участвовавшие в смотре «Смаката»:"
+ "\r\n— булочки сдобные «Милашки»"
+ "\r\n— хлеб «Да сала»"
+ "\r\n— крендель сладкий"
+ "\r\n— булочка «Чёрный бургер» с манкой"

+ "\r\nЕщё одним поводом для гордости в прошедшем году стала победа кондитера 4 разряда Валерии Курчий во Всемирной кондитерской олимпиаде, которая проходила с 15 по 19 февраля в немецком городе Штутгарт.Всемирная кулинарная олимпиада проводится раз в четыре года.В соревнованиях приняли участие сотни профессионалов из разных стран и континентов.Валерия представила на конкурс свою работу, которую назвала «Фантазиум» — сказочный замок из мастики, который покорил жюри и принёс ей «золото».", "О достижениях", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ОКоллективеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Сплоченный коллектив, под руководством Колесникович Натальи Владимировны, большое внимание уделяет модернизации производства, выпуску новых видов продукции, улучшению материально-технической базы и социально-бытовых условий для работников."

+ "\r\nИскренне преданный делу хлебопечения коллектив предприятия составляет более 580 человек.Руководит процессом производства продукции команда технически грамотных, высококвалифицированных специалистов, благодаря чему удается достигать намеченных целей и решать поставленные задачи."

+ "\r\nНа предприятии ежедневно выпускается свыше 120 наименований хлебобулочных(30 тонн) и 50 кондитерских изделий(1, 5 тонны), кроме того, предприятие осуществляет производство шоколадной и какаосодержащей глазури, лаваша и чипсов из него."

+ "\r\nЭффективно работает участок по производству замороженных хлебобулочных, кондитерских изделий и теста слоеного, а также участок по производству прочей продукции(сухари панировочные, кисель, квас)."

+ "\r\nТаким образом, предприятие имеет давние традиции хлебопечения, основанные на старинных белорусских рецептах и подкрепленные новейшими технологиями и современным оборудованием."

+ "\r\nВ 2019 году на предприятии налажен выпуск лаваша и новый, эксклюзивный продукт для жителей Беларуси — чипсы злаковые из лаваша(Vah!) в ассортименте, аналогов по производству которого нет в Республике Беларусь.", "О коллективе", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ОПредприятииToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Филиал ОАО «Берестейский пекарь» Барановичский хлебозавод является ведущим предприятием по производству хлебобулочных и кондитерских изделий Брестской области. Основная его задача – удовлетворение потребности покупателя в высококачественных и безопасных для здоровья хлебобулочных и кондитерских изделиях."

+ "\r\nОсновным рынком, на котором Барановичский хлебозавод осуществляет свою деятельность, является город Барановичи и Барановичский район, а основными потребителями – население города и района.Кроме этого, филиал ОАО «Берестейский пекарь» Барановичский хлебозавод, реализуют свою продукцию в Гродненскую, Гомельскую, Минскую области и город Минск, а также на экспорт в Российскую Федерацию и Германию."

+ "\r\nОдним из основных направлений  маркетинговой политики предприятия является развитие внешних экономических отношений.наращивание экспортного потенциала предприятия, расширение географии поставок, презентация новинок продукции и упаковки."

+ "\r\nБарановичский хлебозавод зарекомендовал себя как производитель высококачественной продукции.На сегодняшний день предриятие является обладателем двух сертификатов соответствия: СТБ ISO 9001 - 2015 система менеджмента качества(Разработка  и производство хлебобулочных изделий) и СТБ 1470 - 2012 система менеджмента безопасности пищевых продуктов на основе анализа опасностей и критических контрольных точек НАССР(Производство и хранение кондитерских изделий).", "О предприятии", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ПрезентацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Process.Start("Презентация.pptx");
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            string s1 = DateTime.Now.ToString("dd-MMMM-yyyy-HH_mm_ss");


            string path1 = @"obroz.xlsx";
            string fullPath;
            fullPath = Path.GetFullPath(path1);
            Excel excel = new Excel(fullPath, 1);

            for (int i = 0; i < data.Columns.Count; i++)
            {
                excel.WriteToCell(0, i, data.Columns[i].HeaderText);
            }

            for (int i = 0; i < data.RowCount - 1; i++)
            {
                for (int j = 0; j < data.ColumnCount; j++)
                {
                    excel.WriteToCell(i + 1, j, "'" + data.Rows[i].Cells[j].Value.ToString());
                }
            }


            string s = s1.ToString();
            excel.SaveAs(@"" + s + "");
            excel.Close(); MessageBox.Show("Сохраненно в 'Документы' под именем \r' " + s + " '", "Экспорт в Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void СправкаОПредприятииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  ОАО «Берестейский пекарь» является ведущим предприятием по производству хлебобулочных и кондитерских изделий Брестской области. Основная задача ОАО «Берестейский пекарь» на рынке – удовлетворение потребности белорусского покупателя в высококачественных и полезных для здоровья хлебобулочных и кондитерских изделиях по доступной цене."
            + "\r\n  ОАО «Берестейский пекарь» включает в себя 7 филиалов по всей территории Брестской области – Барановичский, Пинский, Кобринский, Ганцевичский, Лунинецкий, Столинский и Давид-Городокский (город в Столинском районе). Головной офис предприятия расположен в г. Бресте."

  + "\r\n  На сегодняшний день во всем производственном объединении работает около 2200 человек.С июня 2006 года весь ассортимент выпускаемой продукции реализуется под торговой маркой «Берестейский пекарь». В настоящее время ОАО «Берестейский пекарь» производит более 700 наименований хлебобулочных и кондитерских изделий.Это хлебы, булочные изделия сухари, сушки, баранки, сухарь панировочный, печенье, пряники, торты, пирожные, коврижки, кексы, козинаки, щербет, тесто слоеное, сладости мучные и сахарные, кисель, квас сухой хлебный и т.д.Продукция предприятия широко известна жителям Брестской области, а некоторые виды хлебобулочных и кондитерских изделий жителям всей республики и даже ближнего и дальнего зарубежья."

 + "\r\n  Начало существованию ОАО «Берестейский пекарь» было положено строительством и введением в эксплуатацию цеха по выпечке ржаного хлеба в г.Бресте в 1924 году, который существует по настоящее время.Первый кондитерский цех был открыт в 1975 году.Таким образом, наше предприятие имеет давние традиции хлебопечения, основанные на старинных белорусских рецептах и подкрепленные новейшими технологиями и современным оборудованием.   ", "О предприятии", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            load(ind);
            string s1;
            string s2 = found.Text;

            for (int i = data.RowCount - 2; i >= 0; i--)
            {
                bool rezult = false;

                s1 = data.Rows[i].Cells[4].Value.ToString();
                DateTime StartDate = Convert.ToDateTime(s1);
                string time = DateTime.Now.ToString("dd/MM/yyyy");
                DateTime EndDate = Convert.ToDateTime(time);


                DateTime TwoYears = StartDate.AddYears(Convert.ToInt32(year.Text));

                if (EndDate > TwoYears & cbyear.SelectedIndex == 0) rezult = true;

                if (EndDate < TwoYears & cbyear.SelectedIndex == 1) rezult = true;







                if (!rezult)
                {
                    data.Rows.RemoveAt(i);
                    data.Refresh();
                }
            }


        }
    }



}