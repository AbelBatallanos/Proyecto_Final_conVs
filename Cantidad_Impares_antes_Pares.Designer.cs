namespace Proyecto_Final_Cumbre
{
    partial class Cantidad_Impares_antes_Pares
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            Segundo = new Label();
            Digit_Ingresados = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(479, 40);
            label1.TabIndex = 0;
            label1.Text = "Contador de impares antes de pares";
            label1.Click += this.label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(417, 363);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.Size = new Size(102, 46);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(690, 126);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 2;
            label2.Text = "Resultado";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(399, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 143);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // Segundo
            // 
            Segundo.AutoSize = true;
            Segundo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Segundo.Location = new Point(62, 129);
            Segundo.Name = "Segundo";
            Segundo.Size = new Size(211, 32);
            Segundo.TabIndex = 5;
            Segundo.Text = "Digitos Ingresados";
            // 
            // Digit_Ingresados
            // 
            Digit_Ingresados.AutoSize = true;
            Digit_Ingresados.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Digit_Ingresados.Location = new Point(113, 215);
            Digit_Ingresados.Name = "Digit_Ingresados";
            Digit_Ingresados.Size = new Size(28, 30);
            Digit_Ingresados.TabIndex = 6;
            Digit_Ingresados.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(686, 215);
            label4.Name = "label4";
            label4.Size = new Size(33, 30);
            label4.TabIndex = 7;
            label4.Text = "....";
            // 
            // Cantidad_Impares_antes_Pares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 668);
            Controls.Add(label4);
            Controls.Add(Digit_Ingresados);
            Controls.Add(Segundo);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Cantidad_Impares_antes_Pares";
            Text = "Cantidad_Impares_antes_Pares";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label Segundo;
        private Label Digit_Ingresados;
        private Label label4;
    }
}