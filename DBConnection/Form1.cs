using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection();

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();

            this.connection.StateChange += new StateChangeEventHandler(this.connection_StateChange);
        }

        private void connection_StateChange(object sender,StateChangeEventArgs e)
        {
            подключениеКБДToolStripMenuItem.Enabled =
            (e.CurrentState == ConnectionState.Closed);

            ассинхронноеПодключениеКБДToolStripMenuItem.Enabled =
            (e.CurrentState == ConnectionState.Closed);

            отключениеОтБДToolStripMenuItem.Enabled =
            (e.CurrentState == ConnectionState.Open);
        }


        private void подключениеКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных " +
                        connection.Database + " выполнено успешно " + "\nСервер: " +
                        connection.DataSource);
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (SqlException XcpSQL)
            {
                foreach (SqlError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "Источник ошибки: " + se.Source,
                    MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void отключениеОтБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        private async void ассинхронноеПодключениеКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.ConnectionString = connectionString;
                        await connection.OpenAsync();
                        MessageBox.Show("Соединение с базой данных " +
                       connection.Database + " выполнено успешно " + "\nСервер: " +
                       connection.DataSource);
                    }
                    
                    else
                        MessageBox.Show("Соединение с базой данных уже установлено");
                }
                catch (SqlException XcpSQL)
                {
                    foreach (SqlError se in XcpSQL.Errors)
                    {
                        MessageBox.Show(se.Message, "Источник ошибки: " + se.Source,
                        MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
                catch (Exception Xcp)
                {
                    MessageBox.Show(Xcp.Message, "Unexpected Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
