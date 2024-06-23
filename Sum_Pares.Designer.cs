namespace Proyecto_Final_Cumbre
{
    partial class Sum_Pares
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(134, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 142);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 3;
            label1.Text = "Esperando resultado....";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(300, 24);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 4;
            label2.Text = "SUMAR PARES";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(324, 225);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(124, 58);
            button1.TabIndex = 5;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Sum_Pares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Sum_Pares";
            Text = "Sum_Pares";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}