using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Girls : Form
    {

        private SoundPlayer Player = new SoundPlayer();

        public Girls()
        {
            InitializeComponent();
        }

        private void Girls_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tableDanceDataSet.Chicas' table. You can move, or remove it, as needed.
            this.chicasTableAdapter.Fill(this.tableDanceDataSet.Chicas);
            text_InPagination();
        }

        private void btnFisrt_Click(object sender, EventArgs e)
        {
            chicasBindingSource.Position = 0;
            text_InPagination();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int girlCount = chicasBindingSource.Count;
            if (chicasBindingSource.Position <= girlCount)
            {
                chicasBindingSource.Position += 1;
            }
            text_InPagination();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (chicasBindingSource.Position > 0)
            {
                chicasBindingSource.Position -= 1;
            }
            text_InPagination();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int girlCount = chicasBindingSource.Count;
            chicasBindingSource.Position = girlCount;
            text_InPagination();
        }

        private void text_InPagination()
        {
            Player.Stop();
            int actual = chicasBindingSource.Position + 1;
            txtPagination.Text = actual.ToString() + "/" + chicasBindingSource.Count;
            try
            {
                string fileName = actual + ".wav";
                string path = Path.Combine(Environment.CurrentDirectory, fileName);

                Debug.WriteLine(Environment.CurrentDirectory);
                Player.SoundLocation = path;
                Player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }
        }
    }
}
