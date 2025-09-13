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
            btnCalcular = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            SuspendLayout();
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Font = new Font("Segoe UI", 10.2F);
            lblDistancia.Location = new Point(33, 54);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(79, 23);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(155, 54);
            txtDistancia.Margin = new Padding(3, 4, 3, 4);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(77, 27);
            txtDistancia.TabIndex = 1;
            txtDistancia.TextChanged += txtDistancia_TextChanged;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Font = new Font("Segoe UI", 10.2F);
            lblDias.Location = new Point(33, 121);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(116, 23);
            lblDias.TabIndex = 2;
            lblDias.Text = "Cantidad Días";
            // 
            // nudDias
            // 
            nudDias.Enabled = false;
            nudDias.Location = new Point(155, 121);
            nudDias.Margin = new Padding(3, 4, 3, 4);
            nudDias.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(77, 27);
            nudDias.TabIndex = 3;
            nudDias.ValueChanged += nudDias_ValueChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(255, 128, 128);
            btnCalcular.Enabled = false;
            btnCalcular.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.ControlLightLight;
            btnCalcular.Location = new Point(136, 197);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(108, 34);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(22, 197);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Boletos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 292);
            Controls.Add(btnCancelar);
            Controls.Add(btnCalcular);
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
        private Button btnCalcular;
        private Button btnCancelar;
    }
}
