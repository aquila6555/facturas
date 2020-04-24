namespace tree
{
    partial class Form2
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
            MetroSuite.MetroButton.MainColorScheme mainColorScheme1 = new MetroSuite.MetroButton.MainColorScheme();
            this.lbFacturas = new MaterialSkin.Controls.MaterialLabel();
            this.lbVendido = new MaterialSkin.Controls.MaterialLabel();
            this.lbComision = new MaterialSkin.Controls.MaterialLabel();
            this.lbNombre = new MaterialSkin.Controls.MaterialLabel();
            this.metroButton1 = new MetroSuite.MetroButton();
            this.SuspendLayout();
            // 
            // lbFacturas
            // 
            this.lbFacturas.AutoSize = true;
            this.lbFacturas.Depth = 0;
            this.lbFacturas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbFacturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFacturas.Location = new System.Drawing.Point(24, 71);
            this.lbFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbFacturas.Name = "lbFacturas";
            this.lbFacturas.Size = new System.Drawing.Size(107, 19);
            this.lbFacturas.TabIndex = 1;
            this.lbFacturas.Text = "Total facturas:";
            // 
            // lbVendido
            // 
            this.lbVendido.AutoSize = true;
            this.lbVendido.Depth = 0;
            this.lbVendido.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbVendido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbVendido.Location = new System.Drawing.Point(24, 102);
            this.lbVendido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbVendido.Name = "lbVendido";
            this.lbVendido.Size = new System.Drawing.Size(104, 19);
            this.lbVendido.TabIndex = 2;
            this.lbVendido.Text = "Total vendido:";
            // 
            // lbComision
            // 
            this.lbComision.AutoSize = true;
            this.lbComision.Depth = 0;
            this.lbComision.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbComision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbComision.Location = new System.Drawing.Point(23, 133);
            this.lbComision.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(129, 19);
            this.lbComision.TabIndex = 3;
            this.lbComision.Text = "Comision de 10%:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Depth = 0;
            this.lbNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNombre.Location = new System.Drawing.Point(161, 33);
            this.lbNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(63, 19);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre";
            // 
            // metroButton1
            // 
            mainColorScheme1.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(240)))));
            mainColorScheme1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme1.FillColor = System.Drawing.Color.White;
            mainColorScheme1.HoverFillColor = System.Drawing.Color.White;
            mainColorScheme1.PressAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            mainColorScheme1.PressFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.metroButton1.ColorScheme = mainColorScheme1;
            this.metroButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton1.ForeColor = System.Drawing.Color.Black;
            this.metroButton1.Location = new System.Drawing.Point(75, 165);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(105, 27);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Mostrar";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 215);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbComision);
            this.Controls.Add(this.lbVendido);
            this.Controls.Add(this.lbFacturas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Resumen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lbVendido;
        private MaterialSkin.Controls.MaterialLabel lbComision;
        private MetroSuite.MetroButton metroButton1;
        public MaterialSkin.Controls.MaterialLabel lbFacturas;
        public MaterialSkin.Controls.MaterialLabel lbNombre;
    }
}