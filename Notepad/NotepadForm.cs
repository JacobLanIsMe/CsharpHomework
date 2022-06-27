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

namespace Notepad
{
    public partial class NotepadForm : Form
    {
        public NotepadForm()
        {
            InitializeComponent();
        }
        bool isWordWrap = true;
        string fileName = "";
        private void 開啟OCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Title = "請選擇檔案";
            dialog.Filter = "所有檔案(*.*)|*.*";
            if (dialog.ShowDialog() != DialogResult.OK) { dialog.Dispose(); return; }
            fileName = dialog.FileName;
            StreamReader sr = new StreamReader(dialog.FileName);
            textBox1.Text = sr.ReadToEnd();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() != DialogResult.OK) { colorDialog.Dispose(); return; }
            textBox1.ForeColor = colorDialog.Color;
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() != DialogResult.OK) { fontDialog.Dispose(); return; }
            textBox1.Font = fontDialog.Font;
        }

        private void toUpperUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isWordWrap = !isWordWrap;
            textBox1.WordWrap = isWordWrap;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.StartPosition = FormStartPosition.CenterScreen;
            aboutForm.Show();
            //MessageBox.Show("此版本為 Jacob Lan 在資策會的記事本作業，敬請您安心服用", "關於");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("tt hh:mm:ss");
        }

        private void NotepadForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "請選擇檔案";
            dialog.Filter = "所有檔案(*.*)|*.*";
            if (dialog.ShowDialog() != DialogResult.OK) { dialog.Dispose(); return; }
            StreamReader sr = new StreamReader(dialog.FileName);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
            fileName = dialog.FileName;
        }

        private void 複製CCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox1.SelectedText);
        }

        private void 貼上PCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insertText = (String)Clipboard.GetDataObject().GetData(DataFormats.Text);
            int selectionIndex = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(selectionIndex, insertText);
        }

        private void 剪下TCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void toolStripButtonCut_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox1.SelectedText);
        }

        private void toolStripButtonPaste_Click(object sender, EventArgs e)
        {
            string insertText = (String)Clipboard.GetDataObject().GetData(DataFormats.Text);
            int selectionIndex = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(selectionIndex, insertText);
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.StartPosition = FormStartPosition.CenterScreen;
            aboutForm.Show();
        }

        private void 儲存SCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName != "")
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.Write(textBox1.Text);
                sw.Close();
                fs.Close();
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "請選擇檔案";
                dialog.Filter = "所有檔案(*.*)|*.*";
                if (dialog.ShowDialog() != DialogResult.OK) { dialog.Dispose(); return; }
                if (dialog.FileName != "")
                {
                    FileStream fs = new FileStream(dialog.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                    sw.Write(textBox1.Text);
                    sw.Close();
                    fs.Close();
                }
                fileName = dialog.FileName;
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "請選擇檔案";
            dialog.Filter = "所有檔案(*.*)|*.*";
            if (dialog.ShowDialog() != DialogResult.OK) { dialog.Dispose(); return; }
            FileStream fs = new FileStream(dialog.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(textBox1.Text);
            sw.Close();
            fs.Close();
            if (fileName == "") fileName = dialog.FileName;
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            儲存SCtrlSToolStripMenuItem_Click(sender, e);
        }
    }
}
