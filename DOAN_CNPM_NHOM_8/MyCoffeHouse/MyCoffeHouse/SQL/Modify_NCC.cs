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
    class Modify_NCC
    {
        SqlDataAdapter dataAdapt; // Truy xuất dữ liệu vào bảng
        SqlCommand sqlCommand; // Dùng để truy vấn và cập nhật vào csdl
        public Modify_NCC()
        {

        }
        //DataSet trả về nhiều bảng
        //DataSet trả về 1 bảng
        public DataTable getAllNCC()
        {
            DataTable dataTable = new DataTable();
            string sql = "select * from NCC";
            using (SqlConnection sqlcon = Connection.getcon())
            {
                sqlcon.Open();
                dataAdapt = new SqlDataAdapter(sql, sqlcon);
                dataAdapt.Fill(dataTable);
                sqlcon.Close();
            }
            return dataTable;
        }
        public bool themNCC(NCC ncc)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "INSERT INTO NCC VALUES (@MANCC, @TENNCC, @DIACHI, @SDT)";
            //string sql = "INSERT INTO COSO VALUES (N'" + nhanVien.Manv + "', N'" + nhanVien.Tennv + "', N'" + nhanVien.Ngaysinh + "', N'" + nhanVien.Gioitinh + "', N'" + nhanVien.Diachi + "', N'" + nhanVien.Cmnd + "', N'" + nhanVien.Sdt + "', N'" + nhanVien.Chucvu + "', N'" + nhanVien.Maquyen + "', N'" + nhanVien.Username + "', N'" + nhanVien.Password + "')";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("Mancc", SqlDbType.NVarChar).Value = ncc.Mancc;
                sqlCommand.Parameters.Add("Tenncc", SqlDbType.NVarChar).Value = ncc.Tenncc;
                sqlCommand.Parameters.Add("Diachi", SqlDbType.NVarChar).Value = ncc.Diachi;
                sqlCommand.Parameters.Add("Sdt", SqlDbType.NVarChar).Value = ncc.Sdt;

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

        public bool suaNCC(NCC ncc)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "UPDATE NCC SET " +
                "TENNCC = @TENNCC, DIACHI = @DIACHI, SDT = @SDT " +
                "WHERE MANCC = @MANCC";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("Mancc", SqlDbType.NVarChar).Value = ncc.Mancc;
                sqlCommand.Parameters.Add("Tenncc", SqlDbType.NVarChar).Value = ncc.Tenncc;
                sqlCommand.Parameters.Add("Diachi", SqlDbType.NVarChar).Value = ncc.Diachi;
                sqlCommand.Parameters.Add("Sdt", SqlDbType.NVarChar).Value = ncc.Sdt;

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

        public bool xoaNCC(string mancc)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "DELETE NCC WHERE MANCC = @MANCC";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("Mancc", SqlDbType.NVarChar).Value = mancc;

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
