using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0068_NguyenTranTuanAnh_Bai2
{
    public partial class Form1 : Form
    {
        // Ghi chú về Control (Ánh xạ theo khung code mới nhất):
        // MSSV: txt_MSSV | HoTen: txt_HoTen | ĐTB: txt_DTB 
        // Khoa: combobox_chuyennganh | Nam: radiobtn_Nam | Nữ: radiobtn_Nu 
        // Tổng Nam: txt_TongNam | Tổng Nữ: txt_TongNu | Grid: dataGridView1

        public Form1()
        {
            InitializeComponent();
            // Đảm bảo sự kiện CellClick được thêm vào nếu chưa có
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        }

        // =========================================================
        // KHAI BÁO HÀM HỖ TRỢ (Functions for Logic)
        // =========================================================

        /// <summary>
        /// Tìm chỉ mục (index) của sinh viên trong DataGridView dựa trên MSSV.
        /// </summary>
        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                // Giả sử MSSV ở Cột 0
                if (dataGridView1.Rows[i].Cells[0].Value != null &&
                    dataGridView1.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Tính tổng số sinh viên Nam và Nữ dựa trên Khoa đang được chọn (Yêu cầu 2.5).
        /// </summary>
        private void CalculateTotals()
        {
            int totalMale = 0;
            int totalFemale = 0;

            // Lấy tên Khoa đang được chọn.
            string selectedFaculty = combobox_chuyennganh.Text;

            if (string.IsNullOrEmpty(selectedFaculty))
            {
                txt_TongNam.Text = "0";
                txt_TongNu.Text = "0";
                return;
            }

            // Duyệt qua DataGridView
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                // Giả sử Khoa ở Cột 4 và Giới Tính ở Cột 2
                string facultyInRow = row.Cells[4].Value?.ToString();
                string genderInRow = row.Cells[2].Value?.ToString();

                if (facultyInRow == selectedFaculty)
                {
                    if (genderInRow == "Nam")
                    {
                        totalMale++;
                    }
                    else if (genderInRow == "Nữ")
                    {
                        totalFemale++;
                    }
                }
            }

            // Cập nhật kết quả lên các TextBox hiển thị tổng
            txt_TongNam.Text = totalMale.ToString();
            txt_TongNu.Text = totalFemale.ToString();
        }

        /// <summary>
        /// Hàm thiết lập cấu trúc cột và dữ liệu mẫu cho DataGridView.
        /// </summary>
        private void SetupDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns.Clear();

            // Thêm các cột theo thứ tự (MSSV, Họ Tên, Giới Tính, ĐTB, Khoa)
            dataGridView1.Columns.Add("MSSV", "MSSV");              // Cột 0
            dataGridView1.Columns.Add("HoTen", "Họ Tên");            // Cột 1
            dataGridView1.Columns.Add("GioiTinh", "Giới Tính");      // Cột 2
            dataGridView1.Columns.Add("DTB", "ĐTB");                // Cột 3
            dataGridView1.Columns.Add("Khoa", "Khoa");              // Cột 4

            // ĐÃ BỎ BỎ DỮ LIỆU MẪU ĐỂ NGƯỜI DÙNG TỰ NHẬP
            // dataGridView1.Rows.Add("SV001", "Nguyễn Văn A", "Nam", "8.5", "QTKD");
            // ...
        }

        // =========================================================
        // XỬ LÝ SỰ KIỆN (Event Handlers)
        // =========================================================

        // Sự kiện Load Form (Form1_Load)
        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Thiết lập DataGridView
            SetupDataGridView();

            // 2. Chọn Khoa mặc định (QTKD, giả sử là index 0) - Yêu cầu 2.1
            combobox_chuyennganh.SelectedIndex = 0;

            // 3. Giới tính Nữ mặc định checked - Yêu cầu 2.1
            radiobtn_Nu.Checked = true;

            // 4. Tính tổng sinh viên ban đầu - Yêu cầu 2.5
            CalculateTotals();
        }

        // Xử lý sự kiện thay đổi Khoa (Yêu cầu 2.5)
        private void combobox_chuyennganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        // Xử lý sự kiện click vào nút Thêm/Sửa (btn_ThemhoacSua)
        private void btn_ThemhoacSua_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra thông tin bắt buộc (Yêu cầu 2.2)
            if (string.IsNullOrWhiteSpace(txt_MSSV.Text) ||
                string.IsNullOrWhiteSpace(txt_HoTen.Text) || // Sử dụng tên mới: txt_HoTen
                string.IsNullOrWhiteSpace(txt_DTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float averageScore;
            // Kiểm tra Điểm Trung Bình
            if (!float.TryParse(txt_DTB.Text, out averageScore) || averageScore < 0 || averageScore > 10)
            {
                MessageBox.Show("Điểm trung bình không hợp lệ (phải là số từ 0 đến 10)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Chuẩn bị dữ liệu
            string studentID = txt_MSSV.Text;
            string fullName = txt_HoTen.Text; // Sử dụng tên mới: txt_HoTen
            string gender = radiobtn_Nam.Checked ? "Nam" : "Nữ";
            string faculty = combobox_chuyennganh.Text;

            // 3. Kiểm tra xem MSSV đã tồn tại chưa
            int selectedRow = GetSelectedRow(studentID);

            if (selectedRow == -1) // KHÔNG tồn tại -> THÊM MỚI
            {
                // Thêm một dòng mới
                dataGridView1.Rows.Add(studentID, fullName, gender, averageScore.ToString(), faculty);
                MessageBox.Show("Thêm mới dữ liệu sinh viên vừa nhập vào DataGridView, và thông báo Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // ĐÃ tồn tại -> CẬP NHẬT
            {
                // Cập nhật dữ liệu vào dòng đã tìm thấy
                dataGridView1.Rows[selectedRow].Cells[1].Value = fullName;
                dataGridView1.Rows[selectedRow].Cells[2].Value = gender;
                dataGridView1.Rows[selectedRow].Cells[3].Value = averageScore.ToString();
                dataGridView1.Rows[selectedRow].Cells[4].Value = faculty;
                MessageBox.Show("Cập nhật dữ liệu sinh viên vào DataGridView, và thông báo Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi sửa, cho phép sửa MSSV lại 
                txt_MSSV.Enabled = true;
            }

            // 4. Cập nhật tổng số sinh viên (Yêu cầu 2.5)
            CalculateTotals();
        }

        // Xử lý sự kiện click vào nút Xóa (btn_Xoa)
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Yêu cầu 2.3: Xóa

            string studentID = txt_MSSV.Text;

            if (string.IsNullOrWhiteSpace(studentID))
            {
                MessageBox.Show("Vui lòng nhập MSSV cần xóa hoặc chọn sinh viên trên lưới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRow = GetSelectedRow(studentID);

            if (selectedRow == -1)
            {
                MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Yêu cầu xác nhận xóa
            DialogResult confirm = MessageBox.Show(
                $"Kiểm tra MSSV cần xóa có tồn tại trong DataGridView. Bạn có muốn xóa sinh viên có MSSV: {studentID} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                // Thực hiện xóa dòng
                dataGridView1.Rows.RemoveAt(selectedRow);
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật tổng số sinh viên (Yêu cầu 2.5)
                CalculateTotals();

                // Cho phép sửa MSSV trở lại
                txt_MSSV.Enabled = true;
            }
        }

        // Xử lý sự kiện click vào DataGridView (Yêu cầu 2.4)
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // 1. MSSV (Cột 0)
                txt_MSSV.Text = row.Cells[0].Value?.ToString();

                // 2. Họ Tên (Cột 1)
                txt_HoTen.Text = row.Cells[1].Value?.ToString(); // Sử dụng tên mới: txt_HoTen

                // 3. Giới Tính (Cột 2)
                string gender = row.Cells[2].Value?.ToString();
                if (gender == "Nam")
                {
                    radiobtn_Nam.Checked = true;
                    radiobtn_Nu.Checked = false;
                }
                else if (gender == "Nữ")
                {
                    radiobtn_Nu.Checked = true;
                    radiobtn_Nam.Checked = false;
                }

                // 4. Điểm Trung Bình (Cột 3)
                txt_DTB.Text = row.Cells[3].Value?.ToString();

                // 5. Khoa (Cột 4)
                combobox_chuyennganh.Text = row.Cells[4].Value?.ToString();

                // Vô hiệu hóa MSSV khi click để sẵn sàng cho chế độ Sửa
                txt_MSSV.Enabled = false;
            }
        }

        // =========================================================
        // CÁC HÀM TEXT CHANGED / CHECKED CHANGED / CLICK KHÁC
        // =========================================================

        private void txt_MSSV_TextChanged(object sender, EventArgs e)
        {
            // Cho phép ô MSSV chỉnh sửa khi người dùng gõ
            txt_MSSV.Enabled = true;
        }

        private void txt_HoTen_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện thay đổi Họ Tên (txt_HoTen)
        }

        private void radiobtn_Nam_CheckedChanged(object sender, EventArgs e)
        {
            // Không cần logic ở đây.
        }

        private void radiobtn_Nu_CheckedChanged(object sender, EventArgs e)
        {
            // Không cần logic ở đây.
        }

        private void txt_DTB_TextChanged(object sender, EventArgs e)
        {
            // Không cần logic ở đây.
        }

        private void txt_TongNam_TextChanged(object sender, EventArgs e)
        {
            // TextBox hiển thị tổng SV Nam (Output).
        }

        private void txt_TongNu_TextChanged(object sender, EventArgs e)
        {
            // TextBox hiển thị tổng SV Nữ (Output).
        }
    }
}