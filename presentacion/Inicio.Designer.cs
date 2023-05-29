namespace presentacion
{
    partial class Inicio
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
            button1 = new Button();
            agregar = new Button();
            borrar = new Button();
            actualizar = new Button();
            buscar = new Button();
            HoraFin = new TextBox();
            label5 = new Label();
            HoraIni = new TextBox();
            label4 = new Label();
            txtPropietario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cbtipo = new ComboBox();
            label1 = new Label();
            txtPlaca = new TextBox();
            datos = new DataGridView();
            label6 = new Label();
            placa = new TextBox();
            idbo = new TextBox();
            label7 = new Label();
            label9 = new Label();
            idPlaca = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)datos).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(932, 394);
            button1.Name = "button1";
            button1.Size = new Size(81, 44);
            button1.TabIndex = 0;
            button1.Text = "CERRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // agregar
            // 
            agregar.Location = new Point(111, 301);
            agregar.Name = "agregar";
            agregar.Size = new Size(81, 26);
            agregar.TabIndex = 1;
            agregar.Text = "AGREGAR";
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // borrar
            // 
            borrar.Location = new Point(461, 409);
            borrar.Name = "borrar";
            borrar.Size = new Size(88, 26);
            borrar.TabIndex = 2;
            borrar.Text = "BORRAR";
            borrar.UseVisualStyleBackColor = true;
            borrar.Click += borrar_Click;
            // 
            // actualizar
            // 
            actualizar.Location = new Point(181, 401);
            actualizar.Name = "actualizar";
            actualizar.Size = new Size(88, 23);
            actualizar.TabIndex = 3;
            actualizar.Text = "ACTUALIZAR";
            actualizar.UseVisualStyleBackColor = true;
            actualizar.Click += actualizar_Click;
            // 
            // buscar
            // 
            buscar.Location = new Point(846, 394);
            buscar.Name = "buscar";
            buscar.Size = new Size(80, 44);
            buscar.TabIndex = 4;
            buscar.Text = "LIMPIAR CASILLAS";
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // HoraFin
            // 
            HoraFin.Location = new Point(176, 262);
            HoraFin.Name = "HoraFin";
            HoraFin.Size = new Size(82, 23);
            HoraFin.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 244);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 29;
            label5.Text = "Hora Final:";
            // 
            // HoraIni
            // 
            HoraIni.Location = new Point(49, 262);
            HoraIni.Name = "HoraIni";
            HoraIni.Size = new Size(82, 23);
            HoraIni.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 244);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 27;
            label4.Text = "Hora Inicio:";
            // 
            // txtPropietario
            // 
            txtPropietario.Location = new Point(68, 158);
            txtPropietario.Name = "txtPropietario";
            txtPropietario.Size = new Size(163, 23);
            txtPropietario.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 140);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 25;
            label3.Text = "Nombre del Propietario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 189);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 24;
            label2.Text = "Tipo de vehículo:";
            // 
            // cbtipo
            // 
            cbtipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtipo.FormattingEnabled = true;
            cbtipo.Items.AddRange(new object[] { "CARRO", "MOTO", "BICICLETA" });
            cbtipo.Location = new Point(68, 207);
            cbtipo.Name = "cbtipo";
            cbtipo.Size = new Size(163, 23);
            cbtipo.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 96);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 22;
            label1.Text = "Placa del vehículo:";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(68, 114);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(163, 23);
            txtPlaca.TabIndex = 21;
            // 
            // datos
            // 
            datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datos.Location = new Point(321, 12);
            datos.Name = "datos";
            datos.RowTemplate.Height = 25;
            datos.Size = new Size(692, 366);
            datos.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 394);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 33;
            label6.Text = "placa:";
            // 
            // placa
            // 
            placa.Location = new Point(12, 413);
            placa.Name = "placa";
            placa.Size = new Size(163, 23);
            placa.TabIndex = 32;
            // 
            // idbo
            // 
            idbo.Location = new Point(292, 412);
            idbo.Name = "idbo";
            idbo.Size = new Size(163, 23);
            idbo.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(341, 394);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 35;
            label7.Text = "Borrar placa:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(76, 34);
            label9.Name = "label9";
            label9.Size = new Size(149, 25);
            label9.TabIndex = 37;
            label9.Text = "PARQUEADERO";
            // 
            // idPlaca
            // 
            idPlaca.Location = new Point(12, 368);
            idPlaca.Name = "idPlaca";
            idPlaca.Size = new Size(163, 23);
            idPlaca.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(81, 350);
            label10.Name = "label10";
            label10.Size = new Size(20, 15);
            label10.TabIndex = 40;
            label10.Text = "Id:";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 450);
            Controls.Add(label10);
            Controls.Add(idPlaca);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(idbo);
            Controls.Add(label6);
            Controls.Add(placa);
            Controls.Add(datos);
            Controls.Add(HoraFin);
            Controls.Add(label5);
            Controls.Add(HoraIni);
            Controls.Add(label4);
            Controls.Add(txtPropietario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbtipo);
            Controls.Add(label1);
            Controls.Add(txtPlaca);
            Controls.Add(buscar);
            Controls.Add(actualizar);
            Controls.Add(borrar);
            Controls.Add(agregar);
            Controls.Add(button1);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Parqueadero";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)datos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button agregar;
        private Button borrar;
        private Button actualizar;
        private Button buscar;
        private TextBox HoraFin;
        private Label label5;
        private TextBox HoraIni;
        private Label label4;
        private TextBox txtPropietario;
        private Label label3;
        private Label label2;
        private ComboBox cbtipo;
        private Label label1;
        private TextBox txtPlaca;
        private DataGridView datos;
        private Label label6;
        private TextBox placa;
        private TextBox idbo;
        private Label label7;
        private Label label9;
        private TextBox idPlaca;
        private Label label10;
    }
}