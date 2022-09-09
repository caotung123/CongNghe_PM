using MyCoffeHouse.ThuocTinh;
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
    class Modify_KhachHang
    {
        Connection con = new Connection();
        SqlDataAdapter dataAdapt; // Truy xuất dữ liệu vào bảng
        SqlCommand sqlCommand; // Dùng để truy vấn và cập nhật vào csdl
        public Modify_KhachHang()
        {

        }
        //DataSet trả về nhiều bảng
        //DataSet trả về 1 bảng
        public DataTable getAllKH()
        {
            DataTable dataTable = new DataTable();
            string sql = "select * from KHACHHANG";
            using (SqlConnection sqlcon = Connection.getcon())
            {
                sqlcon.Open();
                dataAdapt = new SqlDataAdapter(sql, sqlcon);
                dataAdapt.Fill(dataTable);
                sqlcon.Close();
            }
            return dataTable;
        }
        public bool themKH(KhachHang khachHang)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "INSERT INTO KHACHHANG VALUES (@MAKH, @TENKH, @DIACHI, @SDT, @DIEMTL, @MATHE)";
            //string sql = "INSERT INTO KHACHHANG VALUES (N'" + nhanVien.Manv + "', N'" + nhanVien.Tennv + "', N'" + nhanVien.Ngaysinh + "', N'" + nhanVien.Gioitinh + "', N'" + nhanVien.Diachi + "', N'" + nhanVien.Cmnd + "', N'" + nhanVien.Sdt + "', N'" + nhanVien.Chucvu + "', N'" + nhanVien.Maquyen + "', N'" + nhanVien.Username + "', N'" + nhanVien.Password + "')";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = khachHang.Makh;
                sqlCommand.Parameters.Add("TenKH", SqlDbType.NVarChar).Value = khachHang.Tenkh;
                sqlCommand.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = khachHang.Diachi;
                sqlCommand.Parameters.Add("SDT", SqlDbType.NVarChar).Value = khachHang.Sdt;
                sqlCommand.Parameters.Add("DiemTL", SqlDbType.NVarChar).Value = khachHang.Diemtl;
                sqlCommand.Parameters.Add("Mathe", SqlDbType.NVarChar).Value = khachHang.Mathe;
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

        public bool suaKH(KhachHang khachHang)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "UPDATE KHACHHANG SET " +
                "TenKH = @TenKH, DiaChi = @DiaChi, Sdt = @Sdt, Mathe = @Mathe " +
                "WHERE MAKH = @MAKH";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = khachHang.Makh;
                sqlCommand.Parameters.Add("TenKH", SqlDbType.NVarChar).Value = khachHang.Tenkh;
                sqlCommand.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = khachHang.Diachi;
                sqlCommand.Parameters.Add("SDT", SqlDbType.NVarChar).Value = khachHang.Sdt;
                sqlCommand.Parameters.Add("DiemTL", SqlDbType.NVarChar).Value = khachHang.Diemtl;
                sqlCommand.Parameters.Add("Mathe", SqlDbType.NVarChar).Value = khachHang.Mathe;
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

        public bool xoaKH(string makh)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "DELETE KHACHHANG WHERE MAKH = @MAKH";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = makh;

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

        //load mã thẻ
        public void loadmathe(ComboBox mathe)
        {
            con.LoadLenCombobox(mathe, "SELECT mathe FROM [dbo].[LOAITHE]", 0);
        }

        //load combobox thẻ
        public void loadcbthe(ComboBox cbthe)
        {
            loadmathe(cbthe);
        }
    }
}
