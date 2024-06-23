namespace Proyecto_Final_Cumbre
{
    partial class Mayor_Numero_Forms
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
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(348, 176);
            label1.Name = "label1";
            label1.Size = new Size(37, 40);
            label1.TabIndex = 0;
            label1.Text = "=";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(170, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 26);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(391, 176);
            label2.Name = "label2";
            label2.Size = new Size(296, 40);
            label2.TabIndex = 2;
            label2.Text = "Esperando Resultado..";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(313, 251);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(107, 51);
            button1.TabIndex = 3;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 20);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(122, 9);
            label4.Name = "label4";
            label4.Size = new Size(541, 40);
            label4.TabIndex = 5;
            label4.Text = "ENCONTRAR EL MAYOR DE LOS DIGITOS";
            // 
            // Mayor_Numero_Forms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Mayor_Numero_Forms";
            Text = "Mayor_Numero_Forms";
            Load += Mayor_Numero_Forms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}