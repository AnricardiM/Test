namespace Test
{
    partial class Inicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Mensaje = new System.Windows.Forms.Label();
            this.btn_MA = new System.Windows.Forms.Button();
            this.btn_CD = new System.Windows.Forms.Button();
            this.btn_HV = new System.Windows.Forms.Button();
            this.btn_DB = new System.Windows.Forms.Button();
            this.dgv_auto = new System.Windows.Forms.DataGridView();
            this.dgv_centro = new System.Windows.Forms.DataGridView();
            this.dgv_venta = new System.Windows.Forms.DataGridView();
            this.cbx_auto = new System.Windows.Forms.ComboBox();
            this.cbx_centro = new System.Windows.Forms.ComboBox();
            this.lbl_auto = new System.Windows.Forms.Label();
            this.lbl_centro = new System.Windows.Forms.Label();
            this.tbx_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.pl_venta = new System.Windows.Forms.Panel();
            this.lbl_IC = new System.Windows.Forms.Label();
            this.lbl_IA = new System.Windows.Forms.Label();
            this.pl_dashboard = new System.Windows.Forms.Panel();
            this.lbl_PC1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_TNV = new System.Windows.Forms.Label();
            this.lbl_TC4 = new System.Windows.Forms.Label();
            this.lbl_TC3 = new System.Windows.Forms.Label();
            this.lbl_TC2 = new System.Windows.Forms.Label();
            this.lbl_TC1 = new System.Windows.Forms.Label();
            this.lbl_TV = new System.Windows.Forms.Label();
            this.lbl_LV = new System.Windows.Forms.Label();
            this.pl_centro = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pl_auto = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PC2 = new System.Windows.Forms.Label();
            this.lbl_PC3 = new System.Windows.Forms.Label();
            this.lbl_PC4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_auto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_centro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venta)).BeginInit();
            this.pl_venta.SuspendLayout();
            this.pl_dashboard.SuspendLayout();
            this.pl_centro.SuspendLayout();
            this.pl_auto.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Mensaje
            // 
            this.Lbl_Mensaje.AutoSize = true;
            this.Lbl_Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mensaje.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Mensaje.Location = new System.Drawing.Point(18, 8);
            this.Lbl_Mensaje.Name = "Lbl_Mensaje";
            this.Lbl_Mensaje.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Mensaje.TabIndex = 0;
            // 
            // btn_MA
            // 
            this.btn_MA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MA.Location = new System.Drawing.Point(12, 24);
            this.btn_MA.Name = "btn_MA";
            this.btn_MA.Size = new System.Drawing.Size(99, 23);
            this.btn_MA.TabIndex = 1;
            this.btn_MA.Text = "Autos";
            this.btn_MA.UseVisualStyleBackColor = true;
            this.btn_MA.Click += new System.EventHandler(this.btn_MA_Click);
            // 
            // btn_CD
            // 
            this.btn_CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CD.Location = new System.Drawing.Point(117, 24);
            this.btn_CD.Name = "btn_CD";
            this.btn_CD.Size = new System.Drawing.Size(99, 23);
            this.btn_CD.TabIndex = 2;
            this.btn_CD.Text = "Centros";
            this.btn_CD.UseVisualStyleBackColor = true;
            this.btn_CD.Click += new System.EventHandler(this.btn_CD_Click);
            // 
            // btn_HV
            // 
            this.btn_HV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HV.Location = new System.Drawing.Point(222, 24);
            this.btn_HV.Name = "btn_HV";
            this.btn_HV.Size = new System.Drawing.Size(99, 23);
            this.btn_HV.TabIndex = 3;
            this.btn_HV.Text = "Hacer Venta";
            this.btn_HV.UseVisualStyleBackColor = true;
            this.btn_HV.Click += new System.EventHandler(this.btn_HV_Click);
            // 
            // btn_DB
            // 
            this.btn_DB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DB.Location = new System.Drawing.Point(329, 24);
            this.btn_DB.Name = "btn_DB";
            this.btn_DB.Size = new System.Drawing.Size(99, 23);
            this.btn_DB.TabIndex = 4;
            this.btn_DB.Text = "Dashboard";
            this.btn_DB.UseVisualStyleBackColor = true;
            this.btn_DB.Click += new System.EventHandler(this.btn_DB_Click);
            // 
            // dgv_auto
            // 
            this.dgv_auto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_auto.Location = new System.Drawing.Point(16, 31);
            this.dgv_auto.Name = "dgv_auto";
            this.dgv_auto.Size = new System.Drawing.Size(374, 354);
            this.dgv_auto.TabIndex = 5;
            // 
            // dgv_centro
            // 
            this.dgv_centro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_centro.Location = new System.Drawing.Point(9, 37);
            this.dgv_centro.Name = "dgv_centro";
            this.dgv_centro.Size = new System.Drawing.Size(395, 364);
            this.dgv_centro.TabIndex = 6;
            // 
            // dgv_venta
            // 
            this.dgv_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_venta.Location = new System.Drawing.Point(9, 198);
            this.dgv_venta.Name = "dgv_venta";
            this.dgv_venta.Size = new System.Drawing.Size(387, 187);
            this.dgv_venta.TabIndex = 7;
            // 
            // cbx_auto
            // 
            this.cbx_auto.FormattingEnabled = true;
            this.cbx_auto.Location = new System.Drawing.Point(9, 25);
            this.cbx_auto.Name = "cbx_auto";
            this.cbx_auto.Size = new System.Drawing.Size(155, 21);
            this.cbx_auto.TabIndex = 8;
            this.cbx_auto.SelectedIndexChanged += new System.EventHandler(this.cbx_auto_SelectedIndexChanged);
            this.cbx_auto.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbx_auto_Format);
            // 
            // cbx_centro
            // 
            this.cbx_centro.FormattingEnabled = true;
            this.cbx_centro.Location = new System.Drawing.Point(179, 25);
            this.cbx_centro.Name = "cbx_centro";
            this.cbx_centro.Size = new System.Drawing.Size(146, 21);
            this.cbx_centro.TabIndex = 9;
            this.cbx_centro.SelectedIndexChanged += new System.EventHandler(this.cbx_centro_SelectedIndexChanged);
            this.cbx_centro.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbx_centro_Format);
            // 
            // lbl_auto
            // 
            this.lbl_auto.AutoSize = true;
            this.lbl_auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auto.Location = new System.Drawing.Point(13, 9);
            this.lbl_auto.Name = "lbl_auto";
            this.lbl_auto.Size = new System.Drawing.Size(39, 13);
            this.lbl_auto.TabIndex = 10;
            this.lbl_auto.Text = "Autos";
            // 
            // lbl_centro
            // 
            this.lbl_centro.AutoSize = true;
            this.lbl_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_centro.Location = new System.Drawing.Point(176, 9);
            this.lbl_centro.Name = "lbl_centro";
            this.lbl_centro.Size = new System.Drawing.Size(44, 13);
            this.lbl_centro.TabIndex = 11;
            this.lbl_centro.Text = "Centro";
            // 
            // tbx_descripcion
            // 
            this.tbx_descripcion.Location = new System.Drawing.Point(9, 75);
            this.tbx_descripcion.Name = "tbx_descripcion";
            this.tbx_descripcion.Size = new System.Drawing.Size(276, 20);
            this.tbx_descripcion.TabIndex = 12;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(13, 59);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(129, 13);
            this.lbl_descripcion.TabIndex = 13;
            this.lbl_descripcion.Text = "Informacion Adicional";
            // 
            // btn_comprar
            // 
            this.btn_comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.Location = new System.Drawing.Point(315, 141);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(75, 23);
            this.btn_comprar.TabIndex = 14;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // pl_venta
            // 
            this.pl_venta.Controls.Add(this.lbl_IC);
            this.pl_venta.Controls.Add(this.lbl_IA);
            this.pl_venta.Controls.Add(this.cbx_auto);
            this.pl_venta.Controls.Add(this.btn_comprar);
            this.pl_venta.Controls.Add(this.lbl_auto);
            this.pl_venta.Controls.Add(this.tbx_descripcion);
            this.pl_venta.Controls.Add(this.lbl_descripcion);
            this.pl_venta.Controls.Add(this.lbl_centro);
            this.pl_venta.Controls.Add(this.cbx_centro);
            this.pl_venta.Location = new System.Drawing.Point(21, 60);
            this.pl_venta.Name = "pl_venta";
            this.pl_venta.Size = new System.Drawing.Size(407, 401);
            this.pl_venta.TabIndex = 15;
            this.pl_venta.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_venta_Paint);
            // 
            // lbl_IC
            // 
            this.lbl_IC.AutoSize = true;
            this.lbl_IC.Location = new System.Drawing.Point(25, 159);
            this.lbl_IC.Name = "lbl_IC";
            this.lbl_IC.Size = new System.Drawing.Size(0, 13);
            this.lbl_IC.TabIndex = 16;
            // 
            // lbl_IA
            // 
            this.lbl_IA.AutoSize = true;
            this.lbl_IA.Location = new System.Drawing.Point(25, 128);
            this.lbl_IA.Name = "lbl_IA";
            this.lbl_IA.Size = new System.Drawing.Size(0, 13);
            this.lbl_IA.TabIndex = 15;
            // 
            // pl_dashboard
            // 
            this.pl_dashboard.Controls.Add(this.lbl_PC4);
            this.pl_dashboard.Controls.Add(this.lbl_PC3);
            this.pl_dashboard.Controls.Add(this.lbl_PC2);
            this.pl_dashboard.Controls.Add(this.lbl_PC1);
            this.pl_dashboard.Controls.Add(this.label6);
            this.pl_dashboard.Controls.Add(this.label5);
            this.pl_dashboard.Controls.Add(this.label4);
            this.pl_dashboard.Controls.Add(this.label3);
            this.pl_dashboard.Controls.Add(this.lbl_TNV);
            this.pl_dashboard.Controls.Add(this.lbl_TC4);
            this.pl_dashboard.Controls.Add(this.lbl_TC3);
            this.pl_dashboard.Controls.Add(this.lbl_TC2);
            this.pl_dashboard.Controls.Add(this.lbl_TC1);
            this.pl_dashboard.Controls.Add(this.lbl_TV);
            this.pl_dashboard.Controls.Add(this.lbl_LV);
            this.pl_dashboard.Controls.Add(this.dgv_venta);
            this.pl_dashboard.Location = new System.Drawing.Point(21, 60);
            this.pl_dashboard.Name = "pl_dashboard";
            this.pl_dashboard.Size = new System.Drawing.Size(407, 407);
            this.pl_dashboard.TabIndex = 16;
            // 
            // lbl_PC1
            // 
            this.lbl_PC1.AutoSize = true;
            this.lbl_PC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PC1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_PC1.Location = new System.Drawing.Point(3, 59);
            this.lbl_PC1.Name = "lbl_PC1";
            this.lbl_PC1.Size = new System.Drawing.Size(41, 13);
            this.lbl_PC1.TabIndex = 19;
            this.lbl_PC1.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(198, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(198, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(3, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "label1";
            // 
            // lbl_TNV
            // 
            this.lbl_TNV.AutoSize = true;
            this.lbl_TNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TNV.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TNV.Location = new System.Drawing.Point(9, 388);
            this.lbl_TNV.Name = "lbl_TNV";
            this.lbl_TNV.Size = new System.Drawing.Size(41, 13);
            this.lbl_TNV.TabIndex = 14;
            this.lbl_TNV.Text = "label1";
            // 
            // lbl_TC4
            // 
            this.lbl_TC4.AutoSize = true;
            this.lbl_TC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TC4.ForeColor = System.Drawing.Color.Green;
            this.lbl_TC4.Location = new System.Drawing.Point(198, 98);
            this.lbl_TC4.Name = "lbl_TC4";
            this.lbl_TC4.Size = new System.Drawing.Size(41, 13);
            this.lbl_TC4.TabIndex = 13;
            this.lbl_TC4.Text = "label1";
            // 
            // lbl_TC3
            // 
            this.lbl_TC3.AutoSize = true;
            this.lbl_TC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TC3.ForeColor = System.Drawing.Color.Green;
            this.lbl_TC3.Location = new System.Drawing.Point(198, 15);
            this.lbl_TC3.Name = "lbl_TC3";
            this.lbl_TC3.Size = new System.Drawing.Size(41, 13);
            this.lbl_TC3.TabIndex = 12;
            this.lbl_TC3.Text = "label1";
            // 
            // lbl_TC2
            // 
            this.lbl_TC2.AutoSize = true;
            this.lbl_TC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TC2.ForeColor = System.Drawing.Color.Green;
            this.lbl_TC2.Location = new System.Drawing.Point(3, 98);
            this.lbl_TC2.Name = "lbl_TC2";
            this.lbl_TC2.Size = new System.Drawing.Size(41, 13);
            this.lbl_TC2.TabIndex = 11;
            this.lbl_TC2.Text = "label1";
            // 
            // lbl_TC1
            // 
            this.lbl_TC1.AutoSize = true;
            this.lbl_TC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TC1.ForeColor = System.Drawing.Color.Green;
            this.lbl_TC1.Location = new System.Drawing.Point(3, 15);
            this.lbl_TC1.Name = "lbl_TC1";
            this.lbl_TC1.Size = new System.Drawing.Size(41, 13);
            this.lbl_TC1.TabIndex = 10;
            this.lbl_TC1.Text = "label1";
            // 
            // lbl_TV
            // 
            this.lbl_TV.AutoSize = true;
            this.lbl_TV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TV.ForeColor = System.Drawing.Color.Green;
            this.lbl_TV.Location = new System.Drawing.Point(179, 388);
            this.lbl_TV.Name = "lbl_TV";
            this.lbl_TV.Size = new System.Drawing.Size(41, 13);
            this.lbl_TV.TabIndex = 9;
            this.lbl_TV.Text = "label1";
            // 
            // lbl_LV
            // 
            this.lbl_LV.AutoSize = true;
            this.lbl_LV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LV.Location = new System.Drawing.Point(13, 182);
            this.lbl_LV.Name = "lbl_LV";
            this.lbl_LV.Size = new System.Drawing.Size(103, 13);
            this.lbl_LV.TabIndex = 8;
            this.lbl_LV.Text = "Listado de Venta";
            // 
            // pl_centro
            // 
            this.pl_centro.Controls.Add(this.label2);
            this.pl_centro.Controls.Add(this.dgv_centro);
            this.pl_centro.Location = new System.Drawing.Point(21, 60);
            this.pl_centro.Name = "pl_centro";
            this.pl_centro.Size = new System.Drawing.Size(410, 407);
            this.pl_centro.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Listado de Centros";
            // 
            // pl_auto
            // 
            this.pl_auto.Controls.Add(this.label1);
            this.pl_auto.Controls.Add(this.dgv_auto);
            this.pl_auto.Location = new System.Drawing.Point(21, 60);
            this.pl_auto.Name = "pl_auto";
            this.pl_auto.Size = new System.Drawing.Size(410, 407);
            this.pl_auto.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Listado de Autos";
            // 
            // lbl_PC2
            // 
            this.lbl_PC2.AutoSize = true;
            this.lbl_PC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PC2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_PC2.Location = new System.Drawing.Point(3, 146);
            this.lbl_PC2.Name = "lbl_PC2";
            this.lbl_PC2.Size = new System.Drawing.Size(41, 13);
            this.lbl_PC2.TabIndex = 20;
            this.lbl_PC2.Text = "label1";
            // 
            // lbl_PC3
            // 
            this.lbl_PC3.AutoSize = true;
            this.lbl_PC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PC3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_PC3.Location = new System.Drawing.Point(198, 59);
            this.lbl_PC3.Name = "lbl_PC3";
            this.lbl_PC3.Size = new System.Drawing.Size(41, 13);
            this.lbl_PC3.TabIndex = 21;
            this.lbl_PC3.Text = "label1";
            this.lbl_PC3.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbl_PC4
            // 
            this.lbl_PC4.AutoSize = true;
            this.lbl_PC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PC4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_PC4.Location = new System.Drawing.Point(198, 146);
            this.lbl_PC4.Name = "lbl_PC4";
            this.lbl_PC4.Size = new System.Drawing.Size(41, 13);
            this.lbl_PC4.TabIndex = 22;
            this.lbl_PC4.Text = "label1";
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 479);
            this.Controls.Add(this.btn_DB);
            this.Controls.Add(this.btn_HV);
            this.Controls.Add(this.btn_CD);
            this.Controls.Add(this.btn_MA);
            this.Controls.Add(this.Lbl_Mensaje);
            this.Controls.Add(this.pl_venta);
            this.Controls.Add(this.pl_centro);
            this.Controls.Add(this.pl_dashboard);
            this.Controls.Add(this.pl_auto);
            this.Name = "Inicial";
            this.Text = "Fabrica - Test";
            this.Load += new System.EventHandler(this.Inicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_auto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_centro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venta)).EndInit();
            this.pl_venta.ResumeLayout(false);
            this.pl_venta.PerformLayout();
            this.pl_dashboard.ResumeLayout(false);
            this.pl_dashboard.PerformLayout();
            this.pl_centro.ResumeLayout(false);
            this.pl_centro.PerformLayout();
            this.pl_auto.ResumeLayout(false);
            this.pl_auto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Mensaje;
        private System.Windows.Forms.Button btn_MA;
        private System.Windows.Forms.Button btn_CD;
        private System.Windows.Forms.Button btn_HV;
        private System.Windows.Forms.Button btn_DB;
        private System.Windows.Forms.DataGridView dgv_auto;
        private System.Windows.Forms.DataGridView dgv_centro;
        private System.Windows.Forms.DataGridView dgv_venta;
        private System.Windows.Forms.ComboBox cbx_auto;
        private System.Windows.Forms.ComboBox cbx_centro;
        private System.Windows.Forms.Label lbl_auto;
        private System.Windows.Forms.Label lbl_centro;
        private System.Windows.Forms.TextBox tbx_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Panel pl_venta;
        private System.Windows.Forms.Panel pl_dashboard;
        private System.Windows.Forms.Panel pl_centro;
        private System.Windows.Forms.Panel pl_auto;
        private System.Windows.Forms.Label lbl_TV;
        private System.Windows.Forms.Label lbl_LV;
        private System.Windows.Forms.Label lbl_TC2;
        private System.Windows.Forms.Label lbl_TC3;
        private System.Windows.Forms.Label lbl_TC4;
        private System.Windows.Forms.Label lbl_IA;
        private System.Windows.Forms.Label lbl_IC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_TNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_TC1;
        private System.Windows.Forms.Label lbl_PC1;
        private System.Windows.Forms.Label lbl_PC4;
        private System.Windows.Forms.Label lbl_PC3;
        private System.Windows.Forms.Label lbl_PC2;
    }
}

