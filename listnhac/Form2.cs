using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listnhac
{
    public partial class frmVideo : Form
    {
        private string[] path;
        public frmVideo()
        {
            InitializeComponent();
            path = new string[] { "track1.mp3", "track2.mp3", "track3.mp3" };
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true; // Cho phép chọn nhiều tệp

            // Xử lý lỗi và phản hồi người dùng
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Gán các đường dẫn tệp được chọn vào biến thành viên 'path'
                    path = ofd.FileNames;
                    string[] fileNames = ofd.SafeFileNames;

                    // Xóa danh sách để tránh trùng lặp
                    track_list.Items.Clear();

                    // Thêm tên tệp vào danh sách
                    foreach (string fileName in fileNames)
                    {
                        track_list.Items.Add(fileName);
                    }

                    // Tùy chọn: Hiển thị thông báo thành công
                    MessageBox.Show("Files opened successfully!");
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ một cách cẩn thận
                    MessageBox.Show("An error occurred while opening files: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (path != null && track_list.SelectedIndex >= 0 && track_list.SelectedIndex < path.Length)
            {
                player.URL = path[track_list.SelectedIndex];
                player.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Invalid file selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
