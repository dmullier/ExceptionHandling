namespace ExceptionHandling
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
            button1 = new Button();
            Num1Input = new TextBox();
            Num2Input = new TextBox();
            ResultBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(49, 144);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "divide";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Num1Input
            // 
            Num1Input.Location = new Point(48, 53);
            Num1Input.Name = "Num1Input";
            Num1Input.Size = new Size(125, 27);
            Num1Input.TabIndex = 1;
            // 
            // Num2Input
            // 
            Num2Input.Location = new Point(235, 53);
            Num2Input.Name = "Num2Input";
            Num2Input.Size = new Size(125, 27);
            Num2Input.TabIndex = 2;
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(424, 53);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(125, 27);
            ResultBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 56);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 4;
            label1.Text = "/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 56);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 5;
            label2.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ResultBox);
            Controls.Add(Num2Input);
            Controls.Add(Num1Input);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Exception Handling";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Num1Input;
        private TextBox Num2Input;
        private TextBox ResultBox;
        private Label label1;
        private Label label2;
    }
}
