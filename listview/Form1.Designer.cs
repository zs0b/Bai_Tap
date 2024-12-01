namespace baitap_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView = new ListView();
            column_MSSV = new ColumnHeader();
            Column_Name = new ColumnHeader();
            Column_Age = new ColumnHeader();
            txtmssv = new TextBox();
            txtname = new TextBox();
            txtage = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_add = new Button();
            button_del = new Button();
            button_update = new Button();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { column_MSSV, Column_Name, Column_Age });
            listView.Location = new Point(40, 24);
            listView.Name = "listView";
            listView.Size = new Size(276, 414);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // column_MSSV
            // 
            column_MSSV.Text = "MSSV";
            // 
            // Column_Name
            // 
            Column_Name.Text = "Name";
            // 
            // Column_Age
            // 
            Column_Age.Text = "Age";
            // 
            // txtmssv
            // 
            txtmssv.Location = new Point(409, 24);
            txtmssv.Name = "txtmssv";
            txtmssv.Size = new Size(135, 23);
            txtmssv.TabIndex = 1;
            // 
            // txtname
            // 
            txtname.Location = new Point(409, 79);
            txtname.Name = "txtname";
            txtname.Size = new Size(135, 23);
            txtname.TabIndex = 2;
            // 
            // txtage
            // 
            txtage.Location = new Point(411, 146);
            txtage.Name = "txtage";
            txtage.Size = new Size(133, 23);
            txtage.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 27);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "MSSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 82);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 149);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "Age";
            // 
            // button_add
            // 
            button_add.Location = new Point(609, 26);
            button_add.Name = "button_add";
            button_add.Size = new Size(109, 23);
            button_add.TabIndex = 7;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_del
            // 
            button_del.Location = new Point(609, 82);
            button_del.Name = "button_del";
            button_del.Size = new Size(109, 23);
            button_del.TabIndex = 8;
            button_del.Text = "Delete";
            button_del.UseVisualStyleBackColor = true;
            button_del.Click += button_del_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(609, 149);
            button_update.Name = "button_update";
            button_update.Size = new Size(109, 23);
            button_update.TabIndex = 9;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_update);
            Controls.Add(button_del);
            Controls.Add(button_add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtage);
            Controls.Add(txtname);
            Controls.Add(txtmssv);
            Controls.Add(listView);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView;
        private TextBox txtmssv;
        private TextBox txtname;
        private TextBox txtage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_add;
        private Button button_del;
        private Button button_update;
        private ColumnHeader column_MSSV;
        private ColumnHeader Column_Name;
        private ColumnHeader Column_Age;
    }
}
