using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace listnhac
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnMusic_Click(object sender, EventArgs e)
        {
            //butoon nhạc
            tab.SelectedTab = tabMusic;
            LoadMusic();
        }
        private void btnVideo_Click(object sender, EventArgs e)
        {
            //button video
            tab.SelectedTab = tabVideos;
            LoadVideos();
        }
        private void LoadMusic()
        {
            // Implement loading music logic
        }

        private void LoadVideos()
        {
            // Implement loading videos logic
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cmbSort.SelectedItem.ToString();
            SortMedia(sortOption);
        }

        private void frmMedia_Load(object sender, EventArgs e)
        {
            cmbSort.Items.AddRange(new string[] { "Sort by A-Z", "Sort by Z-A" });
            cmbSort.SelectedItem = "Sort by A-Z";
        }
        private void SortMedia(string option)
        {
            // Implement media sorting logic based on option
            if (option == "Sort by A-Z")
            {
                // Sort logic for A-Z
            }
            else if (option == "Sort by Z-A")
            {
                // Sort logic for Z-A
            }
        }

        private void tabVideos_Click(object sender, EventArgs e)
        {

        }
    }
}
