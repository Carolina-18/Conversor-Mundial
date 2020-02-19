namespace Conversor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidadM = new System.Windows.Forms.TextBox();
            this.btnconvertirM = new System.Windows.Forms.Button();
            this.lbldemonedas = new System.Windows.Forms.Label();
            this.lblamonedas = new System.Windows.Forms.Label();
            this.cmbmoneda = new System.Windows.Forms.ComboBox();
            this.cmbcambiar = new System.Windows.Forms.ComboBox();
            this.lblrespuestaM = new System.Windows.Forms.Label();
            this.tabconversiones = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblrespuestaL = new System.Windows.Forms.Label();
            this.lblCL = new System.Windows.Forms.Label();
            this.cmbalongitud = new System.Windows.Forms.ComboBox();
            this.lblconvertir = new System.Windows.Forms.Label();
            this.cmbdelongitud = new System.Windows.Forms.ComboBox();
            this.txtcantidadL = new System.Windows.Forms.TextBox();
            this.lblalongitud = new System.Windows.Forms.Label();
            this.btnconvertirL = new System.Windows.Forms.Button();
            this.lbldelongitud = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblrespuestaP = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbapeso = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbdepeso = new System.Windows.Forms.ComboBox();
            this.txtcantidadP = new System.Windows.Forms.TextBox();
            this.lblapeso = new System.Windows.Forms.Label();
            this.btnconvertirP = new System.Windows.Forms.Button();
            this.lbldepeso = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblrespuestaV = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbavolumen = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbdevolumen = new System.Windows.Forms.ComboBox();
            this.txtcantidadV = new System.Windows.Forms.TextBox();
            this.lblavolumen = new System.Windows.Forms.Label();
            this.btnconvertirV = new System.Windows.Forms.Button();
            this.lbldevolumen = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblrespuestaA = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbaalmacenamiento = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbdealmacenamiento = new System.Windows.Forms.ComboBox();
            this.txtcantidadA = new System.Windows.Forms.TextBox();
            this.lblaalmacenamiento = new System.Windows.Forms.Label();
            this.btnconvertirA = new System.Windows.Forms.Button();
            this.lbldealmacenamiento = new System.Windows.Forms.Label();
            this.tabconversiones.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.BackColor = System.Drawing.Color.White;
            this.lblCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCM.Location = new System.Drawing.Point(99, 27);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(207, 16);
            this.lblCM.TabIndex = 0;
            this.lblCM.Text = "CONVERSOR DE MONEDAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convertir:";
            // 
            // txtcantidadM
            // 
            this.txtcantidadM.Location = new System.Drawing.Point(142, 75);
            this.txtcantidadM.Name = "txtcantidadM";
            this.txtcantidadM.Size = new System.Drawing.Size(133, 21);
            this.txtcantidadM.TabIndex = 2;
            // 
            // btnconvertirM
            // 
            this.btnconvertirM.BackColor = System.Drawing.Color.Gray;
            this.btnconvertirM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertirM.Location = new System.Drawing.Point(142, 285);
            this.btnconvertirM.Name = "btnconvertirM";
            this.btnconvertirM.Size = new System.Drawing.Size(133, 57);
            this.btnconvertirM.TabIndex = 3;
            this.btnconvertirM.Text = "Convertir";
            this.btnconvertirM.UseVisualStyleBackColor = false;
            this.btnconvertirM.Click += new System.EventHandler(this.btnconvertirM_Click);
            // 
            // lbldemonedas
            // 
            this.lbldemonedas.AutoSize = true;
            this.lbldemonedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldemonedas.Location = new System.Drawing.Point(84, 141);
            this.lbldemonedas.Name = "lbldemonedas";
            this.lbldemonedas.Size = new System.Drawing.Size(29, 15);
            this.lbldemonedas.TabIndex = 4;
            this.lbldemonedas.Text = "De:";
            // 
            // lblamonedas
            // 
            this.lblamonedas.AutoSize = true;
            this.lblamonedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamonedas.Location = new System.Drawing.Point(84, 187);
            this.lblamonedas.Name = "lblamonedas";
            this.lblamonedas.Size = new System.Drawing.Size(19, 15);
            this.lblamonedas.TabIndex = 5;
            this.lblamonedas.Text = "A:";
            // 
            // cmbmoneda
            // 
            this.cmbmoneda.FormattingEnabled = true;
            this.cmbmoneda.Location = new System.Drawing.Point(142, 138);
            this.cmbmoneda.Name = "cmbmoneda";
            this.cmbmoneda.Size = new System.Drawing.Size(133, 23);
            this.cmbmoneda.TabIndex = 6;
            // 
            // cmbcambiar
            // 
            this.cmbcambiar.FormattingEnabled = true;
            this.cmbcambiar.Location = new System.Drawing.Point(142, 187);
            this.cmbcambiar.Name = "cmbcambiar";
            this.cmbcambiar.Size = new System.Drawing.Size(133, 23);
            this.cmbcambiar.TabIndex = 7;
            // 
            // lblrespuestaM
            // 
            this.lblrespuestaM.AutoSize = true;
            this.lblrespuestaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuestaM.Location = new System.Drawing.Point(163, 244);
            this.lblrespuestaM.Name = "lblrespuestaM";
            this.lblrespuestaM.Size = new System.Drawing.Size(87, 16);
            this.lblrespuestaM.TabIndex = 8;
            this.lblrespuestaM.Text = "Respuesta:";
            // 
            // tabconversiones
            // 
            this.tabconversiones.Controls.Add(this.tabPage1);
            this.tabconversiones.Controls.Add(this.tabPage2);
            this.tabconversiones.Controls.Add(this.tabPage3);
            this.tabconversiones.Controls.Add(this.tabPage4);
            this.tabconversiones.Controls.Add(this.tabPage5);
            this.tabconversiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabconversiones.Location = new System.Drawing.Point(12, 12);
            this.tabconversiones.Name = "tabconversiones";
            this.tabconversiones.SelectedIndex = 0;
            this.tabconversiones.Size = new System.Drawing.Size(401, 383);
            this.tabconversiones.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.lblrespuestaM);
            this.tabPage1.Controls.Add(this.lblCM);
            this.tabPage1.Controls.Add(this.cmbcambiar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbmoneda);
            this.tabPage1.Controls.Add(this.txtcantidadM);
            this.tabPage1.Controls.Add(this.lblamonedas);
            this.tabPage1.Controls.Add(this.btnconvertirM);
            this.tabPage1.Controls.Add(this.lbldemonedas);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(393, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MONEDAS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.lblrespuestaL);
            this.tabPage2.Controls.Add(this.lblCL);
            this.tabPage2.Controls.Add(this.cmbalongitud);
            this.tabPage2.Controls.Add(this.lblconvertir);
            this.tabPage2.Controls.Add(this.cmbdelongitud);
            this.tabPage2.Controls.Add(this.txtcantidadL);
            this.tabPage2.Controls.Add(this.lblalongitud);
            this.tabPage2.Controls.Add(this.btnconvertirL);
            this.tabPage2.Controls.Add(this.lbldelongitud);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(393, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LONGITUD";
            // 
            // lblrespuestaL
            // 
            this.lblrespuestaL.AutoSize = true;
            this.lblrespuestaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuestaL.Location = new System.Drawing.Point(167, 240);
            this.lblrespuestaL.Name = "lblrespuestaL";
            this.lblrespuestaL.Size = new System.Drawing.Size(79, 15);
            this.lblrespuestaL.TabIndex = 17;
            this.lblrespuestaL.Text = "Respuesta:";
            // 
            // lblCL
            // 
            this.lblCL.AutoSize = true;
            this.lblCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCL.Location = new System.Drawing.Point(97, 30);
            this.lblCL.Name = "lblCL";
            this.lblCL.Size = new System.Drawing.Size(209, 16);
            this.lblCL.TabIndex = 9;
            this.lblCL.Text = "CONVERSOR DE LONGITUD";
            // 
            // cmbalongitud
            // 
            this.cmbalongitud.FormattingEnabled = true;
            this.cmbalongitud.Location = new System.Drawing.Point(138, 188);
            this.cmbalongitud.Name = "cmbalongitud";
            this.cmbalongitud.Size = new System.Drawing.Size(133, 21);
            this.cmbalongitud.TabIndex = 16;
            // 
            // lblconvertir
            // 
            this.lblconvertir.AutoSize = true;
            this.lblconvertir.Location = new System.Drawing.Point(70, 79);
            this.lblconvertir.Name = "lblconvertir";
            this.lblconvertir.Size = new System.Drawing.Size(62, 13);
            this.lblconvertir.TabIndex = 10;
            this.lblconvertir.Text = "Convertir:";
            // 
            // cmbdelongitud
            // 
            this.cmbdelongitud.FormattingEnabled = true;
            this.cmbdelongitud.Location = new System.Drawing.Point(138, 139);
            this.cmbdelongitud.Name = "cmbdelongitud";
            this.cmbdelongitud.Size = new System.Drawing.Size(133, 21);
            this.cmbdelongitud.TabIndex = 15;
            // 
            // txtcantidadL
            // 
            this.txtcantidadL.Location = new System.Drawing.Point(138, 76);
            this.txtcantidadL.Name = "txtcantidadL";
            this.txtcantidadL.Size = new System.Drawing.Size(133, 20);
            this.txtcantidadL.TabIndex = 11;
            // 
            // lblalongitud
            // 
            this.lblalongitud.AutoSize = true;
            this.lblalongitud.Location = new System.Drawing.Point(80, 188);
            this.lblalongitud.Name = "lblalongitud";
            this.lblalongitud.Size = new System.Drawing.Size(19, 13);
            this.lblalongitud.TabIndex = 14;
            this.lblalongitud.Text = "A:";
            // 
            // btnconvertirL
            // 
            this.btnconvertirL.BackColor = System.Drawing.Color.Gray;
            this.btnconvertirL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertirL.Location = new System.Drawing.Point(138, 283);
            this.btnconvertirL.Name = "btnconvertirL";
            this.btnconvertirL.Size = new System.Drawing.Size(133, 56);
            this.btnconvertirL.TabIndex = 12;
            this.btnconvertirL.Text = "Convertir";
            this.btnconvertirL.UseVisualStyleBackColor = false;
            this.btnconvertirL.Click += new System.EventHandler(this.btnconvertirL_Click);
            // 
            // lbldelongitud
            // 
            this.lbldelongitud.AutoSize = true;
            this.lbldelongitud.Location = new System.Drawing.Point(80, 142);
            this.lbldelongitud.Name = "lbldelongitud";
            this.lbldelongitud.Size = new System.Drawing.Size(27, 13);
            this.lbldelongitud.TabIndex = 13;
            this.lbldelongitud.Text = "De:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.lblrespuestaP);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cmbapeso);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.cmbdepeso);
            this.tabPage3.Controls.Add(this.txtcantidadP);
            this.tabPage3.Controls.Add(this.lblapeso);
            this.tabPage3.Controls.Add(this.btnconvertirP);
            this.tabPage3.Controls.Add(this.lbldepeso);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(393, 357);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PESO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblrespuestaP
            // 
            this.lblrespuestaP.AutoSize = true;
            this.lblrespuestaP.BackColor = System.Drawing.Color.White;
            this.lblrespuestaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuestaP.Location = new System.Drawing.Point(159, 242);
            this.lblrespuestaP.Name = "lblrespuestaP";
            this.lblrespuestaP.Size = new System.Drawing.Size(87, 16);
            this.lblrespuestaP.TabIndex = 17;
            this.lblrespuestaP.Text = "Respuesta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(109, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "CONVERSOR DE PESO";
            // 
            // cmbapeso
            // 
            this.cmbapeso.FormattingEnabled = true;
            this.cmbapeso.Location = new System.Drawing.Point(137, 190);
            this.cmbapeso.Name = "cmbapeso";
            this.cmbapeso.Size = new System.Drawing.Size(133, 21);
            this.cmbapeso.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(63, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Convertir:";
            // 
            // cmbdepeso
            // 
            this.cmbdepeso.FormattingEnabled = true;
            this.cmbdepeso.Location = new System.Drawing.Point(137, 141);
            this.cmbdepeso.Name = "cmbdepeso";
            this.cmbdepeso.Size = new System.Drawing.Size(133, 21);
            this.cmbdepeso.TabIndex = 15;
            // 
            // txtcantidadP
            // 
            this.txtcantidadP.Location = new System.Drawing.Point(137, 78);
            this.txtcantidadP.Name = "txtcantidadP";
            this.txtcantidadP.Size = new System.Drawing.Size(133, 20);
            this.txtcantidadP.TabIndex = 11;
            // 
            // lblapeso
            // 
            this.lblapeso.AutoSize = true;
            this.lblapeso.BackColor = System.Drawing.Color.White;
            this.lblapeso.Location = new System.Drawing.Point(79, 190);
            this.lblapeso.Name = "lblapeso";
            this.lblapeso.Size = new System.Drawing.Size(19, 13);
            this.lblapeso.TabIndex = 14;
            this.lblapeso.Text = "A:";
            // 
            // btnconvertirP
            // 
            this.btnconvertirP.BackColor = System.Drawing.Color.Gray;
            this.btnconvertirP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertirP.Location = new System.Drawing.Point(137, 288);
            this.btnconvertirP.Name = "btnconvertirP";
            this.btnconvertirP.Size = new System.Drawing.Size(133, 50);
            this.btnconvertirP.TabIndex = 12;
            this.btnconvertirP.Text = "Convertir";
            this.btnconvertirP.UseVisualStyleBackColor = false;
            this.btnconvertirP.Click += new System.EventHandler(this.btnconvertirP_Click);
            // 
            // lbldepeso
            // 
            this.lbldepeso.AutoSize = true;
            this.lbldepeso.BackColor = System.Drawing.Color.White;
            this.lbldepeso.Location = new System.Drawing.Point(79, 144);
            this.lbldepeso.Name = "lbldepeso";
            this.lbldepeso.Size = new System.Drawing.Size(27, 13);
            this.lbldepeso.TabIndex = 13;
            this.lbldepeso.Text = "De:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.lblrespuestaV);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.cmbavolumen);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.cmbdevolumen);
            this.tabPage4.Controls.Add(this.txtcantidadV);
            this.tabPage4.Controls.Add(this.lblavolumen);
            this.tabPage4.Controls.Add(this.btnconvertirV);
            this.tabPage4.Controls.Add(this.lbldevolumen);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(393, 357);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "VOLUMEN";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblrespuestaV
            // 
            this.lblrespuestaV.AutoSize = true;
            this.lblrespuestaV.BackColor = System.Drawing.Color.White;
            this.lblrespuestaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuestaV.Location = new System.Drawing.Point(174, 241);
            this.lblrespuestaV.Name = "lblrespuestaV";
            this.lblrespuestaV.Size = new System.Drawing.Size(79, 15);
            this.lblrespuestaV.TabIndex = 17;
            this.lblrespuestaV.Text = "Respuesta:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(99, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(205, 16);
            this.label16.TabIndex = 9;
            this.label16.Text = "CONVERSOR DE VOLUMEN";
            // 
            // cmbavolumen
            // 
            this.cmbavolumen.FormattingEnabled = true;
            this.cmbavolumen.Location = new System.Drawing.Point(145, 189);
            this.cmbavolumen.Name = "cmbavolumen";
            this.cmbavolumen.Size = new System.Drawing.Size(133, 21);
            this.cmbavolumen.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(68, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 15);
            this.label17.TabIndex = 10;
            this.label17.Text = "Convertir:";
            // 
            // cmbdevolumen
            // 
            this.cmbdevolumen.FormattingEnabled = true;
            this.cmbdevolumen.Location = new System.Drawing.Point(145, 140);
            this.cmbdevolumen.Name = "cmbdevolumen";
            this.cmbdevolumen.Size = new System.Drawing.Size(133, 21);
            this.cmbdevolumen.TabIndex = 15;
            // 
            // txtcantidadV
            // 
            this.txtcantidadV.Location = new System.Drawing.Point(145, 77);
            this.txtcantidadV.Name = "txtcantidadV";
            this.txtcantidadV.Size = new System.Drawing.Size(133, 20);
            this.txtcantidadV.TabIndex = 11;
            // 
            // lblavolumen
            // 
            this.lblavolumen.AutoSize = true;
            this.lblavolumen.BackColor = System.Drawing.Color.White;
            this.lblavolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavolumen.Location = new System.Drawing.Point(87, 189);
            this.lblavolumen.Name = "lblavolumen";
            this.lblavolumen.Size = new System.Drawing.Size(19, 15);
            this.lblavolumen.TabIndex = 14;
            this.lblavolumen.Text = "A:";
            // 
            // btnconvertirV
            // 
            this.btnconvertirV.BackColor = System.Drawing.Color.Gray;
            this.btnconvertirV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertirV.Location = new System.Drawing.Point(145, 286);
            this.btnconvertirV.Name = "btnconvertirV";
            this.btnconvertirV.Size = new System.Drawing.Size(133, 52);
            this.btnconvertirV.TabIndex = 12;
            this.btnconvertirV.Text = "Convertir";
            this.btnconvertirV.UseVisualStyleBackColor = false;
            this.btnconvertirV.Click += new System.EventHandler(this.btnconvertirV_Click);
            // 
            // lbldevolumen
            // 
            this.lbldevolumen.AutoSize = true;
            this.lbldevolumen.BackColor = System.Drawing.Color.White;
            this.lbldevolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldevolumen.Location = new System.Drawing.Point(87, 143);
            this.lbldevolumen.Name = "lbldevolumen";
            this.lbldevolumen.Size = new System.Drawing.Size(29, 15);
            this.lbldevolumen.TabIndex = 13;
            this.lbldevolumen.Text = "De:";
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Controls.Add(this.lblrespuestaA);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.cmbaalmacenamiento);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.cmbdealmacenamiento);
            this.tabPage5.Controls.Add(this.txtcantidadA);
            this.tabPage5.Controls.Add(this.lblaalmacenamiento);
            this.tabPage5.Controls.Add(this.btnconvertirA);
            this.tabPage5.Controls.Add(this.lbldealmacenamiento);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(393, 357);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "ALMACENAMIENTO";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblrespuestaA
            // 
            this.lblrespuestaA.AutoSize = true;
            this.lblrespuestaA.BackColor = System.Drawing.Color.White;
            this.lblrespuestaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuestaA.Location = new System.Drawing.Point(166, 243);
            this.lblrespuestaA.Name = "lblrespuestaA";
            this.lblrespuestaA.Size = new System.Drawing.Size(87, 16);
            this.lblrespuestaA.TabIndex = 17;
            this.lblrespuestaA.Text = "Respuesta:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(86, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(223, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "CONVERSOR DE ALMACENAMIENTO";
            // 
            // cmbaalmacenamiento
            // 
            this.cmbaalmacenamiento.FormattingEnabled = true;
            this.cmbaalmacenamiento.Location = new System.Drawing.Point(144, 189);
            this.cmbaalmacenamiento.Name = "cmbaalmacenamiento";
            this.cmbaalmacenamiento.Size = new System.Drawing.Size(133, 21);
            this.cmbaalmacenamiento.TabIndex = 16;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(64, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 16);
            this.label22.TabIndex = 10;
            this.label22.Text = "Convertir:";
            // 
            // cmbdealmacenamiento
            // 
            this.cmbdealmacenamiento.FormattingEnabled = true;
            this.cmbdealmacenamiento.Location = new System.Drawing.Point(144, 140);
            this.cmbdealmacenamiento.Name = "cmbdealmacenamiento";
            this.cmbdealmacenamiento.Size = new System.Drawing.Size(133, 21);
            this.cmbdealmacenamiento.TabIndex = 15;
            // 
            // txtcantidadA
            // 
            this.txtcantidadA.Location = new System.Drawing.Point(144, 77);
            this.txtcantidadA.Name = "txtcantidadA";
            this.txtcantidadA.Size = new System.Drawing.Size(133, 20);
            this.txtcantidadA.TabIndex = 11;
            // 
            // lblaalmacenamiento
            // 
            this.lblaalmacenamiento.AutoSize = true;
            this.lblaalmacenamiento.BackColor = System.Drawing.Color.White;
            this.lblaalmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaalmacenamiento.Location = new System.Drawing.Point(86, 189);
            this.lblaalmacenamiento.Name = "lblaalmacenamiento";
            this.lblaalmacenamiento.Size = new System.Drawing.Size(22, 16);
            this.lblaalmacenamiento.TabIndex = 14;
            this.lblaalmacenamiento.Text = "A:";
            // 
            // btnconvertirA
            // 
            this.btnconvertirA.BackColor = System.Drawing.Color.Gray;
            this.btnconvertirA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertirA.ForeColor = System.Drawing.Color.Black;
            this.btnconvertirA.Location = new System.Drawing.Point(144, 284);
            this.btnconvertirA.Name = "btnconvertirA";
            this.btnconvertirA.Size = new System.Drawing.Size(133, 56);
            this.btnconvertirA.TabIndex = 12;
            this.btnconvertirA.Text = "Convertir";
            this.btnconvertirA.UseVisualStyleBackColor = false;
            this.btnconvertirA.Click += new System.EventHandler(this.btnconvertirA_Click);
            // 
            // lbldealmacenamiento
            // 
            this.lbldealmacenamiento.AutoSize = true;
            this.lbldealmacenamiento.BackColor = System.Drawing.Color.White;
            this.lbldealmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldealmacenamiento.Location = new System.Drawing.Point(86, 143);
            this.lbldealmacenamiento.Name = "lbldealmacenamiento";
            this.lbldealmacenamiento.Size = new System.Drawing.Size(32, 16);
            this.lbldealmacenamiento.TabIndex = 13;
            this.lbldealmacenamiento.Text = "De:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(429, 408);
            this.Controls.Add(this.tabconversiones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabconversiones.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidadM;
        private System.Windows.Forms.Button btnconvertirM;
        private System.Windows.Forms.Label lbldemonedas;
        private System.Windows.Forms.Label lblamonedas;
        private System.Windows.Forms.ComboBox cmbmoneda;
        private System.Windows.Forms.ComboBox cmbcambiar;
        private System.Windows.Forms.Label lblrespuestaM;
        private System.Windows.Forms.TabControl tabconversiones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblrespuestaL;
        private System.Windows.Forms.Label lblCL;
        private System.Windows.Forms.ComboBox cmbalongitud;
        private System.Windows.Forms.Label lblconvertir;
        private System.Windows.Forms.ComboBox cmbdelongitud;
        private System.Windows.Forms.TextBox txtcantidadL;
        private System.Windows.Forms.Label lblalongitud;
        private System.Windows.Forms.Button btnconvertirL;
        private System.Windows.Forms.Label lbldelongitud;
        private System.Windows.Forms.Label lblrespuestaP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbapeso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbdepeso;
        private System.Windows.Forms.TextBox txtcantidadP;
        private System.Windows.Forms.Label lblapeso;
        private System.Windows.Forms.Button btnconvertirP;
        private System.Windows.Forms.Label lbldepeso;
        private System.Windows.Forms.Label lblrespuestaV;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbavolumen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbdevolumen;
        private System.Windows.Forms.TextBox txtcantidadV;
        private System.Windows.Forms.Label lblavolumen;
        private System.Windows.Forms.Button btnconvertirV;
        private System.Windows.Forms.Label lbldevolumen;
        private System.Windows.Forms.Label lblrespuestaA;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbaalmacenamiento;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbdealmacenamiento;
        private System.Windows.Forms.TextBox txtcantidadA;
        private System.Windows.Forms.Label lblaalmacenamiento;
        private System.Windows.Forms.Button btnconvertirA;
        private System.Windows.Forms.Label lbldealmacenamiento;
    }
}

