using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kontakt_ruhm
{
    public class SQLClass
    {
        private ComboBox comboBox1;
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Game\Source\Repos\Kontakt_ruhm\Kontakt_ruhm\AppData\KontaktAndmed.mdf;Integrated Security=True");
        private SqlCommand command;
        private SqlDataAdapter adapter, adapter2;

        public void DisplayGroup(ComboBox _comboBox)
        {
            comboBox1 = _comboBox;

            connection.Open();

            adapter2 = new SqlDataAdapter("SELECT Ruhm FROM Ruhm", connection);
            DataTable kat_table = new DataTable();
            adapter2.Fill(kat_table);

            comboBox1.Items.Clear();
            foreach (DataRow row in kat_table.Rows)
            {
                comboBox1.Items.Add(row["Ruhm"]);
            }

            connection.Close();
        }


    }
}
