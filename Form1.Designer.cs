namespace Proyecto_Final_Cumbre
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
            menuStrip1 = new MenuStrip();
            abelNumerosToolStripMenuItem = new ToolStripMenuItem();
            numerosToolStripMenuItem = new ToolStripMenuItem();
            mayorNumeroToolStripMenuItem = new ToolStripMenuItem();
            sumaparesToolStripMenuItem = new ToolStripMenuItem();
            moverMayorAlFinalToolStripMenuItem = new ToolStripMenuItem();
            numeroOrdenadoToolStripMenuItem = new ToolStripMenuItem();
            contadorCantImparToolStripMenuItem = new ToolStripMenuItem();
            creandootraRamaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { abelNumerosToolStripMenuItem, creandootraRamaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // abelNumerosToolStripMenuItem
            // 
            abelNumerosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { numerosToolStripMenuItem });
            abelNumerosToolStripMenuItem.Name = "abelNumerosToolStripMenuItem";
            abelNumerosToolStripMenuItem.Size = new Size(100, 20);
            abelNumerosToolStripMenuItem.Text = "Abel(Numeros)";
            // 
            // numerosToolStripMenuItem
            // 
            numerosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mayorNumeroToolStripMenuItem, sumaparesToolStripMenuItem, moverMayorAlFinalToolStripMenuItem, numeroOrdenadoToolStripMenuItem, contadorCantImparToolStripMenuItem });
            numerosToolStripMenuItem.Name = "numerosToolStripMenuItem";
            numerosToolStripMenuItem.Size = new Size(180, 22);
            numerosToolStripMenuItem.Text = "Numeros";
            // 
            // mayorNumeroToolStripMenuItem
            // 
            mayorNumeroToolStripMenuItem.Name = "mayorNumeroToolStripMenuItem";
            mayorNumeroToolStripMenuItem.Size = new Size(193, 22);
            mayorNumeroToolStripMenuItem.Text = "Mayor_Numero";
            mayorNumeroToolStripMenuItem.Click += mayorNumeroToolStripMenuItem_Click;
            // 
            // sumaparesToolStripMenuItem
            // 
            sumaparesToolStripMenuItem.Name = "sumaparesToolStripMenuItem";
            sumaparesToolStripMenuItem.Size = new Size(193, 22);
            sumaparesToolStripMenuItem.Text = "Suma_pares";
            sumaparesToolStripMenuItem.Click += sumaparesToolStripMenuItem_Click;
            // 
            // moverMayorAlFinalToolStripMenuItem
            // 
            moverMayorAlFinalToolStripMenuItem.Name = "moverMayorAlFinalToolStripMenuItem";
            moverMayorAlFinalToolStripMenuItem.Size = new Size(193, 22);
            moverMayorAlFinalToolStripMenuItem.Text = "Mover_Mayor_Al_Final";
            moverMayorAlFinalToolStripMenuItem.Click += moverMayorAlFinalToolStripMenuItem_Click;
            // 
            // numeroOrdenadoToolStripMenuItem
            // 
            numeroOrdenadoToolStripMenuItem.Name = "numeroOrdenadoToolStripMenuItem";
            numeroOrdenadoToolStripMenuItem.Size = new Size(193, 22);
            numeroOrdenadoToolStripMenuItem.Text = "Numero_Ordenado";
            numeroOrdenadoToolStripMenuItem.Click += numeroOrdenadoToolStripMenuItem_Click;
            // 
            // contadorCantImparToolStripMenuItem
            // 
            contadorCantImparToolStripMenuItem.Name = "contadorCantImparToolStripMenuItem";
            contadorCantImparToolStripMenuItem.Size = new Size(193, 22);
            contadorCantImparToolStripMenuItem.Text = "Contador_Cant_Impar";
            contadorCantImparToolStripMenuItem.Click += contadorCantImparToolStripMenuItem_Click;
            // 
            // creandootraRamaToolStripMenuItem
            // 
            creandootraRamaToolStripMenuItem.Name = "creandootraRamaToolStripMenuItem";
            creandootraRamaToolStripMenuItem.Size = new Size(125, 20);
            creandootraRamaToolStripMenuItem.Text = "Creando_otra_Rama";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem abelNumerosToolStripMenuItem;
        private ToolStripMenuItem numerosToolStripMenuItem;
        private ToolStripMenuItem mayorNumeroToolStripMenuItem;
        private ToolStripMenuItem sumaparesToolStripMenuItem;
        private ToolStripMenuItem moverMayorAlFinalToolStripMenuItem;
        private ToolStripMenuItem numeroOrdenadoToolStripMenuItem;
        private ToolStripMenuItem contadorCantImparToolStripMenuItem;
        private ToolStripMenuItem creandootraRamaToolStripMenuItem;
    }
}
