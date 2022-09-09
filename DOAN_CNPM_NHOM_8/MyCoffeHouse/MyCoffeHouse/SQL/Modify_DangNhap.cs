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
    class Modify_DangNhap
    {
        Connection con = new Connection();
        SqlDataAdapter dataAdapt; // Truy xuất dữ liệu vào bảng
        SqlCommand sqlCommand; // Dùng để truy vấn và cập nhật vào csdl
        public Modify_DangNhap()
        {

        }
        //DataSet trả về nhiều bảng
        //DataSet trả về 1 bảng
        //public DataTable getAllDangNhap()
        //{
        //    DataTable dataTable = new DataTable();
        //    string sql = "select * from DANGNHAP";
        //    using (SqlConnection sqlcon = Connection.getcon())
        //    {
        //        sqlcon.Open();
        //        dataAdapt = new SqlDataAdapter(sql, sqlcon);
        //        dataAdapt.Fill(dataTable);
        //        sqlcon.Close();
        //    }
        //    return dataTable;
        //}
        //public bool themDN(DangNhap dangNhap)
        //{
        //    SqlConnection sqlcon = Connection.getcon();
        //    string sql = "INSERT INTO DANGNHAP VALUES (@USERNAME, @PASSWORD, @MANV)";
        //    //string sql = "INSERT INTO COSO VALUES (N'" + nhanVien.Manv + "', N'" + nhanVien.Tennv + "', N'" + nhanVien.Ngaysinh + "', N'" + nhanVien.Gioitinh + "', N'" + nhanVien.Diachi + "', N'" + nhanVien.Cmnd + "', N'" + nhanVien.Sdt + "', N'" + nhanVien.Chucvu + "', N'" + nhanVien.Maquyen + "', N'" + nhanVien.Username + "', N'" + nhanVien.Password + "')";
        //    try
        //    {
        //        sqlcon.Open();
        //        sqlCommand = new SqlCommand(sql, sqlcon);

        //        sqlCommand.Parameters.Add("Username", SqlDbType.NVarChar).Value = dangNhap.Username;
        //        sqlCommand.Parameters.Add("Password", SqlDbType.NVarChar).Value = dangNhap.Password;
        //        sqlCommand.Parameters.Add("Manv", SqlDbType.NVarChar).Value = dangNhap.Manv;

        //        sqlCommand.ExecuteNonQuery(); // Thực thi câu lệnh truy vấn
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //    return true;
        //}

        //public bool suaDN(DangNhap dangNhap)
        //{
        //    SqlConnection sqlcon = Connection.getcon();
        //    string sql = "UPDATE DANGNHAP SET " +
        //        "PASSWORD = @PASSWORD, MANV = @MANV " +
        //        "WHERE USERNAME = @USERNAME";
        //    try
        //    {
        //        sqlcon.Open();
        //        sqlCommand = new SqlCommand(sql, sqlcon);

        //        sqlCommand.Parameters.Add("Username", SqlDbType.NVarChar).Value = dangNhap.Username;
        //        sqlCommand.Parameters.Add("Password", SqlDbType.NVarChar).Value = dangNhap.Password;
        //        sqlCommand.Parameters.Add("Manv", SqlDbType.NVarChar).Value = dangNhap.Manv;

        //        sqlCommand.ExecuteNonQuery(); // Thực thi câu lệnh truy vấn
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //    return true;
        //}

        //public bool xoaDN(string username)
        //{
        //    SqlConnection sqlcon = Connection.getcon();
        //    string sql = "DELETE DANGNHAP WHERE USERNAME = @USERNAME";
        //    try
        //    {
        //        sqlcon.Open();
        //        sqlCommand = new SqlCommand(sql, sqlcon);

        //        sqlCommand.Parameters.Add("USERNAME", SqlDbType.NVarChar).Value = username;

        //        sqlCommand.ExecuteNonQuery(); // Thực thi câu lệnh truy vấn
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //    return true;
        //}

        //load nhân viên
        public void loadmanv(ComboBox manv)
        {
            con.LoadLenCombobox(manv, "SELECT manv FROM NHANVIEN", 0);
        }

        //load combobox nhan vien
        public void loadcbnv(ComboBox cbnv)
        {
            loadmanv(cbnv);
        }

        public bool Kiemtrauser(DangNhap user)
        {
            string sql = "select count(*) from DANGNHAP where Username ='" + user.Username + "' and Password = '" + user.Password + "' and Manv = '" + user.Manv + "'";
            return con.KiemtraUsername(sql);
        }
    }
}
