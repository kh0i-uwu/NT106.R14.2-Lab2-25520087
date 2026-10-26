using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Lab02_Bai05 : Form
    {
        private List<Phim> danhSachPhim = new List<Phim>();
        public Lab02_Bai05()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";
            ofd.FileName = "input5.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    danhSachPhim.Clear();
                    string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);


                    for (int i = 0; i < lines.Length; i += 3)
                    {
                        if (i + 2 < lines.Length)
                        {
                            Phim p = new Phim();
                            p.TenPhim = lines[i].Trim();
                            p.GiaChuan = double.Parse(lines[i + 1].Trim());

                            string[] phongs = lines[i + 2].Split(',');
                            foreach (var phong in phongs)
                            {
                                if (int.TryParse(phong.Trim(), out int nPhong))
                                    p.DanhSachPhong.Add(nPhong);
                            }

                            danhSachPhim.Add(p);
                        }
                    }


                    cboPhim.Items.Clear();
                    foreach (var p in danhSachPhim)
                    {
                        cboPhim.Items.Add(p.TenPhim);
                    }

                    if (cboPhim.Items.Count > 0) cboPhim.SelectedIndex = 0;

                    rtbContent.Text = File.ReadAllText(ofd.FileName, Encoding.UTF8);
                    MessageBox.Show($"Đã đọc thành công {danhSachPhim.Count} bộ phim từ file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi định dạng file input5.txt: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhim.SelectedIndex >= 0)
            {
                cboPhong.Items.Clear();
                Phim p = danhSachPhim[cboPhim.SelectedIndex];
                foreach (var phong in p.DanhSachPhong)
                {
                    cboPhong.Items.Add("Phòng " + phong);
                }
                if (cboPhong.Items.Count > 0) cboPhong.SelectedIndex = 0;
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (cboPhim.SelectedIndex < 0) return;

            Phim p = danhSachPhim[cboPhim.SelectedIndex];

            if (p.SoVeTon <= 0)
            {
                MessageBox.Show("Phim này đã hết vé tồn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            p.SoVeBanRa += 1;
            p.DoanhThu += p.GiaChuan;

            MessageBox.Show($"Bán vé thành công cho phim '{p.TenPhim}'!\nSố vé đã bán: {p.SoVeBanRa}/{p.TongSoVe}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (danhSachPhim.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu phim! Hãy bấm Đọc file trước.", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            var danhSachXepHang = danhSachPhim.OrderByDescending(p => p.DoanhThu).ToList();
            for (int i = 0; i < danhSachXepHang.Count; i++)
            {
                danhSachXepHang[i].XepHang = i + 1;
            }

           
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            
            for (int i = 1; i <= 100; i += 10)
            {
                progressBar1.Value = i;
                await Task.Delay(50); 
            }

           
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== THỐNG KÊ DOANH THU VÀ XẾP HẠNG PHÒNG VÉ ===");
            sb.AppendLine();

            foreach (var p in danhSachPhim)
            {
                sb.AppendLine($"Tên phim: {p.TenPhim}");
                sb.AppendLine($"Số lượng vé bán ra: {p.SoVeBanRa}");
                sb.AppendLine($"Số lượng vé tồn: {p.SoVeTon}");
                sb.AppendLine($"Tỉ lệ vé bán ra: {p.TiLeBanRa:F2}%");
                sb.AppendLine($"Doanh thu: {p.DoanhThu:N0} VNĐ");
                sb.AppendLine($"Xếp hạng doanh thu: {p.XepHang}");
                sb.AppendLine(new string('-', 40));
            }

           
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt";
            sfd.FileName = "output5.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                progressBar1.Value = 100;

              
                rtbContent.Text = sb.ToString();

                MessageBox.Show("Xuất file thống kê output5.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public class Phim
    {
        public string TenPhim { get; set; }
        public double GiaChuan { get; set; }
        public List<int> DanhSachPhong { get; set; } = new List<int>();
        public int SoVeBanRa { get; set; } = 0;

       
        public int TongSoVe => DanhSachPhong.Count * 15;
        public int SoVeTon => TongSoVe - SoVeBanRa;
        public double TiLeBanRa => TongSoVe > 0 ? ((double)SoVeBanRa / TongSoVe) * 100 : 0;
        public double DoanhThu { get; set; } = 0;
        public int XepHang { get; set; } = 0;
    }
}
