using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontakt_ruhm
{
    public partial class Form1 : Form
    {
        DateTime DateTimeNow = DateTime.Now;

        SQLClass sqlClass = new SQLClass();

        SaveFileDialog save;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Game\Source\Repos\Kontakt_ruhm\Kontakt_ruhm\AppData\KontaktAndmed.mdf;Integrated Security=True");
        SqlCommand command, command1;
        SqlDataAdapter adapter, adapter2, adapter3;
        string vanem;
        string GetDate;
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        public void DisplayData()
        {

            connection.Open();
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("SELECT Id, nimi, perekonnanimi, telefon, email, vanus, naita_vanem, ruhm_id FROM dbo.Kontakt", connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            connection.Close();

            sqlClass.DisplayGroup(comboBox1);
        }


        private void ClearData()
        {
            Id = 0;
            Nimitxt.Text = "";
            Telefontxt.Text = "";
            Emailtxt.Text = "";
            Eesnimitxt.Text = "";
            comboBox1.Text = "";

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (checkBox1.Checked)
            {
                Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Nimitxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Eesnimitxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Telefontxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Emailtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            else if(checkBox1.Checked == false)
            {
                Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Nimitxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Eesnimitxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Telefontxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Emailtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                GetDate = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(GetDate);

                vanem = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                string v = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                comboBox1.SelectedIndex = Int32.Parse(v) - 1;
            }


            
        }

        private void lisa_pilt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            open.InitialDirectory = Path.GetDirectoryName(@"Desktop");
            if (open.ShowDialog() == DialogResult.OK)
            {

                save = new SaveFileDialog();
                save.FileName = Nimitxt.Text + ".jpg";
                save.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                save.InitialDirectory = Path.GetDirectoryName(@"C:\Users\Game\source\repos\Kontakt_ruhm\Kontakt_ruhm\Images\");
                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(open.FileName, save.FileName);
                    save.RestoreDirectory = true;
                    pictureBox1.Image = Image.FromFile(save.FileName);
                }


            }
        }
        string file_pilt;
        private void muuda_button_Click(object sender, EventArgs e)
        {
            if (Nimitxt.Text != "" && Telefontxt.Text != "" && Emailtxt.Text != "")
            {
                command = new SqlCommand("UPDATE Kontakt SET nimi=@nimi, telefon=@telefon, email=@email, foto=@foto, vanus=@vanus, naita_vanem=@naita_vanem, ruhm_id=@ruhm_id WHERE Id=@id", connection);
                connection.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@nimi", Nimitxt.Text);
                command.Parameters.AddWithValue("@telefon", Telefontxt.Text);
                command.Parameters.AddWithValue("@email", Emailtxt.Text);
                file_pilt = Nimitxt.Text + ".jpg";
                command.Parameters.AddWithValue("@foto", file_pilt);
                command.Parameters.AddWithValue("@ruhm_id", (comboBox1.SelectedIndex + 1));
                command.Parameters.AddWithValue("@vanus", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@naita_vanem", naitaVanem.Text);
                command.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed uuendatud");
            }
        }

        private void kustuta_button_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                command = new SqlCommand("DELETE FROM Kontakt WHERE Id=@id", connection);

                connection.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed uuendatud");
            }
            else
            {
                MessageBox.Show("Viga!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("SELECT nimi, telefon, email, foto, vanem_nimi, ruhm_id FROM Kontakt WHERE nimi=@nimi", connection);
                command.Parameters.AddWithValue("@nimi", otsingTxt.Text);
                command.ExecuteNonQuery();
                bool temp = false;
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Nimitxt.Text = dataReader.GetValue(0).ToString();
                    Telefontxt.Text = dataReader.GetValue(1).ToString();
                    Emailtxt.Text = dataReader.GetValue(2).ToString();
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Game\source\repos\Kontakt_ruhm\Kontakt_ruhm\Images\" + dataReader.GetValue(3).ToString());
                    string ConverToString = dataReader.GetValue(4).ToString();
                    comboBox1.SelectedIndex = Int32.Parse(ConverToString);
                    temp = true;
                }
                if (temp == false)
                {
                    MessageBox.Show("Not Found");
                    connection.Close();
                }

                connection.Close();
            }
            catch (Exception)
            {


            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            mail SaadaMaili = new mail(checkBox1);

            SaadaMaili.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (vanem == "jah")
                {
                    connection.Open();
                    DataTable table = new DataTable();
                    command = new SqlCommand("SELECT Id, nimi, perekonnanimi, telefon, email, Opilane_Id FROM dbo.Vanemad WHERE Opilane_Id=@opilane_id", connection);
                    command.Parameters.AddWithValue("@opilane_id", Id);
                    table.Load(command.ExecuteReader());
                    dataGridView1.DataSource = table;
                    connection.Close();


                }
                else if (vanem == "ei")
                {
                    MessageBox.Show("Ei andnud nõusolekut oma vanemate paigutamiseks");
                    checkBox1.Checked = false;
                }

                else
                {
                    connection.Open();
                    DataTable table = new DataTable();
                    command = new SqlCommand("SELECT Id, nimi, perekonnanimi, telefon, email, Opilane_Id FROM dbo.Vanemad ", connection);
                    table.Load(command.ExecuteReader());
                    dataGridView1.DataSource = table;
                    connection.Close();
                }
                

            }
            else
            {
                DisplayData();
            }
            
        }

        private void lisa_button_Click(object sender, EventArgs e)
        {
            if (Nimitxt.Text != "" && Telefontxt.Text != "" && Emailtxt.Text != "" && comboBox1.SelectedItem != null && checkBox2.Checked)
            {
                try
                {
                    command = new SqlCommand("INSERT INTO Kontakt(nimi, perekonnanimi, telefon, email, foto, ruhm_id, vanus, naita_vanem) VALUES(@nimi, @perekonnanimi, @telefon, @email, @foto, @ruh, @vanus, @naitaVanem)", connection);
                    
                    connection.Open();
                    command.Parameters.AddWithValue("@nimi", Nimitxt.Text);
                    command.Parameters.AddWithValue("@perekonnanimi", Eesnimitxt.Text);
                    command.Parameters.AddWithValue("@telefon", Telefontxt.Text);
                    command.Parameters.AddWithValue("@email", Emailtxt.Text);
                    string file_pilt = Nimitxt.Text + ".jpg";
                    command.Parameters.AddWithValue("@foto", file_pilt);
                    command.Parameters.AddWithValue("@ruh", (comboBox1.SelectedIndex + 1));
                    command.Parameters.AddWithValue("@vanus", dateTimePicker1.Value);

                    if (checkBox2.Checked == true && DateTimeNow.Year - dateTimePicker1.Value.Year < 18)
                    {
                        command.Parameters.AddWithValue("@naitaVanem", "jah");
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@naitaVanem", "ei");
                    }

                    command.ExecuteNonQuery();
                    connection.Close();
                    DisplayData();
                    ClearData();
                    checkBox2.Checked = false;
                    MessageBox.Show("Andmed on lisatud");

                }
                catch (Exception)
                {

                }
            }

            else
            {
                MessageBox.Show("Viga!");
            }
        }

    }
}
