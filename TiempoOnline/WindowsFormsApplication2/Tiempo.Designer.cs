namespace WindowsFormsApplication2
{
    partial class Tiempo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TextPais = new System.Windows.Forms.Label();
            this.TextCiudad = new System.Windows.Forms.Label();
            this.BotonConsultar = new System.Windows.Forms.Button();
            this.ComboCiudades = new System.Windows.Forms.ComboBox();
            this.ComboPaises = new System.Windows.Forms.ComboBox();
            this.getWeatherCompletedEventArgsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridResultado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.getWeatherCompletedEventArgsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // TextPais
            // 
            this.TextPais.AutoSize = true;
            this.TextPais.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TextPais.Location = new System.Drawing.Point(9, 43);
            this.TextPais.Name = "TextPais";
            this.TextPais.Size = new System.Drawing.Size(32, 15);
            this.TextPais.TabIndex = 0;
            this.TextPais.Text = "Pais";
            this.TextPais.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextCiudad
            // 
            this.TextCiudad.AutoSize = true;
            this.TextCiudad.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCiudad.Location = new System.Drawing.Point(9, 75);
            this.TextCiudad.Name = "TextCiudad";
            this.TextCiudad.Size = new System.Drawing.Size(47, 15);
            this.TextCiudad.TabIndex = 1;
            this.TextCiudad.Text = "Ciudad";
            this.TextCiudad.Click += new System.EventHandler(this.label2_Click);
            // 
            // BotonConsultar
            // 
            this.BotonConsultar.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BotonConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonConsultar.Location = new System.Drawing.Point(402, 39);
            this.BotonConsultar.Name = "BotonConsultar";
            this.BotonConsultar.Size = new System.Drawing.Size(116, 56);
            this.BotonConsultar.TabIndex = 4;
            this.BotonConsultar.Text = "Consultar";
            this.BotonConsultar.UseVisualStyleBackColor = true;
            this.BotonConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboCiudades
            // 
            this.ComboCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCiudades.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCiudades.FormattingEnabled = true;
            this.ComboCiudades.Location = new System.Drawing.Point(64, 71);
            this.ComboCiudades.Name = "ComboCiudades";
            this.ComboCiudades.Size = new System.Drawing.Size(209, 24);
            this.ComboCiudades.TabIndex = 6;
            // 
            // ComboPaises
            // 
            this.ComboPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPaises.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.ComboPaises.FormattingEnabled = true;
            this.ComboPaises.Location = new System.Drawing.Point(64, 39);
            this.ComboPaises.Name = "ComboPaises";
            this.ComboPaises.Size = new System.Drawing.Size(209, 24);
            this.ComboPaises.TabIndex = 7;
            this.ComboPaises.SelectedIndexChanged += new System.EventHandler(this.ComboPaises_SelectedIndexChanged);
            this.ComboPaises.SelectionChangeCommitted += new System.EventHandler(this.ComboPaises_SelectionChangeCommitted);
            // 
            // getWeatherCompletedEventArgsBindingSource
            // 
            this.getWeatherCompletedEventArgsBindingSource.DataSource = typeof(WindowsFormsApplication2.WSclima.GetWeatherCompletedEventArgs);
            // 
            // DataGridResultado
            // 
            this.DataGridResultado.AllowUserToAddRows = false;
            this.DataGridResultado.AllowUserToDeleteRows = false;
            this.DataGridResultado.AllowUserToResizeColumns = false;
            this.DataGridResultado.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            this.DataGridResultado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridResultado.Location = new System.Drawing.Point(12, 106);
            this.DataGridResultado.Name = "DataGridResultado";
            this.DataGridResultado.ReadOnly = true;
            this.DataGridResultado.RowHeadersVisible = false;
            this.DataGridResultado.Size = new System.Drawing.Size(506, 246);
            this.DataGridResultado.TabIndex = 8;
            // 
            // Tiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 362);
            this.Controls.Add(this.DataGridResultado);
            this.Controls.Add(this.ComboPaises);
            this.Controls.Add(this.ComboCiudades);
            this.Controls.Add(this.BotonConsultar);
            this.Controls.Add(this.TextCiudad);
            this.Controls.Add(this.TextPais);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tiempo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio de Tiempo en Linea";
            this.Load += new System.EventHandler(this.Tiempo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getWeatherCompletedEventArgsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextPais;
        private System.Windows.Forms.Label TextCiudad;
        private System.Windows.Forms.Button BotonConsultar;
        private System.Windows.Forms.ComboBox ComboCiudades;
        private System.Windows.Forms.ComboBox ComboPaises;
        private System.Windows.Forms.BindingSource getWeatherCompletedEventArgsBindingSource;
        private System.Windows.Forms.DataGridView DataGridResultado;
    }
}

