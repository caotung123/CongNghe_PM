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
    class Modify_NuocUong
    {
        Connection con = new Connection();
        SqlDataAdapter dataAdapt; // Truy xuất dữ liệu vào bảng
        SqlCommand sqlCommand; // Dùng để truy vấn và cập nhật vào csdl
        public Modify_NuocUong()
        {

        }
        //DataSet trả về nhiều bảng
        //DataSet trả về 1 bảng
        //=========================TẠO FORM NƯỚC UỐNG========================
        public DataTable getAllNuocUong()
        {
            DataTable dataTable = new DataTable();
            string sql = "select * from NUOCUONG";
            using (SqlConnection sqlcon = Connection.getcon())
            {
                sqlcon.Open();
                dataAdapt = new SqlDataAdapter(sql, sqlcon);
                dataAdapt.Fill(dataTable);
                sqlcon.Close();
            }
            return dataTable;
        }
        public bool themNU(NuocUong nu)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "INSERT INTO NUOCUONG VALUES (@HINHANH,@MANUOC,@TENNUOC,@DVT,@DONGIA,@TONKHO,@MALOAI)";
            //string sql = "INSERT INTO DICHVU VALUES (N'" + nhanVien.Manv + "', N'" + nhanVien.Tennv + "', N'" + nhanVien.Ngaysinh + "', N'" + nhanVien.Gioitinh + "', N'" + nhanVien.Diachi + "', N'" + nhanVien.Cmnd + "', N'" + nhanVien.Sdt + "', N'" + nhanVien.Chucvu + "', N'" + nhanVien.Maquyen + "', N'" + nhanVien.Username + "', N'" + nhanVien.Password + "')";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("HinhAnh", SqlDbType.Image).Value = nu.Hinhanh;
                sqlCommand.Parameters.Add("MaNuoc", SqlDbType.NVarChar).Value = nu.Manuoc;
                sqlCommand.Parameters.Add("TenNuoc", SqlDbType.NVarChar).Value = nu.Tennuoc;
                sqlCommand.Parameters.Add("DVT", SqlDbType.NVarChar).Value = nu.Dvt;
                sqlCommand.Parameters.Add("DonGia", SqlDbType.Int).Value = nu.Dongia;
                sqlCommand.Parameters.Add("TonKho", SqlDbType.Int).Value = nu.Tonkho;
                sqlCommand.Parameters.Add("MaLoai", SqlDbType.NVarChar).Value = nu.Maloai;
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

        public bool suaNU(NuocUong nu)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "UPDATE NUOCUONG SET " +
                "HINHANH = @HINHANH, TENNUOC = @TENNUOC, DVT = @DVT, DONGIA = @DONGIA, TONKHO = @TONKHO, MALOAI = @MALOAI " +
                "WHERE MANUOC = @MANUOC";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("HinhAnh", SqlDbType.Image).Value = nu.Hinhanh;
                sqlCommand.Parameters.Add("MaNuoc", SqlDbType.NVarChar).Value = nu.Manuoc;
                sqlCommand.Parameters.Add("TenNuoc", SqlDbType.NVarChar).Value = nu.Tennuoc;
                sqlCommand.Parameters.Add("DVT", SqlDbType.NVarChar).Value = nu.Dvt;
                sqlCommand.Parameters.Add("DonGia", SqlDbType.Int).Value = nu.Dongia;
                sqlCommand.Parameters.Add("TonKho", SqlDbType.Int).Value = nu.Tonkho;
                sqlCommand.Parameters.Add("MaLoai", SqlDbType.NVarChar).Value = nu.Maloai;
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

        public bool xoaNU(string manuoc)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "DELETE NUOCUONG WHERE MANUOC = @MANUOC";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("MaNuoc", SqlDbType.NVarChar).Value = manuoc;

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

        //load loại nước
        public void loadmaLoai(ComboBox maloai)
        {
            con.LoadLenCombobox(maloai, "SELECT maloai FROM LOAINUOC", 0);
        }
        public void loadcbLoai(ComboBox cbloai)
        {
            loadmaLoai(cbloai);
        }

        
    }
}
