namespace task3
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
            textBoxInput = new TextBox();
            button_convert = new Button();
            labelOutput = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 13);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(109, 23);
            textBoxInput.TabIndex = 0;
            textBoxInput.Leave += textBoxInput_Leave;
            // 
            // button_convert
            // 
            button_convert.Location = new Point(235, 11);
            button_convert.Name = "button_convert";
            button_convert.Size = new Size(109, 24);
            button_convert.TabIndex = 1;
            button_convert.Text = "Конвертировать";
            button_convert.UseVisualStyleBackColor = true;
            button_convert.Click += button_convert_Click;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelOutput.Location = new Point(6, 10);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(109, 25);
            labelOutput.TabIndex = 2;
            labelOutput.Text = "В двоичной";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(labelOutput);
            groupBox1.Location = new Point(12, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 113);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 180);
            Controls.Add(button_convert);
            Controls.Add(textBoxInput);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button button_convert;
        private Label labelOutput;
        private GroupBox groupBox1;
    }
}