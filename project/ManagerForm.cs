using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class ManagerForm : Form
    {
        private Manager user;

        private List<Material> listMaterial;

        private Material currentItem = null;
        public ManagerForm(Person loginUser)
        {
            InitializeComponent();
            user = (Manager)loginUser;
            LoadMaterialData();
        }

        private void LoadMaterialData()
        {
            listMaterial = user.GetListMaterial();
            materialView.DataSource = listMaterial;
            clearData();
        }

        private void materialView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idTxt.Text = materialView.Rows[e.RowIndex].Cells["id"].Value.ToString();
                nameTxt.Text = materialView.Rows[e.RowIndex].Cells["name"].Value.ToString();
                unitTxt.Text = materialView.Rows[e.RowIndex].Cells["unit"].Value.ToString();
                amountTxt.Text = materialView.Rows[e.RowIndex].Cells["count"].Value.ToString();
                currentItem = listMaterial.FirstOrDefault(o => o.Id == Convert.ToInt32(idTxt.Text));
            }
        }

        private void clearData()
        {
            currentItem = null;
            idTxt.Text = "";
            nameTxt.Text = "";
            unitTxt.Text = "";
            amountTxt.Text = "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (currentItem != null)
            {
                int amountValue = 0;
                if (int.TryParse(amountTxt.Text, out amountValue) == true && nameTxt.Text != "" && unitTxt.Text != "")
                {
                    if (user.EditMaterial(currentItem.Id, nameTxt.Text, unitTxt.Text, Convert.ToInt32(amountTxt.Text)) == true)
                    {
                        MessageBox.Show("Đã cập nhật nguyên liệu thành công", "Thông báo");
                        LoadMaterialData();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra", "Thông báo");
                    }
                } else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo");
                }
            } else
            {
                int amountValue = 0;
                if (int.TryParse(amountTxt.Text, out amountValue) == true && nameTxt.Text != "" && unitTxt.Text != "")
                {
                    if (user.AddMaterial(nameTxt.Text, unitTxt.Text, Convert.ToInt32(amountTxt.Text)) == true)
                    {
                        MessageBox.Show("Đã thêm nguyên liệu thành công", "Thông báo");
                        LoadMaterialData();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo");
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa nguyên liệu này? \n Hãy đảm bảo không còn món nào trong menu có sử dụng nguyên liệu này trước khi xóa để tránh ảnh hưởng.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Perform delete action
                if (user.DeleteMaterial(currentItem.Id))
                {
                    MessageBox.Show("Xóa nguyên liệu thành công", "Success");
                    LoadMaterialData();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo");
                }
            }
        }
    }
}
