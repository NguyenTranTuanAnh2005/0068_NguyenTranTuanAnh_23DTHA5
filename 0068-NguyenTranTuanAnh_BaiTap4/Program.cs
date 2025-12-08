using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2Tuan2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // CHỈNH SỬA TẠI ĐÂY: Chạy Form1 thay vì Form khác
            Application.Run(new _0068_NguyenTranTuanAnh_Bai2.Form1 ());
        }
    }
} 