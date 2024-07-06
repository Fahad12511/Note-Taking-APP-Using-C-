namespace Note_Taking_APP
{
    partial class NoteTaking
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
            titlebox = new TextBox();
            notebox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            previousNotes = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // titlebox
            // 
            titlebox.Location = new Point(501, 42);
            titlebox.Multiline = true;
            titlebox.Name = "titlebox";
            titlebox.Size = new Size(534, 45);
            titlebox.TabIndex = 0;
            titlebox.TextChanged += textBox1_TextChanged;
            // 
            // notebox
            // 
            notebox.Location = new Point(501, 132);
            notebox.Multiline = true;
            notebox.Name = "notebox";
            notebox.Size = new Size(534, 473);
            notebox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(501, 9);
            label1.Name = "label1";
            label1.Size = new Size(534, 39);
            label1.TabIndex = 2;
            label1.Text = "Title :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(501, 90);
            label2.Name = "label2";
            label2.Size = new Size(534, 39);
            label2.TabIndex = 3;
            label2.Text = "Note :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // previousNotes
            // 
            previousNotes.AccessibleRole = AccessibleRole.None;
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(12, 42);
            previousNotes.Name = "previousNotes";
            previousNotes.RowHeadersWidth = 62;
            previousNotes.Size = new Size(475, 408);
            previousNotes.TabIndex = 4;
            previousNotes.CellContentClick += dataGridView1_CellContentClick;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(33, 466);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 5;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(33, 547);
            button2.Name = "button2";
            button2.Size = new Size(200, 50);
            button2.TabIndex = 9;
            button2.Text = "New Note";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(276, 466);
            button3.Name = "button3";
            button3.Size = new Size(200, 50);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(276, 547);
            button4.Name = "button4";
            button4.Size = new Size(200, 50);
            button4.TabIndex = 11;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // NoteTaking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1047, 617);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(previousNotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(notebox);
            Controls.Add(titlebox);
            Name = "NoteTaking";
            Text = "Notes Taking ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titlebox;
        private TextBox notebox;
        private Label label1;
        private Label label2;
        private DataGridView previousNotes;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
