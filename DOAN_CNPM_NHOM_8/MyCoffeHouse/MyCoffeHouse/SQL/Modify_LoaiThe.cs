using MyCoffeHouse.ThuocTinh;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.SQL
{
    class Modify_LoaiThe
    {
        SqlDataAdapter dataAdapt; // Truy xuất dữ liệu vào bảng
        SqlCommand sqlCommand; // Dùng để truy vấn và cập nhật vào csdl
        public Modify_LoaiThe()
        {

        }
        //DataSet trả về nhiều bảng
        //DataSet trả về 1 bảng
        public DataTable getAllLoaiThe()
        {
            DataTable dataTable = new DataTable();
            string sql = "select * from LOAITHE";
            using (SqlConnection sqlcon = Connection.getcon())
            {
                sqlcon.Open();
                dataAdapt = new SqlDataAdapter(sql, sqlcon);
                dataAdapt.Fill(dataTable);
                sqlcon.Close();
            }
            return dataTable;
        }
        public bool themThe(LoaiThe lt)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "INSERT INTO LOAITHE VALUES (@MATHE, @TENTHE, @GHICHU)";
            //string sql = "INSERT INTO COSO VALUES (N'" + nhanVien.Manv + "', N'" + nhanVien.Tennv + "', N'" + nhanVien.Ngaysinh + "', N'" + nhanVien.Gioitinh + "', N'" + nhanVien.Diachi + "', N'" + nhanVien.Cmnd + "', N'" + nhanVien.Sdt + "', N'" + nhanVien.Chucvu + "', N'" + nhanVien.Maquyen + "', N'" + nhanVien.Username + "', N'" + nhanVien.Password + "')";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("Mathe", SqlDbType.NVarChar).Value = lt.Mathe;
                sqlCommand.Parameters.Add("Tenthe", SqlDbType.NVarChar).Value = lt.Tenthe;
                sqlCommand.Parameters.Add("Ghichu", SqlDbType.NVarChar).Value = lt.Ghichu;

                sqlCommand.ExecuteNonQuery(); // Thực thi câu lệnh truy vấn
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
            return true;
        }

        public bool suaThe(LoaiThe lt)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "UPDATE LOAITHE SET " +
                "TENTHE = @TENTHE, GHICHU = @GHICHU " +
                "WHERE MATHE = @MATHE";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("Mathe", SqlDbType.NVarChar).Value = lt.Mathe;
                sqlCommand.Parameters.Add("Tenthe", SqlDbType.NVarChar).Value = lt.Tenthe;
                sqlCommand.Parameters.Add("Ghichu", SqlDbType.NVarChar).Value = lt.Ghichu;

                sqlCommand.ExecuteNonQuery(); // Thực thi câu lệnh truy vấn
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
            return true;
        }

        public bool xoaThe(string mathe)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "DELETE LOAITHE WHERE MATHE = @MATHE";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("Mathe", SqlDbType.NVarChar).Value = mathe;

                sqlCommand.ExecuteNonQuery(); // Thực thi câu lệnh truy vấn
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
            return true;
        }
    }
}
