namespace p7
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
            b1 = new Button();
            b0 = new Button();
            b4 = new Button();
            b7 = new Button();
            b8 = new Button();
            b5 = new Button();
            b9 = new Button();
            bDivid = new Button();
            b6 = new Button();
            bMultip = new Button();
            bMenos = new Button();
            bMas = new Button();
            bIgual = new Button();
            b2 = new Button();
            b3 = new Button();
            pantalla = new TextBox();
            bLimpiar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b1.Location = new Point(40, 256);
            b1.Name = "b1";
            b1.Size = new Size(93, 40);
            b1.TabIndex = 0;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += BotonNumero_Click;
            // 
            // b0
            // 
            b0.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b0.Location = new Point(40, 316);
            b0.Name = "b0";
            b0.Size = new Size(93, 40);
            b0.TabIndex = 1;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += BotonNumero_Click;
            // 
            // b4
            // 
            b4.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b4.Location = new Point(40, 193);
            b4.Name = "b4";
            b4.Size = new Size(93, 40);
            b4.TabIndex = 2;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += BotonNumero_Click;
            // 
            // b7
            // 
            b7.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b7.Location = new Point(40, 133);
            b7.Name = "b7";
            b7.Size = new Size(93, 40);
            b7.TabIndex = 3;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += BotonNumero_Click;
            // 
            // b8
            // 
            b8.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b8.Location = new Point(167, 133);
            b8.Name = "b8";
            b8.Size = new Size(93, 40);
            b8.TabIndex = 4;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += BotonNumero_Click;
            // 
            // b5
            // 
            b5.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b5.Location = new Point(167, 193);
            b5.Name = "b5";
            b5.Size = new Size(93, 40);
            b5.TabIndex = 5;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += BotonNumero_Click;
            // 
            // b9
            // 
            b9.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b9.Location = new Point(294, 133);
            b9.Name = "b9";
            b9.Size = new Size(93, 40);
            b9.TabIndex = 6;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += BotonNumero_Click;
            // 
            // bDivid
            // 
            bDivid.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bDivid.Location = new Point(426, 193);
            bDivid.Name = "bDivid";
            bDivid.Size = new Size(93, 40);
            bDivid.TabIndex = 7;
            bDivid.Text = "/";
            bDivid.UseVisualStyleBackColor = true;
            bDivid.Click += BotonOperador_Click;
            // 
            // b6
            // 
            b6.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b6.Location = new Point(294, 193);
            b6.Name = "b6";
            b6.Size = new Size(93, 40);
            b6.TabIndex = 8;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += BotonNumero_Click;
            // 
            // bMultip
            // 
            bMultip.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bMultip.Location = new Point(426, 256);
            bMultip.Name = "bMultip";
            bMultip.Size = new Size(93, 40);
            bMultip.TabIndex = 9;
            bMultip.Text = "*";
            bMultip.UseVisualStyleBackColor = true;
            bMultip.Click += BotonOperador_Click;
            // 
            // bMenos
            // 
            bMenos.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bMenos.Location = new Point(426, 316);
            bMenos.Name = "bMenos";
            bMenos.Size = new Size(93, 40);
            bMenos.TabIndex = 10;
            bMenos.Text = "-";
            bMenos.UseVisualStyleBackColor = true;
            bMenos.Click += BotonOperador_Click;
            // 
            // bMas
            // 
            bMas.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bMas.Location = new Point(294, 316);
            bMas.Name = "bMas";
            bMas.Size = new Size(93, 40);
            bMas.TabIndex = 11;
            bMas.Text = "+";
            bMas.UseVisualStyleBackColor = true;
            bMas.Click += BotonOperador_Click;
            // 
            // bIgual
            // 
            bIgual.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bIgual.Location = new Point(167, 316);
            bIgual.Name = "bIgual";
            bIgual.Size = new Size(93, 40);
            bIgual.TabIndex = 12;
            bIgual.Text = "=";
            bIgual.UseVisualStyleBackColor = true;
            bIgual.Click += btnIgual_Click;
            // 
            // b2
            // 
            b2.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b2.Location = new Point(167, 256);
            b2.Name = "b2";
            b2.Size = new Size(93, 40);
            b2.TabIndex = 14;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += BotonNumero_Click;
            // 
            // b3
            // 
            b3.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b3.Location = new Point(294, 256);
            b3.Name = "b3";
            b3.Size = new Size(93, 40);
            b3.TabIndex = 15;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += BotonNumero_Click;
            // 
            // pantalla
            // 
            pantalla.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pantalla.Location = new Point(42, 73);
            pantalla.Name = "pantalla";
            pantalla.Size = new Size(479, 32);
            pantalla.TabIndex = 17;
            pantalla.TextChanged += pantalla_TextChanged;
            // 
            // bLimpiar
            // 
            bLimpiar.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bLimpiar.Location = new Point(426, 133);
            bLimpiar.Name = "bLimpiar";
            bLimpiar.Size = new Size(93, 40);
            bLimpiar.TabIndex = 18;
            bLimpiar.Text = "C";
            bLimpiar.UseVisualStyleBackColor = true;
            bLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Wide Latin", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 22);
            label1.Name = "label1";
            label1.Size = new Size(141, 26);
            label1.TabIndex = 22;
            label1.Text = "Prefija";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 395);
            Controls.Add(label1);
            Controls.Add(bLimpiar);
            Controls.Add(pantalla);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(bIgual);
            Controls.Add(bMas);
            Controls.Add(bMenos);
            Controls.Add(bMultip);
            Controls.Add(b6);
            Controls.Add(bDivid);
            Controls.Add(b9);
            Controls.Add(b5);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b4);
            Controls.Add(b0);
            Controls.Add(b1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b1;
        private Button b0;
        private Button b4;
        private Button b7;
        private Button b8;
        private Button b5;
        private Button b9;
        private Button bDivid;
        private Button b6;
        private Button bMultip;
        private Button bMenos;
        private Button bMas;
        private Button bIgual;
        private Button b2;
        private Button b3;
        private TextBox pantalla;
        private Button bLimpiar;
        private Label label1;
    }
}
