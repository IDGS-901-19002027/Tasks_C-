namespace repaso
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
            label1 = new Label();
            btnClose = new Button();
            txt_title = new TextBox();
            cmb_priority = new ComboBox();
            button1 = new Button();
            txt_description = new TextBox();
            table_tasks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)table_tasks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(300, 45);
            label1.Name = "label1";
            label1.Size = new Size(225, 50);
            label1.TabIndex = 0;
            label1.Text = "List of tasks";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.AppWorkspace;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(701, 527);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 35);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txt_title
            // 
            txt_title.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_title.Location = new Point(151, 119);
            txt_title.MaxLength = 50;
            txt_title.Name = "txt_title";
            txt_title.PlaceholderText = "Title";
            txt_title.Size = new Size(494, 27);
            txt_title.TabIndex = 2;
            txt_title.TextAlign = HorizontalAlignment.Center;
            // 
            // cmb_priority
            // 
            cmb_priority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_priority.FlatStyle = FlatStyle.Popup;
            cmb_priority.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_priority.FormattingEnabled = true;
            cmb_priority.Location = new Point(151, 170);
            cmb_priority.Name = "cmb_priority";
            cmb_priority.Size = new Size(494, 28);
            cmb_priority.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(367, 311);
            button1.Name = "button1";
            button1.Size = new Size(91, 36);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_description
            // 
            txt_description.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_description.Location = new Point(151, 215);
            txt_description.MaxLength = 300;
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.PlaceholderText = "Description";
            txt_description.Size = new Size(494, 75);
            txt_description.TabIndex = 5;
            txt_description.TextAlign = HorizontalAlignment.Center;
            // 
            // table_tasks
            // 
            table_tasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_tasks.Location = new Point(151, 380);
            table_tasks.Name = "table_tasks";
            table_tasks.RowTemplate.Height = 25;
            table_tasks.Size = new Size(494, 150);
            table_tasks.TabIndex = 6;
            table_tasks.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 585);
            Controls.Add(table_tasks);
            Controls.Add(txt_description);
            Controls.Add(button1);
            Controls.Add(cmb_priority);
            Controls.Add(txt_title);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)table_tasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnClose;
        private TextBox txt_title;
        private ComboBox cmb_priority;
        private Button button1;
        private TextBox txt_description;
        private DataGridView table_tasks;
    }
}