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

namespace mppFileHandler
{
    public partial class formMain : Form
    {
        private String _folder1Path = "";
        private Pipeline _pipeline;

        public formMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            _pipeline = new Pipeline(this.lblPrevisualisation);
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.ShowDialog();

            String path = folderBrowserDialog.SelectedPath;

            if (path != null && path.Trim().Length != 0)
            {
                this.labelFolder1.Text = path;
                _folder1Path = path;
            }
        }

        private void chkDateCreation_CheckedChanged(object sender, EventArgs e)
        {
            _pipeline.WithCreationDate = this.chkDateCreation.Checked;
        }

        private void chkCustomText_CheckedChanged(object sender, EventArgs e)
        {
            _pipeline.WithCustomText = this.chkCustomText.Checked;

            this.txtCustomBox.Enabled = this.chkCustomText.Checked;
        }

        private void txtCustomBox_TextChanged(object sender, EventArgs e)
        {
            _pipeline.CustomText = this.txtCustomBox.Text;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var excludedExtensions = this.excludedFiles.Text.Split(';');
            if (_folder1Path != null && _folder1Path.Length > 1)
            {
                DirectoryInfo folder = new DirectoryInfo(@_folder1Path);
                FileInfo[] infos = folder.GetFiles();
                
                this.loader.Maximum = infos.Length;
                this.loader.Value = 1;
                this.loader.Step = 1;
                foreach (FileInfo f in infos)
                {
                    if (excludedExtensions.Any(x => x.ToUpper().Equals(f.Extension.Replace(".", "").ToUpper()))) {
                        f.MoveTo(Path.Combine(f.Directory.FullName, _pipeline.transformText(f)));
                    }

                    this.loader.PerformStep();
                }
            }

            this.labelFolder1.Text = "";
            _folder1Path = "";
        }
    }
}
