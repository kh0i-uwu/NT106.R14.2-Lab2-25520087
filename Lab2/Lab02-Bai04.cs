using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;

namespace Lab2
{

    public partial class Lab02_Bai04 : Form
    {
        private List<SinhVien> danhSachSV = new List<SinhVien>();

        private List<SinhVien> danhSachDoc = new List<SinhVien>();

        private int currentIndex = 0;

        public Lab02_Bai04()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("input4.txt"))
                {
                    MessageBox.Show("File input4.txt không tồn tại! Hãy bấm Write to a File trước.", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string jsonInput = File.ReadAllText("input4.txt");
                danhSachDoc = JsonSerializer.Deserialize<List<SinhVien>>(jsonInput);

                if (danhSachDoc == null || danhSachDoc.Count == 0)
                {
                    MessageBox.Show("File input4.txt không có dữ liệu sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                foreach (var sv in danhSachDoc)
                {
                    sv.DiemTB = (sv.DiemMon1 + sv.DiemMon2 + sv.DiemMon3) / 3.0f;
                }


                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonOutput = JsonSerializer.Serialize(danhSachDoc, options);
                File.WriteAllText("output4.txt", jsonOutput);


                rtbContent.Text = jsonOutput;


                currentIndex = 0;
                HienThiSinhVien(currentIndex);

                MessageBox.Show("Đã đọc file, tính điểm trung bình và xuất kết quả ra file output4.txt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xử lý file: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiSinhVien(int index)
        {
            if (danhSachDoc == null || index < 0 || index >= danhSachDoc.Count) return;

            SinhVien sv = danhSachDoc[index];
            txbReadName.Text = sv.HoTen;
            txbReadID.Text = sv.MSSV.ToString();
            txbReadPhone.Text = sv.DienThoai;
            txbReadCourse1.Text = sv.DiemMon1.ToString();
            txbReadCourse2.Text = sv.DiemMon2.ToString();
            txbReadCourse3.Text = sv.DiemMon3.ToString();


            txbReadAverage.Text = Math.Round(sv.DiemTB, 2).ToString();


            lblPage.Text = $"{index + 1} / {danhSachDoc.Count}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (!int.TryParse(txbAddID.Text.Trim(), out int mssv) || txbAddID.Text.Trim().Length != 8)
                {
                    MessageBox.Show("Mã số sinh viên phải là số nguyên có đúng 8 chữ số!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbAddID.Focus();
                    return;
                }


                string phone = txbAddPhone.Text.Trim();
                if (phone.Length != 10 || !phone.StartsWith("0") || !long.TryParse(phone, out _))
                {
                    MessageBox.Show("Số điện thoại phải có đúng 10 chữ số và bắt đầu bằng số 0!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbAddPhone.Focus();
                    return;
                }


                if (!float.TryParse(txbAddCourse1.Text.Trim(), out float d1) || d1 < 0 || d1 > 10 ||
                    !float.TryParse(txbAddCourse2.Text.Trim(), out float d2) || d2 < 0 || d2 > 10 ||
                    !float.TryParse(txbAddCourse3.Text.Trim(), out float d3) || d3 < 0 || d3 > 10)
                {
                    MessageBox.Show("Điểm các môn phải là số thực từ 0 đến 10!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                SinhVien sv = new SinhVien(txbAddName.Text.Trim(), mssv, phone, d1, d2, d3);
                danhSachSV.Add(sv);

                MessageBox.Show($"Đã thêm sinh viên {sv.HoTen} vào danh sách tạm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ClearAddInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAddInputs()
        {
            txbAddName.Clear();
            txbAddID.Clear();
            txbAddPhone.Clear();
            txbAddCourse1.Clear();
            txbAddCourse2.Clear();
            txbAddCourse3.Clear();
            txbAddAverage.Clear();
            txbAddName.Focus();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (danhSachSV.Count == 0)
            {
                MessageBox.Show("Danh sách tạm đang rỗng, hãy bấm Add để thêm ít nhất 1 sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(danhSachSV, options);


                File.WriteAllText("input4.txt", jsonString);

                MessageBox.Show("Đã ghi thành công danh sách sinh viên vào file input4.txt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (danhSachDoc != null && currentIndex > 0)
            {
                currentIndex--;
                HienThiSinhVien(currentIndex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (danhSachDoc != null && currentIndex < danhSachDoc.Count - 1)
            {
                currentIndex++;
                HienThiSinhVien(currentIndex);
            }
        }
    }

    public class SinhVien
    {
        public string HoTen { get; set; }
        public int MSSV { get; set; }
        public string DienThoai { get; set; }
        public float DiemMon1 { get; set; }
        public float DiemMon2 { get; set; }
        public float DiemMon3 { get; set; }
        public float DiemTB { get; set; }

        public SinhVien() { }

        public SinhVien(string hoTen, int mssv, string dienThoai, float d1, float d2, float d3)
        {
            HoTen = hoTen;
            MSSV = mssv;
            DienThoai = dienThoai;
            DiemMon1 = d1;
            DiemMon2 = d2;
            DiemMon3 = d3;
            DiemTB = 0;
        }
    }
}
