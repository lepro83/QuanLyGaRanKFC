using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyGaRanKFC.Model;

namespace QuanLyGaRanKFC.DAO
{
    public class DAO_NguyenLieu : DatabaseConnection
    {
        SqlConnection _conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public DAO_NguyenLieu()
        {
            _conn = new SqlConnection(_strConn);
        }
        public List<NguyenLieu> GetAll()
        {
            List<NguyenLieu> list = new List<NguyenLieu>();
            _conn.Open();
            command = new SqlCommand($"select * from NguyenLieu where isDeleted = 0", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maNL = reader.GetString(0);
                string tenNL = reader.GetString(1);
                int soLuongTon = reader.GetInt32(2);
                NguyenLieu nl = new NguyenLieu(maNL, tenNL, soLuongTon);
                list.Add(nl);
            }
            _conn.Close();
            return list;
        }
        public List<NguyenLieu> GetAllNL(string _maCN)
        {
            List<NguyenLieu> list = new List<NguyenLieu>();
            _conn.Open();
            command = new SqlCommand($"SELECT NguyenLieu.* FROM ChiNhanh, NguyenLieu WHERE ChiNhanh.MaCN = NguyenLieu.MaCN AND dbo.NguyenLieu.MaCN = N'{_maCN}'", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maNL = reader.GetString(0);
                string tenNL = reader.GetString(1);
                int soLuongTon = reader.GetInt32(2);
                NguyenLieu nl = new NguyenLieu(maNL, tenNL, soLuongTon);
                list.Add(nl);
            }
            _conn.Close();
            return list;
        }
        public List<NguyenLieu> GetList(string _maCN)
        {
            List<NguyenLieu> list = new List<NguyenLieu>();
            _conn.Open();
            command = new SqlCommand($"select * from NguyenLieu where MaCN = '{_maCN}' and isDeleted = 0", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maNL = reader.GetString(0);
                string tenNL = reader.GetString(1);
                int soLuongTon = reader.GetInt32(2);
                NguyenLieu nl = new NguyenLieu(maNL, tenNL, soLuongTon);
                list.Add(nl);
            }
            _conn.Close();
            return list;
        }
        public List<NguyenLieu> GetListByName(string _tenNL)
        {
            List<NguyenLieu> list = new List<NguyenLieu>();
            _conn.Open();
            command = new SqlCommand($"select * from NguyenLieu where TenNL LIKE N'%{_tenNL}%' and isDeleted = 0", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maNL = reader.GetString(0);
                string tenNL = reader.GetString(1);
                int soLuongTon = reader.GetInt32(2);
                NguyenLieu nl = new NguyenLieu(maNL, tenNL, soLuongTon);
                list.Add(nl);
            }
            _conn.Close();
            return list;
        }
        public NguyenLieu GetLast(string _maNL)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            _conn.Open();
            command = new SqlCommand($"SELECT TOP(1)* FROM NguyenLieu ORDER BY MaNL DESC", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maNL = reader.GetString(0);
                string tenNL = reader.GetString(1);
                int soLuongTon = reader.GetInt32(2);
                nguyenLieu = new NguyenLieu(maNL, tenNL, soLuongTon);
            }
            _conn.Close();
            return nguyenLieu;
        }
        public NguyenLieu GetByID(string _maNL)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            _conn.Open();
            command = new SqlCommand($"SELECT * FROM NguyenLieu WHERE MaNL = '{_maNL}' and isDeleted = 0", _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maNL = reader.GetString(0);
                string tenNL = reader.GetString(1);
                int soLuongTon = reader.GetInt32(2);
                nguyenLieu = new NguyenLieu(maNL, tenNL, soLuongTon);
            }
            _conn.Close();
            return nguyenLieu;
        }
        public void Add(NguyenLieu _nguyenLieu, string _maCN)
        {
            _conn.Open();
            command = new SqlCommand($@"INSERT INTO NguyenLieu
                                               VALUES(N'{_nguyenLieu.maNL}',
                                               N'{_nguyenLieu.tenNL}',
                                               {_nguyenLieu.soLuongTon},
                                               '{_maCN}',
                                                0)", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Update(NguyenLieu _nguyenLieu, string _maCN)
        {
            _conn.Open();
            command = new SqlCommand($@"UPDATE NguyenLieu 
                                    SET TenNL = N'{_nguyenLieu.tenNL}',
                                        SoLuongTon = {_nguyenLieu.soLuongTon},
                                        MaCN = '{_maCN}'
                                    WHERE MaNL = '{_nguyenLieu.maNL}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public void Delete(string _maNL)
        {
            _conn.Open();
            command = new SqlCommand($"UPDATE NguyenLieu SET isDeleted = 1 WHERE MaNL = '{_maNL}'", _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public int AutoId()
        {
            _conn.Open();
            command = new SqlCommand($"SELECT COUNT(MaNL) FROM NguyenLieu", _conn);
            int i = Convert.ToInt32(command.ExecuteScalar());
            _conn.Close();
            i++;
            return i;
        }
    }
}
