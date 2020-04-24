namespace tree
{
    partial class Form1
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
            MetroSuite.MetroPicturebox.MainColorScheme mainColorScheme5 = new MetroSuite.MetroPicturebox.MainColorScheme();
            this.time = new MetroFramework.Controls.MetroDateTime();
            this.metroLabelHeader1 = new MetroSuite.MetroLabelHeader();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDetalle = new MetroFramework.Controls.MetroListView();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMonto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnResumen = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialFlatButton();
            this.metroPicturebox1 = new MetroSuite.MetroPicturebox();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.time.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.time.CalendarTrailingForeColor = System.Drawing.Color.Lime;
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time.Location = new System.Drawing.Point(129, 197);
            this.time.MinimumSize = new System.Drawing.Size(0, 29);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(113, 29);
            this.time.Style = MetroFramework.MetroColorStyle.White;
            this.time.TabIndex = 3;
            this.time.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabelHeader1
            // 
            this.metroLabelHeader1.AutoSize = true;
            this.metroLabelHeader1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.metroLabelHeader1.ForeColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(240)))));
            this.metroLabelHeader1.ForeColorNormal = System.Drawing.Color.Black;
            this.metroLabelHeader1.Location = new System.Drawing.Point(383, 42);
            this.metroLabelHeader1.Name = "metroLabelHeader1";
            this.metroLabelHeader1.Size = new System.Drawing.Size(193, 30);
            this.metroLabelHeader1.TabIndex = 7;
            this.metroLabelHeader1.Text = "Control de Facturas";
            this.metroLabelHeader1.UseHoverMode = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Numero de factura";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Monto facturado";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha de factura";
            this.columnHeader4.Width = 129;
            // 
            // lvDetalle
            // 
            this.lvDetalle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDetalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDetalle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvDetalle.FullRowSelect = true;
            this.lvDetalle.GridLines = true;
            this.lvDetalle.Location = new System.Drawing.Point(256, 99);
            this.lvDetalle.Name = "lvDetalle";
            this.lvDetalle.OwnerDraw = true;
            this.lvDetalle.Size = new System.Drawing.Size(497, 195);
            this.lvDetalle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lvDetalle.TabIndex = 6;
            this.lvDetalle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lvDetalle.UseCompatibleStateImageBehavior = false;
            this.lvDetalle.UseSelectable = true;
            this.lvDetalle.View = System.Windows.Forms.View.Details;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(24, 247);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(74, 36);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(10, 149);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(113, 23);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Depth = 0;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Hint = "Monto facturado";
            this.txtMonto.Location = new System.Drawing.Point(129, 149);
            this.txtMonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.SelectedText = "";
            this.txtMonto.SelectionLength = 0;
            this.txtMonto.SelectionStart = 0;
            this.txtMonto.Size = new System.Drawing.Size(121, 23);
            this.txtMonto.TabIndex = 15;
            this.txtMonto.UseSystemPasswordChar = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Depth = 0;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Hint = "Numero factura";
            this.txtNumero.Location = new System.Drawing.Point(10, 203);
            this.txtNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.Size = new System.Drawing.Size(113, 23);
            this.txtNumero.TabIndex = 16;
            this.txtNumero.UseSystemPasswordChar = false;
            // 
            // btnResumen
            // 
            this.btnResumen.AutoSize = true;
            this.btnResumen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResumen.Depth = 0;
            this.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumen.Location = new System.Drawing.Point(129, 247);
            this.btnResumen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResumen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Primary = false;
            this.btnResumen.Size = new System.Drawing.Size(104, 36);
            this.btnResumen.TabIndex = 17;
            this.btnResumen.Text = "Ver resumen";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(605, 292);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(74, 36);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(687, 292);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Primary = false;
            this.btnLimpiar.Size = new System.Drawing.Size(66, 36);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // metroPicturebox1
            // 
            mainColorScheme5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme5.GlowAnimationColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(240)))));
            mainColorScheme5.GlowColor = System.Drawing.Color.Black;
            mainColorScheme5.PictureboxColor = System.Drawing.Color.White;
            mainColorScheme5.TextboxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme5.TextboxColor = System.Drawing.Color.White;
            this.metroPicturebox1.ColorScheme = mainColorScheme5;
            this.metroPicturebox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroPicturebox1.ForeColor = System.Drawing.Color.Black;
            this.metroPicturebox1.GlowFeather = 38;
            this.metroPicturebox1.Image = global::tree.Properties.Resources.construtecnic_02;
            this.metroPicturebox1.ImageMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.metroPicturebox1.Location = new System.Drawing.Point(10, 8);
            this.metroPicturebox1.Name = "metroPicturebox1";
            this.metroPicturebox1.Size = new System.Drawing.Size(232, 102);
            this.metroPicturebox1.TabIndex = 8;
            this.metroPicturebox1.Text = "metroPicturebox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 336);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lvDetalle);
            this.Controls.Add(this.metroPicturebox1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.metroLabelHeader1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.97D;
            this.Resizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime time;
        private MetroSuite.MetroLabelHeader metroLabelHeader1;
        private MetroSuite.MetroPicturebox metroPicturebox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMonto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumero;
        private MaterialSkin.Controls.MaterialFlatButton btnResumen;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnLimpiar;
        public MetroFramework.Controls.MetroListView lvDetalle;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
    }
}