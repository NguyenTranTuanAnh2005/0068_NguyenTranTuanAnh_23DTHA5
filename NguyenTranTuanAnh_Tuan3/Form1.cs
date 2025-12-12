using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenTranTuanAnh_Tuan3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập bộ lọc file
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mkv;*.wmv|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Mở video đã chọn
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToString("dd/MM/yyyy");
            var time = DateTime.Now.ToString("hh:mm:ss tt");
            // Vẫn cần kiểm tra tên Control này (toolStripStatusLabel1)
            this.toolStripStatusLabel2.Text = string.Format($"Hôm nay là ngày: {date} - Bây giờ là {time}");
        }
    }
}
