using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLDT.DTO;

namespace QLDT.DAO
{
    class SinhVienDAO
    {
        public static DataTable ThongTinSinhVien()
        {
            string s = "select * from SinhVien";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.ExcuteQuery(s);
            return dt;
        }

        public static void Luu(SinhVienDTO sv)
        {
            string s = $"insert into SINHVIEN values ('{sv.MSSV}', N'{sv.HoTen}', {sv.GioiTinh}, '{sv.NgaySinh}', N'{sv.Nganh}')"; ;
            KetNoiCSDL.ExcuteNonQuery(s);
        }
        public static void Sua(SinhVienDTO sv)
        {
            string s = $"update SINHVIEN set HoTen=N'{sv.HoTen}', GioiTinh={sv.GioiTinh}, NgaySinh='{sv.NgaySinh}', Nganh=N'{sv.Nganh}' where MSSV='{sv.MSSV}'";
            KetNoiCSDL.ExcuteNonQuery(s);
        }
        public static void Xoa(SinhVienDTO sv)
        {
            string s = $"delete from SINHVIEN where MSSV='{sv.MSSV}'";
            KetNoiCSDL.ExcuteNonQuery(s);
        }
    }
}
