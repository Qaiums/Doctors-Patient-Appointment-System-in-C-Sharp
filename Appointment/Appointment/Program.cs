using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;
using System.IO;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Appointment
{
    static class Program
    {
        private static string _dbpath = "E:\\CSHARP\\Appointment\\Appointment\\appointment.mdf";
        private static string _username = "";
        private static string _rolename = "";
        private static int _loginid = -1;
        private static int _appid = -1;
        private static string _doctorUsername = "";
        private static string _doctorName = "";

        public static string dbPath
        {
            get { return _dbpath; }
            set { _dbpath = value; }
        }

        public static string userName
        {
            get { return _username; }
            set { _username = value; }
        }

        public static string roleName
        {
            get { return _rolename; }
            set { _rolename = value; }
        }

        public static int loginId
        {
            get { return _loginid; }
            set { _loginid = value; }
        }

        public static int appId
        {
            get { return _appid; }
            set { _appid = value; }
        }

        public static string doctorUsername
        {
            get { return _doctorUsername; }
            set { _doctorUsername = value; }
        }

        public static string doctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; }
        }

        public static SqlConnection getConn()
        {
            string connStr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + Program.dbPath + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }

        public static bool checkPhone(string number)
        {
            Match match = Regex.Match(number, @"^01[0-9]{9}$");
            return match.Success;
        }

        public static void getPDF(DataGridView dt)
        {
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("There is no data to PRINT.");
            }
            else
            {
                Document doc = new Document();
                Random rnd = new Random();
                PdfPTable tableLayout = new PdfPTable(3);
                PdfWriter.GetInstance(doc, new FileStream("E:\\CSHARP\\" + userName + rnd.Next(0, 999999999) + "-appointment-list.pdf", FileMode.Create));
                doc.Open();
                PdfPTable pdfTable = new PdfPTable(5);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int k = 1; k < dt.Columns.Count; k++)
                    {
                        pdfTable.AddCell(dt[k, i].Value.ToString());
                    }
                }
                doc.Add(pdfTable);
                doc.Close();
                MessageBox.Show("PDF saved to project directory.");
            }
        }

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new home());
        }
    }
}
