namespace WinFormsApp1
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
            textBoxOutputMath = new TextBox();
            textBoxInputInitialGuess = new TextBox();
            textBoxOutput = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            buttonOutputMath = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            buttonIterToOutput = new Button();
            buttonOutput = new Button();
            groupBox5 = new GroupBox();
            labelOutput = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(9, 22);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 0;
            textBoxInput.Leave += textBoxInput_Leave;
            // 
            // textBoxOutputMath
            // 
            textBoxOutputMath.Location = new Point(6, 35);
            textBoxOutputMath.Name = "textBoxOutputMath";
            textBoxOutputMath.Size = new Size(318, 23);
            textBoxOutputMath.TabIndex = 1;
            // 
            // textBoxInputInitialGuess
            // 
            textBoxInputInitialGuess.Location = new Point(6, 22);
            textBoxInputInitialGuess.Name = "textBoxInputInitialGuess";
            textBoxInputInitialGuess.Size = new Size(100, 23);
            textBoxInputInitialGuess.TabIndex = 2;
            textBoxInputInitialGuess.Leave += textBoxInputInitialGuess_Leave;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(6, 22);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(470, 23);
            textBoxOutput.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(textBoxInput);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 96);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Введите число";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(224, 224, 224);
            groupBox2.Controls.Add(textBoxOutputMath);
            groupBox2.Controls.Add(buttonOutputMath);
            groupBox2.Location = new Point(306, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(482, 96);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вычисление библиотекой Math";
            // 
            // buttonOutputMath
            // 
            buttonOutputMath.Location = new Point(330, 27);
            buttonOutputMath.Name = "buttonOutputMath";
            buttonOutputMath.Size = new Size(146, 36);
            buttonOutputMath.TabIndex = 4;
            buttonOutputMath.Text = "Вычислить";
            buttonOutputMath.UseVisualStyleBackColor = true;
            buttonOutputMath.Click += buttonOutputMath_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(224, 224, 224);
            groupBox3.Controls.Add(textBoxInputInitialGuess);
            groupBox3.Location = new Point(12, 114);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(251, 96);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Введите начальное приближение";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(224, 224, 224);
            groupBox4.Controls.Add(buttonIterToOutput);
            groupBox4.Controls.Add(buttonOutput);
            groupBox4.Controls.Add(textBoxOutput);
            groupBox4.Location = new Point(306, 114);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(482, 96);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Вычисление методом Ньютона";
            // 
            // buttonIterToOutput
            // 
            buttonIterToOutput.Location = new Point(330, 51);
            buttonIterToOutput.Name = "buttonIterToOutput";
            buttonIterToOutput.Size = new Size(146, 36);
            buttonIterToOutput.TabIndex = 6;
            buttonIterToOutput.Text = "Сделать итерацию";
            buttonIterToOutput.UseVisualStyleBackColor = true;
            buttonIterToOutput.Click += buttonIterToOutput_Click;
            // 
            // buttonOutput
            // 
            buttonOutput.Location = new Point(6, 51);
            buttonOutput.Name = "buttonOutput";
            buttonOutput.Size = new Size(146, 36);
            buttonOutput.TabIndex = 5;
            buttonOutput.Text = "Вычислить";
            buttonOutput.UseVisualStyleBackColor = true;
            buttonOutput.Click += buttonOutput_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(224, 224, 224);
            groupBox5.Controls.Add(labelOutput);
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(12, 268);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(776, 170);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Метод Ньютона";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOutput.Location = new Point(6, 19);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(0, 21);
            labelOutput.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxInput;
        private TextBox textBoxOutputMath;
        private TextBox textBoxInputInitialGuess;
        private TextBox textBoxOutput;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonOutputMath;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button buttonIterToOutput;
        private Button buttonOutput;
        private GroupBox groupBox5;
        private Label labelOutput;
    }
}