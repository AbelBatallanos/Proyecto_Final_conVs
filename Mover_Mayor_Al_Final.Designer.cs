namespace Proyecto_Final_Cumbre
{
    partial class Mover_Mayor_Al_Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mover_Mayor_Al_Final));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(316, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 26);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 9);
            label1.Name = "label1";
            label1.Size = new Size(495, 32);
            label1.TabIndex = 3;
            label1.Text = "MOVER EL MAYOR DIGITO AL ULTIMO LUGAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(284, 154);
            label2.Name = "label2";
            label2.Size = new Size(213, 20);
            label2.TabIndex = 4;
            label2.Text = "INGRESE DIGITOS NUMERICOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 94);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 5;
            label3.Text = "VALOR INGRESADO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(663, 94);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 154);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 7;
            label5.Text = "esperando...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(612, 154);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 8;
            label6.Text = "esperando...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(603, 89);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 9;
            label7.Text = "Resultado Final";
            // 
            // button1
            // 
            button1.Location = new Point(347, 274);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.Location = new Point(316, 279);
            label8.Name = "label8";
            label8.Padding = new Padding(300, 200, 300, 200);
            label8.Size = new Size(638, 413);
            label8.TabIndex = 11;
            label8.Text = "label8";
            // 
            // Mover_Mayor_Al_Final
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 671);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Name = "Mover_Mayor_Al_Final";
            Text = "Mover_Mayor_Al_Final";
            Load += Mover_Mayor_Al_Final_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label8;
    }
}