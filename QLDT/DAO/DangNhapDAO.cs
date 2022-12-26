using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLDT.DAO
{
    class DangNhapDAO
    {
        public static DataTable DangNhap(string taikhoan)
        {
            string s = $"select * from TAIKHOAN where TenDangNhap='{taikhoan}'";
            DataTable dt = KetNoiCSDL.ExcuteQuery(s);
            return dt;
        }
    }
}
