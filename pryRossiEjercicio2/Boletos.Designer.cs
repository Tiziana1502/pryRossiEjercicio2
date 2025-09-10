namespace pryRossiEjercicio2
{
    partial class Boletos
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
            lblDistancia = new Label();
            txtDistancia = new TextBox();
            lblDias = new Label();
            nudDias = new NumericUpDown();
            lstResultado = new ListBox();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            SuspendLayout();
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(51, 46);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(55, 15);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(137, 46);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(100, 23);
            txtDistancia.TabIndex = 1;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(51, 96);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(80, 15);
            lblDias.TabIndex = 2;
            lblDias.Text = "Cantidad Días";
            // 
            // nudDias
            // 
            nudDias.Location = new Point(137, 94);
            nudDias.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(100, 23);
            nudDias.TabIndex = 3;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(51, 209);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(186, 64);
            lstResultado.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(162, 332);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Boletos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lstResultado);
            Controls.Add(nudDias);
            Controls.Add(lblDias);
            Controls.Add(txtDistancia);
            Controls.Add(lblDistancia);
            Name = "Boletos";
            Text = "BOLETOS FERRO";
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistancia;
        private TextBox txtDistancia;
        private Label lblDias;
        private NumericUpDown nudDias;
        private ListBox lstResultado;
        private Button btnCalcular;
    }
}
