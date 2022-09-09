using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCoffeHouse.SQL
{
    class Connection
    {
        SqlConnection sqlcon;
        SqlCommand sqlcom;
        SqlDataReader sqldr;
        private static string strConnection = @"Data Source=DANGKHOA-PC;Initial Catalog=MYCOFFEHOUSE;Integrated Security=True";
        public static SqlConnection getcon()
        {
            return new SqlConnection(strConnection);
        }

        public static DataTable LayDataTable(string chuoiTruyVan, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(chuoiTruyVan, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool ThucThiTruyVanNonQuery(string sql, SqlConnection sqlcon)
        {
            try
            {
                SqlCommand cm = new SqlCommand(sql, sqlcon);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable taobang(string sql)
        {
            sqlcon = getcon();
            SqlDataAdapter ad = new SqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public void LoadLenCombobox(ComboBox cb, string SQL, int chiso)
        {
            cb.Items.Clear();
            sqlcon = getcon();
            sqlcon.Open();
            sqlcom = new SqlCommand(SQL, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Items.Add(sqldr[chiso].ToString());
            }
            sqlcon.Close();
        }

        public bool kiemtrauser(string sql, string user, string pass)
        {
            sqlcon = getcon();
            bool a = true;
            sqlcom = new SqlCommand(sql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (user == sqldr[0].ToString() && pass == sqldr[1].ToString())
                {
                    a = false;
                }
                else
                {
                    a = true;
                }
            }
            return a;
        }

        public bool KiemtraUsername(string strsql)
        {
            sqlcon = getcon();
            sqlcon.Open();
            sqlcom = new SqlCommand(strsql, sqlcon);
            int tontai = (int)(sqlcom.ExecuteScalar());
            sqlcon.Close();
            if (tontai > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
