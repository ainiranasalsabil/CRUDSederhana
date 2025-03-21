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

namespace CRUDSederhana
{
    public partial class Form1 : Form
    {
        // Connection String untuk menghubungkan ke database SQL Server
        private string connectionString = "Data Source=LAPTOP-IG6H9FSB\\AIRA_BIL;Initial Catalog=OrganisasiMahasiswa;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
