using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_dien_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            dataTable.Columns.Add("Tu", typeof(string));
            dataTable.Columns.Add("TuLoai", typeof(string));
            dataTable.Columns.Add("Nghia", typeof(string));
            dataTable.Columns.Add("ViDu", typeof(string));
        }
        DataTable dataTable = new DataTable();
        TuDien dict = new TuDien();

        private void btnThemTu_Click(object sender, EventArgs e)
        {
            // Lay noi dung nhap tu cac o textbox
            txtTu.Focus();
            string tu = txtTu.Text.Trim();
            string nghia = txtNghia.Text.Trim();
            string vidu = txtViDu.Text.Trim();
            string tuloai = txtTuLoai.Text.Trim();

            if (string.IsNullOrEmpty(tu) || string.IsNullOrEmpty(tuloai) ||
                string.IsNullOrEmpty(nghia) || string.IsNullOrEmpty(vidu))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Cảnh báo", MessageBoxButtons.OK,
MessageBoxIcon.Error);
            }
            else
            {
                TuVung TuMoi = new TuVung(tu, nghia, vidu, tuloai);
                dict.ThemTu(TuMoi);

                //Xoa noi dung cu
                txtTu.ResetText();
                txtTuLoai.ResetText();
                txtNghia.ResetText();
                txtViDu.ResetText();

                //Dua con tro ve lai textbox Tu
                txtTu.Focus();

                // Hien thi tu dien bang datagridview
                dataTable.Rows.Add(dict.GetTail().GetTuMoi().getTu(),
                    dict.GetTail().GetTuMoi().getTuLoai(), dict.GetTail().GetTuMoi().getNghia(),
                    dict.GetTail().GetTuMoi().getViDu());
                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (indexT == 0)
            {
                dict.Remove_First();
            }
            else
            {
                Node p = dict.GetHead();
                int i = 0;
                while (i < (indexT - 1))
                {
                    p = p.GetNode();
                    i += 1;
                }
                p.setNode(p.GetNode().GetNode());
                dict.SetSize(dict.getSize() - 1);
            }
         

            MessageBox.Show("Từ đã được xoá", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
            dataTable.Clear();

            Node p2 = dict.GetHead();
            while (p2 != null)
            {
                dataTable.Rows.Add(p2.GetTuMoi().getTu(),
                        p2.GetTuMoi().getTuLoai(), p2.GetTuMoi().getNghia(),
                        p2.GetTuMoi().getViDu());
                p2 = p2.GetNode();
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();
        }

        int indexT;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexT = e.RowIndex;
            if (indexT >= 0)
            {
                Node p = dict.GetHead();
                int i = 1;
                while (i <= indexT)
                {
                    p = p.GetNode();
                    i += 1;
                }
                txtTu.Text = p.GetTuMoi().getTu();
                txtTuLoai.Text = p.GetTuMoi().getTuLoai();
                txtNghia.Text = p.GetTuMoi().getNghia();
                txtViDu.Text = p.GetTuMoi().getViDu();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

            DataTable dataTemp = new DataTable();
            dataTemp.Columns.Add("Tu", typeof(string));
            dataTemp.Columns.Add("TuLoai", typeof(string));
            dataTemp.Columns.Add("Nghia", typeof(string));
            dataTemp.Columns.Add("ViDu", typeof(string));

            // Doc gia tri can tim kiem
            string value = txtFind.Text.Trim().ToLower();
            int count = 0;
            if (!string.IsNullOrEmpty(txtFind.Text))
            {
                Node p = dict.GetHead();
                int index = 0;
                while (p != null)
                {

                    if (p.GetTuMoi().getTu().ToLower().Contains(value))
                    {
                        count++;
                        dataTemp.Rows.Add(p.GetTuMoi().getTu(),
                            p.GetTuMoi().getTuLoai(), p.GetTuMoi().getNghia(),
                            p.GetTuMoi().getViDu());
                    }
                    else
                    {
                        index += 1;
                    }
                    p = p.GetNode();
                }

                if (count > 0)
                {
                    dataGridView1.DataSource = dataTemp;
                    dataGridView1.Refresh();
                }
            }
            else
            {
                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();
            }
            
        }

        private void btnCapNhatTu_Click(object sender, EventArgs e)
        {
            string tu = txtTu.Text.Trim();
            string nghia = txtNghia.Text.Trim();
            string vidu = txtViDu.Text.Trim();
            string tuloai = txtTuLoai.Text.Trim();


            if (string.IsNullOrEmpty(tu) || string.IsNullOrEmpty(tuloai) ||
                string.IsNullOrEmpty(nghia) || string.IsNullOrEmpty(vidu))
            {
                MessageBox.Show("Vui lòng nhập lại đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OKCancel,
MessageBoxIcon.Error);
            }
            else
            {
                TuVung TuMoi = new TuVung(tu, nghia, vidu, tuloai);
                Node p = dict.GetHead();
                int i = 0;
                while (i < (indexT))
                {
                    p = p.GetNode();
                    i += 1;
                }
                p.SetTuMoi(TuMoi);
                dataTable.Clear();

                Node p2 = dict.GetHead();
                while (p2 != null)
                {
                    dataTable.Rows.Add(p2.GetTuMoi().getTu(),
                            p2.GetTuMoi().getTuLoai(), p2.GetTuMoi().getNghia(),
                            p2.GetTuMoi().getViDu());
                    p2 = p2.GetNode();
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();
            }
        }

        private void btnDocFromTxt_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader("D:\\NAM_BA\\HocKy1\\OOP\\CuoiKy\\BaoCao\\BaoCao\\data.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            string tu = parts[0].Trim();
                            string nghia = parts[1].Trim();
                            string vidu = parts[2].Trim();
                            string tuloai = parts[3].Trim();

                            TuVung tuVung = new TuVung(tu, nghia, vidu,tuloai);
                            dict.ThemTu(tuVung);
                        }
                    }
                }

                MessageBox.Show("File được đọc thành công", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                dataTable.Clear();

                Node p2 = dict.GetHead();
                while (p2 != null)
                {
                    dataTable.Rows.Add(p2.GetTuMoi().getTu(),
                            p2.GetTuMoi().getTuLoai(), p2.GetTuMoi().getNghia(),
                            p2.GetTuMoi().getViDu());
                    p2 = p2.GetNode();
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File không tồn tại", "Cảnh báo", MessageBoxButtons.OKCancel,
MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Cảnh báo", MessageBoxButtons.OKCancel,
MessageBoxIcon.Error);
            }
        }

        private void btnSaveToTxT_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("D:\\NAM_BA\\HocKy1\\OOP\\CuoiKy\\BaoCao\\ditc.txt"))
            {
                Node p = dict.GetHead();
                while (p != null)
                {
                    TuVung tu = p.GetTuMoi();
                    string line = $"{tu.getTu()}, {tu.getNghia()}, {tu.getViDu()},{tu.getTuLoai()}";
                    writer.WriteLine(line);
                    p = p.GetNode();
                }
                MessageBox.Show("Từ điển đã được lưu về file thành công", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
            }
        }
    }
}
