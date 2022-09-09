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
    class Modify_NhanVien
    {
        Connection con = new Connection();
        SqlDataAdapter dataAdapt; // Truy xuất dữ liệu vào bảng
        SqlCommand sqlCommand; // Dùng để truy vấn và cập nhật vào csdl
        public Modify_NhanVien()
        {

        }

        //DataSet trả về nhiều bảng
        //DataSet trả về 1 bảng
        public DataTable getAllNV()
        {
            DataTable dataTable = new DataTable();
            string sql = "select * from NHANVIEN";
            using (SqlConnection sqlcon = Connection.getcon())
            {
                sqlcon.Open();
                dataAdapt = new SqlDataAdapter(sql, sqlcon);
                dataAdapt.Fill(dataTable);
                sqlcon.Close();
            }
            return dataTable;
        }

        public bool themNV(NhanVien nhanVien)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "INSERT INTO NHANVIEN VALUES (@MANV,@TENNV,@NGAYSINH,@GIOITINH,@DIACHI,@CMND,@SDT,@CHUCVU,@MACS)";
            //string sql = "INSERT INTO NHANVIEN VALUES (N'" + nhanVien.Manv + "', N'" + nhanVien.Tennv + "', N'" + nhanVien.Ngaysinh + "', N'" + nhanVien.Gioitinh + "', N'" + nhanVien.Diachi + "', N'" + nhanVien.Cmnd + "', N'" + nhanVien.Sdt + "', N'" + nhanVien.Chucvu + "', N'" + nhanVien.Maquyen + "', N'" + nhanVien.Username + "', N'" + nhanVien.Password + "')";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = nhanVien.Manv;
                sqlCommand.Parameters.Add("TenNV", SqlDbType.NVarChar).Value = nhanVien.Tennv;
                sqlCommand.Parameters.Add("NgaySinh", SqlDbType.DateTime).Value = nhanVien.Ngaysinh.ToShortDateString(); // Chỉ lấy ngày tháng năm
                sqlCommand.Parameters.Add("GioiTinh", SqlDbType.NVarChar).Value = nhanVien.Gioitinh;
                sqlCommand.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = nhanVien.Diachi;
                sqlCommand.Parameters.Add("CMND", SqlDbType.NVarChar).Value = nhanVien.Cmnd;
                sqlCommand.Parameters.Add("SDT", SqlDbType.NVarChar).Value = nhanVien.Sdt;
                sqlCommand.Parameters.Add("ChucVu", SqlDbType.NVarChar).Value = nhanVien.Chucvu;
                sqlCommand.Parameters.Add("MaCS", SqlDbType.NVarChar).Value = nhanVien.Macs;

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

        public bool suaNV(NhanVien nhanVien)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "UPDATE NHANVIEN SET" +
                "TENNV = @TENNV, NGAYSINH = @NGAYSINH, GIOITINH = @GIOITINH, DIACHI = @DIACHI, CMND = @CMND, SDT = @SDT, CHUCVU = @CHUCVU, MACS = @MACS" +
                "WHERE MANV = @MANV";
            //string sql = string.Format("UPDATE NHANVIEN SET TENNHANVIEN = N'{0}', NGAYSINH = N'{1}', GIOITINH = N'{2}', DIACHI = N'{3}', CMND = N'{4}', SDT = N'{5}', CHUCVU = N'{6}', MACS = N'{7}'" +
            //    "WHERE MANV = N'{8}'", nhanVien.Tennv, nhanVien.Ngaysinh, nhanVien.Gioitinh, nhanVien.Diachi, nhanVien.Cmnd, nhanVien.Sdt, nhanVien.Chucvu, nhanVien.Macs, nhanVien.Manv);
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = nhanVien.Manv;
                sqlCommand.Parameters.Add("TenNV", SqlDbType.NVarChar).Value = nhanVien.Tennv;
                sqlCommand.Parameters.Add("NgaySinh", SqlDbType.DateTime).Value = nhanVien.Ngaysinh.ToShortDateString(); // Chỉ lấy ngày tháng năm
                sqlCommand.Parameters.Add("GioiTinh", SqlDbType.NVarChar).Value = nhanVien.Gioitinh;
                sqlCommand.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = nhanVien.Diachi;
                sqlCommand.Parameters.Add("CMND", SqlDbType.NVarChar).Value = nhanVien.Cmnd;
                sqlCommand.Parameters.Add("SDT", SqlDbType.NVarChar).Value = nhanVien.Sdt;
                sqlCommand.Parameters.Add("ChucVu", SqlDbType.NVarChar).Value = nhanVien.Chucvu;
                sqlCommand.Parameters.Add("MaCS", SqlDbType.NVarChar).Value = nhanVien.Macs;

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

        public bool xoaNV(string manv)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "DELETE NHANVIEN WHERE MANV = @MANV";
            try
            {
                sqlcon.Open();
                sqlCommand = new SqlCommand(sql, sqlcon);

                sqlCommand.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = manv;

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
