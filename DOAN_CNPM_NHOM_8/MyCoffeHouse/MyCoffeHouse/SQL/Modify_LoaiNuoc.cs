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
    class Modify_LoaiNuoc
    {
        SqlDataAdapter dataAdapt; // Truy xuất dữ liệu vào bảng
        SqlCommand sqlCommand; // Dùng để truy vấn và cập nhật vào csdl
        public Modify_LoaiNuoc()
        {

        }
        //DataSet trả về nhiều bảng
        //DataSet trả về 1 bảng
        public DataTable getAllLoaiNuoc()
        {
            DataTable dataTable = new DataTable();
            string sql = "select * from LOAINUOC";
            using (SqlConnection sqlcon = Connection.getcon())
            {
                sqlcon.Open();
                dataAdapt = new SqlDataAdapter(sql, sqlcon);
                dataAdapt.Fill(dataTable);
                sqlcon.Close();
            }
            return dataTable;
        }
        public bool themLN(LoaiNuoc loaiNuoc)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "INSERT INTO LOAINUOC VALUES (@MALOAI, @TENLOAI)";
            //string sql = "INSERT INTO COSO VALUES (N'" + nhanVien.Manv + "', N'" + nhanVien.Tennv + "', N'" + nhanVien.Ngaysinh + "', N'" + nhanVien.Gioitinh + "', N'" + nhanVien.Diachi + "', N'" + nhanVien.Cmnd + "', N'" + nhanVien.Sdt + "', N'" + nhanVien.Chucvu + "', N'" + nhanVien.Maquyen + "', N'" + nhanVien.Username + "', N'" + nhanVien.Password + "')";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("Maloai", SqlDbType.NVarChar).Value = loaiNuoc.Maloai;
                sqlCommand.Parameters.Add("Tenloai", SqlDbType.NVarChar).Value = loaiNuoc.Tenloai;

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

        public bool suaLN(LoaiNuoc loaiNuoc)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "UPDATE LOAINUOC SET " +
                "TENLOAI = @TENLOAI " +
                "WHERE MALOAI = @MALOAI";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("Maloai", SqlDbType.NVarChar).Value = loaiNuoc.Maloai;
                sqlCommand.Parameters.Add("Tenloai", SqlDbType.NVarChar).Value = loaiNuoc.Tenloai;

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

        public bool xoaLN(string maloai)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "DELETE LOAINUOC WHERE MALOAI = @MALOAI";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("Maloai", SqlDbType.NVarChar).Value = maloai;

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
