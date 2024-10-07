namespace p9
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            bDetectar = new Button();
            bSubir = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(506, 489);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(552, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(506, 489);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // bDetectar
            // 
            bDetectar.Font = new Font("Palatino Linotype", 12F);
            bDetectar.Location = new Point(1086, 131);
            bDetectar.Name = "bDetectar";
            bDetectar.Size = new Size(103, 71);
            bDetectar.TabIndex = 3;
            bDetectar.Text = "Detectar Bordes";
            bDetectar.UseVisualStyleBackColor = true;
            bDetectar.Click += bDetectar_Click;
            // 
            // bSubir
            // 
            bSubir.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bSubir.Location = new Point(1086, 32);
            bSubir.Name = "bSubir";
            bSubir.Size = new Size(103, 71);
            bSubir.TabIndex = 4;
            bSubir.Text = "Subir Imagen";
            bSubir.UseVisualStyleBackColor = true;
            bSubir.Click += bSubir_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 517);
            Controls.Add(bSubir);
            Controls.Add(bDetectar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button bDetectar;
        private Button bSubir;
        private OpenFileDialog openFileDialog1;
    }
}
