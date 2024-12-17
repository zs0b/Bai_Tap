using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt3._2_nguyentatdat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tạoVănBảnMớiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
        }

        private void loadfont()
        {
            foreach (FontFamily fontFamily in new InstalledFontCollection().Families)
            {
                toolStripComboBox_font.Items.Add(fontFamily.Name);
            }
            toolStripComboBox_font.SelectedItem = "Tahoma";
        }

        private void loadSize()
        {
            int[] size = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            toolStripComboBox_size.ComboBox.DataSource= size;
            toolStripComboBox_size.SelectedItem = 14;
            
        }

        private void soanvawnban_load(object sender, EventArgs e)
        {
            loadfont();
            loadSize();
            RichtextBox_bangghi.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichtextBox_bangghi.Clear();
            soanvawnban_load(sender, e);
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichtextBox_bangghi.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|RichText files (*.rtf)|*.rtf";
            openFileDialog.Multiselect = false;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                string savedFilePath = openFileDialog.FileName;
                try
                {
                    if(Path.GetExtension(selectedFileName).Equals("*.txt", StringComparison.OrdinalIgnoreCase))
                    {
                        RichtextBox_bangghi.LoadFile(selectedFileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        RichtextBox_bangghi.LoadFile(selectedFileName, RichTextBoxStreamType.RichText);
                    }
                    MessageBox.Show("Mở òi á", "Thog baoooo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi gòi" + ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButton_newfile_Click(object sender, EventArgs e)
        {
            tạoVănBảnMớiToolStripMenuItem_Click(sender, e);
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text Files (*.rtf)|*.rtf",
                Title = "Luwuu"
            };

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, RichtextBox_bangghi.Text);
                MessageBox.Show("Luu xong goi", "luuu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton_savefile_Click(object sender, EventArgs e)
        {
            lưuNộiDungVănBảnToolStripMenuItem_Click((object)sender, e); 
        }

        private void toolStripButton_bold_Click(object sender, EventArgs e)
        {
            if(RichtextBox_bangghi.SelectionFont != null)
            {
                FontStyle style = RichtextBox_bangghi.SelectionFont.Style;
                if (RichtextBox_bangghi.SelectionFont.Bold)
                {
                    style &= ~FontStyle.Bold;
                }
                else
                {
                    style = FontStyle.Bold;
                }
                RichtextBox_bangghi.SelectionFont = new Font(RichtextBox_bangghi.SelectionFont, style);
            }
        }

        private void toolStripButton_Italic_Printing_Click(object sender, EventArgs e)
        {
            if(RichtextBox_bangghi.SelectionFont != null)
            {
                FontStyle style = RichtextBox_bangghi.SelectionFont.Style;
                if (RichtextBox_bangghi.SelectionFont.Italic)
                {
                    style &= ~FontStyle.Italic;
                }
                else
                {
                    style = FontStyle.Italic;
                }
                RichtextBox_bangghi.SelectionFont = new Font(RichtextBox_bangghi.SelectionFont, style);
            }
        }

        private void toolStripButton_Underline_Click(object sender, EventArgs e)
        {
            if (RichtextBox_bangghi.SelectionFont != null)
            {
                FontStyle style = RichtextBox_bangghi.SelectionFont.Style;
                if (RichtextBox_bangghi.SelectionFont.Underline)
                {
                    style &= ~FontStyle.Underline;
                }
                else
                {
                    style = FontStyle.Underline;
                }
                RichtextBox_bangghi.SelectionFont = new Font(RichtextBox_bangghi.SelectionFont, style);
            }
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            fontDialog.ShowEffects  = true;
            fontDialog.ShowHelp = true;
            if(fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                RichtextBox_bangghi.ForeColor = fontDialog.Color;
                RichtextBox_bangghi.Font = fontDialog.Font;

            }
        }

        private void toolStripComboBox_font_Click(object sender, EventArgs e)
        {
            if (RichtextBox_bangghi.SelectionFont != null)
            {
                Font currentFont = RichtextBox_bangghi.SelectionFont;
                RichtextBox_bangghi.SelectionFont = new Font(toolStripComboBox_font.SelectedItem.ToString(), currentFont.Size, currentFont.Style);
            }
        }

        private void toolStripComboBox_size_Click(object sender, EventArgs e)
        {
            if (RichtextBox_bangghi.SelectionFont != null)
            {
                Font currentFont = RichtextBox_bangghi.SelectionFont;
                RichtextBox_bangghi.SelectionFont = new Font(currentFont.FontFamily, float.Parse(toolStripComboBox_size.SelectedItem.ToString()), currentFont.Style);
            }
        }

    }
}
