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
    class Modify_CoSo
    {
        SqlDataAdapter dataAdapt; // Truy xuất dữ liệu vào bảng
        SqlCommand sqlCommand; // Dùng để truy vấn và cập nhật vào csdl
        public Modify_CoSo()
        {

        }
        //DataSet trả về nhiều bảng
        //DataSet trả về 1 bảng
        public DataTable getAllCoSo()
        {
            DataTable dataTable = new DataTable();
            string sql = "select * from COSO";
            using (SqlConnection sqlcon = Connection.getcon())
            {
                sqlcon.Open();
                dataAdapt = new SqlDataAdapter(sql, sqlcon);
                dataAdapt.Fill(dataTable);
                sqlcon.Close();
            }
            return dataTable;
        }
        public bool themCS(CoSo coSo)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "INSERT INTO COSO VALUES (@MACS, @TENCS, @DIACHI)";
            //string sql = "INSERT INTO COSO VALUES (N'" + nhanVien.Manv + "', N'" + nhanVien.Tennv + "', N'" + nhanVien.Ngaysinh + "', N'" + nhanVien.Gioitinh + "', N'" + nhanVien.Diachi + "', N'" + nhanVien.Cmnd + "', N'" + nhanVien.Sdt + "', N'" + nhanVien.Chucvu + "', N'" + nhanVien.Maquyen + "', N'" + nhanVien.Username + "', N'" + nhanVien.Password + "')";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("Macs", SqlDbType.NVarChar).Value = coSo.Macs;
                sqlCommand.Parameters.Add("Tencs", SqlDbType.NVarChar).Value = coSo.Tencs;
                sqlCommand.Parameters.Add("Diachi", SqlDbType.NVarChar).Value = coSo.Diachi;

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

        public bool suaCS(CoSo coSo)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "UPDATE COSO SET " +
                "TENCS = @TENCS, DIACHI = @DIACHI " +
                "WHERE MACS = @MACS";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("Macs", SqlDbType.NVarChar).Value = coSo.Macs;
                sqlCommand.Parameters.Add("Tencs", SqlDbType.NVarChar).Value = coSo.Tencs;
                sqlCommand.Parameters.Add("Diachi", SqlDbType.NVarChar).Value = coSo.Diachi;

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

        public bool xoaCS(string macs)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "DELETE COSO WHERE MACS = @MACS";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("Macs", SqlDbType.NVarChar).Value = macs;

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
