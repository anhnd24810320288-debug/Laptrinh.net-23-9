using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InputControls : Form
    {
        public InputControls()
        {
            InitializeComponent();

            List<Course> dsKhoaHoc = new List<Course>()
    {
        new Course("C01", "Lập trình C#"),
        new Course("J01", "Lập trình Java"),
        new Course("AN01", "An ninh mạng"),
        new Course("DB01", "Cơ sở dữ liệu")
    };

            cboCourse.DataSource = dsKhoaHoc;
            cboCourse.DisplayMember = "TenKhoa";
            cboCourse.ValueMember = "MaKhoa";
        }

        private void InputControls_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string hoTen = txtName.Text;
            string soDienThoai = mtxtPhone.Text;
            string ngaySinh = dtpBirthDate.Value.ToString("dd/MM/yyyy");

            string khoaHoc = cboCourse.Text;
            string maKhoa = cboCourse.SelectedValue.ToString();

            string gioiTinh = "";

            if (rdoMale.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdoFemale.Checked)
            {
                gioiTinh = "Nữ";
            }

            string soThich = "";

            if (chkMusic.Checked)
            {
                soThich += "Âm nhạc, ";
            }

            if (chkSport.Checked)
            {
                soThich += "Thể thao, ";
            }

            if (chkGame.Checked)
            {
                soThich += "Game, ";
            }

            string thongTin =
                "HỌ VÀ TÊN: " + hoTen +
                "\nSỐ ĐIỆN THOẠI: " + soDienThoai +
                "\nNGÀY SINH: " + ngaySinh +
                "\nKHÓA HỌC: " + khoaHoc +
                "\nMÃ KHÓA: " + maKhoa +
                "\nGIỚI TÍNH: " + gioiTinh +
                "\nSỞ THÍCH: " + soThich;

            MessageBox.Show(thongTin, "Thông tin đăng ký");
        }
    }
}
