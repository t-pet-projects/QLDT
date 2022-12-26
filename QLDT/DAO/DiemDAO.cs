using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLDT.DTO;

namespace QLDT.DAO
{
    class DiemDAO
    {
        public static DataTable ThongTinSinhVien()
        {
            string s = "select sv.MSSV, sv.HoTen, sv.GioiTinh, sv.NgaySinh, sv.Nganh, d.DiemQuaTrinh, d.DiemGiuaHocPhan, d.DiemThiKetThuc from SINHVIEN sv left join DIEM d on sv.MSSV = d.MSSV ";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.ExcuteQuery(s);
            return dt;
        }

        public static void Luu(DiemDTO sv)
        {
            string s = $"insert into DIEM values ('{sv.MSSV}', {sv.DiemQuaTrinh}, {sv.DiemGiuaHocPhan}, {sv.DiemThiKetThuc})";
            KetNoiCSDL.ExcuteNonQuery(s);
        }
        public static void Sua(DiemDTO sv)
        {
            string s = $"update DIEM set DiemQuaTrinh={sv.DiemQuaTrinh}, DiemGiuaHocPhan={sv.DiemGiuaHocPhan}, DiemThiKetThuc={sv.DiemThiKetThuc} where MSSV='{sv.MSSV}'";
            KetNoiCSDL.ExcuteNonQuery(s);
        }
        public static void Xoa(DiemDTO sv)
        {
            string s = $"delete from DIEM where MSSV='{sv.MSSV}'";
            KetNoiCSDL.ExcuteNonQuery(s);
        }
    }
}
