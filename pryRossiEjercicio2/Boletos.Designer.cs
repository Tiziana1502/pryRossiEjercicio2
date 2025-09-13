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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boletos));
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
            lblDistancia.Location = new Point(58, 61);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(70, 20);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(157, 61);
            txtDistancia.Margin = new Padding(3, 4, 3, 4);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(77, 27);
            txtDistancia.TabIndex = 1;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(58, 128);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(102, 20);
            lblDias.TabIndex = 2;
            lblDias.Text = "Cantidad Días";
            // 
            // nudDias
            // 
            nudDias.Location = new Point(157, 126);
            nudDias.Margin = new Padding(3, 4, 3, 4);
            nudDias.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(77, 27);
            nudDias.TabIndex = 3;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.Location = new Point(53, 214);
            lstResultado.Margin = new Padding(3, 4, 3, 4);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(212, 84);
            lstResultado.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(255, 128, 128);
            btnCalcular.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.ControlLightLight;
            btnCalcular.Location = new Point(157, 331);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(108, 34);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // Boletos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 419);
            Controls.Add(btnCalcular);
            Controls.Add(lstResultado);
            Controls.Add(nudDias);
            Controls.Add(lblDias);
            Controls.Add(txtDistancia);
            Controls.Add(lblDistancia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
