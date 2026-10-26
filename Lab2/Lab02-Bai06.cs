using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02_Bai06 : Form
    {
        private string dbFileName = "HomNayAnGi.db";
        private string connectionString => $"Data Source={dbFileName};Version=3;";

        public Lab02_Bai06()
        {
            InitializeComponent();
        }

        private void Lab02_Bai06_Load(object sender, EventArgs e)
        {

            KhoiTaoCSDL();


            HienThiDanhSachMonAn();
        }


        private void KhoiTaoCSDL()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // 1. Tự động tạo bảng NguoiDung nếu chưa có
                string sqlNguoiDung = @"
            CREATE TABLE IF NOT EXISTS NguoiDung (
                IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                HoVaTen TEXT NOT NULL,
                QuyenHan TEXT
            );";

                // 2. Tự động tạo bảng MonAn nếu chưa có
                string sqlMonAn = @"
            CREATE TABLE IF NOT EXISTS MonAn (
                IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                TenMonAn TEXT NOT NULL,
                HinhAnh TEXT,
                IDNCC INTEGER,
                FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC)
            );";

                using (SQLiteCommand cmd1 = new SQLiteCommand(sqlNguoiDung, conn)) cmd1.ExecuteNonQuery();
                using (SQLiteCommand cmd2 = new SQLiteCommand(sqlMonAn, conn)) cmd2.ExecuteNonQuery();

                // 3. Kiểm tra nếu bảng MonAn đang rỗng thì mới nạp dữ liệu mẫu
                string checkQuery = "SELECT COUNT(*) FROM MonAn;";
                using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
                {
                    long count = (long)checkCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        string insertUsers = @"
                    INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES 
                    ('Nguyễn Văn A', 'User'),
                    ('Trần Thị B', 'User'),
                    ('Lê Văn C', 'Admin');";
                        using (SQLiteCommand cmdU = new SQLiteCommand(insertUsers, conn)) cmdU.ExecuteNonQuery();

                        string insertDishes = @"
                    INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES 
                    ('Bún riêu', 'bunrieu.jpg', 1),
                    ('Bún thịt nướng', 'bunthitnuong.jpg', 2),
                    ('Cơm tấm sườn trứng', 'comtam.jpg', 1),
                    ('Phở bò', 'pho.jpg', 3),
                    ('Gỏi cuốn', 'goicuon.jpg', 2);";
                        using (SQLiteCommand cmdM = new SQLiteCommand(insertDishes, conn)) cmdM.ExecuteNonQuery();
                    }
                }
            }
        }


        private void HienThiDanhSachMonAn()
        {
            lvMonAn.Items.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();


                string query = @"
                    SELECT MonAn.IDMA, MonAn.TenMonAn, MonAn.HinhAnh, NguoiDung.HoVaTen 
                    FROM MonAn 
                    INNER JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["IDMA"].ToString());
                            item.SubItems.Add(reader["TenMonAn"].ToString());
                            item.SubItems.Add(reader["HinhAnh"].ToString());
                            item.SubItems.Add(reader["HoVaTen"].ToString());

                            lvMonAn.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();


                string query = @"
                    SELECT MonAn.TenMonAn, MonAn.HinhAnh, NguoiDung.HoVaTen 
                    FROM MonAn 
                    INNER JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC 
                    ORDER BY RANDOM() LIMIT 1;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tenMon = reader["TenMonAn"].ToString();
                            string hinhAnh = reader["HinhAnh"].ToString();
                            string nguoiDongGop = reader["HoVaTen"].ToString();


                            lblTenMonAn.Text = "Món ăn: " + tenMon;
                            lblNguoiDongGop.Text = "Đóng góp bởi: " + nguoiDongGop;


                            if (File.Exists(hinhAnh))
                            {
                                picMonAn.Image = Image.FromFile(hinhAnh);
                            }
                            else
                            {
                                picMonAn.Image = null;
                            }
                        }
                    }
                }
            }
        }
    }
}
