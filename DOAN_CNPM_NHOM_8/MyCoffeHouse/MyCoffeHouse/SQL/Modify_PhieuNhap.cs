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
    class Modify_PhieuNhap
    {
        Connection con = new Connection();
        SqlDataAdapter dataAdapt; // Truy xuất dữ liệu vào bảng
        SqlCommand sqlCommand; // Dùng để truy vấn và cập nhật vào csdl
        public Modify_PhieuNhap()
        {

        }
        //DataSet trả về nhiều bảng
        //DataSet trả về 1 bảng
        public DataTable getAllPN()
        {
            DataTable dataTable = new DataTable();
            string sql = "select * from PHIEUNHAP";
            using (SqlConnection sqlcon = Connection.getcon())
            {
                sqlcon.Open();
                dataAdapt = new SqlDataAdapter(sql, sqlcon);
                dataAdapt.Fill(dataTable);
                sqlcon.Close();
            }
            return dataTable;
        }
        public bool themPN(PhieuNhap phieuNhap)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "INSERT INTO PHIEUNHAP VALUES (@MAPN, @MANV, @MANCC, @MACS, @NGAYLAP, @TONGTIEN)";
            //string sql = "INSERT INTO KHACHHANG VALUES (N'" + nhanVien.Manv + "', N'" + nhanVien.Tennv + "', N'" + nhanVien.Ngaysinh + "', N'" + nhanVien.Gioitinh + "', N'" + nhanVien.Diachi + "', N'" + nhanVien.Cmnd + "', N'" + nhanVien.Sdt + "', N'" + nhanVien.Chucvu + "', N'" + nhanVien.Maquyen + "', N'" + nhanVien.Username + "', N'" + nhanVien.Password + "')";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("MaPN", SqlDbType.NVarChar).Value = phieuNhap.Mapn;
                sqlCommand.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = phieuNhap.Manv;
                sqlCommand.Parameters.Add("MaNCC", SqlDbType.NVarChar).Value = phieuNhap.Mancc;
                sqlCommand.Parameters.Add("MaCS", SqlDbType.NVarChar).Value = phieuNhap.Macs;
                sqlCommand.Parameters.Add("NgayLap", SqlDbType.DateTime).Value = phieuNhap.Ngaylap.ToShortDateString();
                sqlCommand.Parameters.Add("TongTien", SqlDbType.Int).Value = phieuNhap.Tongtien;
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

        public bool suaPN(PhieuNhap phieuNhap)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "UPDATE PHIEUNHAP SET " +
                "MANV = @MANV, MANCC = @MANCC, MACS = @MACS, NGAYLAP = @NGAYLAP, TONGTIEN = @TONGTIEN " +
                "WHERE MAPN = @MAPN";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("MaPN", SqlDbType.NVarChar).Value = phieuNhap.Mapn;
                sqlCommand.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = phieuNhap.Manv;
                sqlCommand.Parameters.Add("MaNCC", SqlDbType.NVarChar).Value = phieuNhap.Mancc;
                sqlCommand.Parameters.Add("MaCS", SqlDbType.NVarChar).Value = phieuNhap.Macs;
                sqlCommand.Parameters.Add("NgayLap", SqlDbType.DateTime).Value = phieuNhap.Ngaylap.ToShortDateString();
                sqlCommand.Parameters.Add("TongTien", SqlDbType.Int).Value = phieuNhap.Tongtien;
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

        public bool xoaPN(string mapn)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "DELETE PHIEUNHAP WHERE MAPN = @MAPN";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("MaPN", SqlDbType.NVarChar).Value = mapn;

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

        //load nhân viên
        public void loadmaNV(ComboBox manv)
        {
            con.LoadLenCombobox(manv, "SELECT manv FROM NHANVIEN", 0);
        }
        public void loadcbNV(ComboBox cbnv)
        {
            loadmaNV(cbnv);
        }

        //load nhà cung cấp
        public void loadmaNCC(ComboBox mancc)
        {
            con.LoadLenCombobox(mancc, "SELECT mancc FROM NCC", 0);
        }
        public void loadcbNCC(ComboBox cbncc)
        {
            loadmaNCC(cbncc);
        }

        //load cơ sở
        public void loadmaCS(ComboBox macs)
        {
            con.LoadLenCombobox(macs, "SELECT macs FROM COSO", 0);
        }
        public void loadcbCS(ComboBox cbcs)
        {
            loadmaCS(cbcs);
        }
    }
}
