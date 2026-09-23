using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCalculator : Form
    {
        double soThuNhat = 0;
        string phepTinh = "";

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            txtDisplay.Text += btn.Text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "")
                return;

            soThuNhat = double.Parse(txtDisplay.Text);
            phepTinh = btn.Text;

            txtDisplay.Clear();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
                return;

            double soThuHai = double.Parse(txtDisplay.Text);
            double ketQua = 0;

            switch (phepTinh)
            {
                case "+":
                    ketQua = soThuNhat + soThuHai;
                    break;

                case "-":
                    ketQua = soThuNhat - soThuHai;
                    break;

                case "*":
                    ketQua = soThuNhat * soThuHai;
                    break;

                case "/":
                    if (soThuHai == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!");
                        return;
                    }

                    ketQua = soThuNhat / soThuHai;
                    break;
            }

            txtDisplay.Text = ketQua.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            soThuNhat = 0;
            phepTinh = "";
        }
    }
}