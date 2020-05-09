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

namespace CoToZaPlik
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblFileName.Text = String.Empty;
            listFileInfo.Items.Clear();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                //wybrano plik
                lblFileName.Text = ofdFile.FileName;

                FileInfo fileInfo = new FileInfo(ofdFile.FileName);
                listFileInfo.Items.Add("nazwa: "+fileInfo.Name);
                listFileInfo.Items.Add("rozmiar: " + fileInfo.Length);
                listFileInfo.Items.Add("folder: " + fileInfo.DirectoryName);
                listFileInfo.Items.Add("rozszerzenie: " + fileInfo.Extension);
                listFileInfo.Items.Add("atrybuty: " + fileInfo.Attributes.ToString());
                listFileInfo.Items.Add("data utworzenia: " + fileInfo.CreationTime.ToString());
                listFileInfo.Items.Add("czas dostępu: " + fileInfo.LastAccessTime.ToString());
                listFileInfo.Items.Add("czas modyfikacji: " + fileInfo.LastWriteTime.ToString());

            }

        }
    }
}
