namespace wild_hog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cascadia Code", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(582, 20);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "File path";
            // 
            // button1
            // 
            button1.Location = new Point(316, 61);
            button1.Name = "button1";
            button1.Size = new Size(278, 220);
            button1.TabIndex = 2;
            button1.Text = "Hog";
            button1.UseVisualStyleBackColor = true;
            button1.MouseDown += button1_MouseDown;
            button1.MouseUp += button1_MouseUp;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(123, 149);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Autohog";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(606, 292);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Wild Hog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private CheckBox checkBox1;
    }
}
