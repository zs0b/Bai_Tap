using System.Xml.Linq;

namespace baitap_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtmssv.Text);
            item.SubItems.Add(txtname.Text);
            item.SubItems.Add(txtage.Text);
            listView.Items.Add(item);

            ClearInput();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                listView.Items.Remove(listView.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("pick !!");
            }

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                var a = listView.SelectedItems[0];
                a.Text = txtmssv.Text;
                a.SubItems[1].Text = txtname.Text;
                a.SubItems[2].Text = txtage.Text;

                ClearInput();
            }
            else
            {
                MessageBox.Show("pick 0.0 ");
            }

        }

        private void ClearInput()
        {
            txtmssv.Clear();
            txtname.Clear();
            txtage.Clear();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0) 
            {
                var b = listView.SelectedItems[0];
                txtmssv.Text = b.Text;
                txtname.Text = b.SubItems[1].Text;
                txtage.Text = b.SubItems[2].Text;
            }
        }
    }
}
