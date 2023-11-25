namespace ProyectoEstructura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PnlBarraTitulo = new Panel();
            BtnRestaurar = new PictureBox();
            BtnMinimizar = new PictureBox();
            BtnMaximizar = new PictureBox();
            BtnCerrar = new PictureBox();
            PnlMenu = new Panel();
            BtnInicio = new Button();
            BtnGrafos = new Button();
            BtnArbolBinario = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            PnlContenedor = new Panel();
            PnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PnlBarraTitulo
            // 
            PnlBarraTitulo.BackColor = Color.MediumBlue;
            PnlBarraTitulo.Controls.Add(BtnRestaurar);
            PnlBarraTitulo.Controls.Add(BtnMinimizar);
            PnlBarraTitulo.Controls.Add(BtnMaximizar);
            PnlBarraTitulo.Controls.Add(BtnCerrar);
            PnlBarraTitulo.Dock = DockStyle.Top;
            PnlBarraTitulo.Location = new Point(0, 0);
            PnlBarraTitulo.Name = "PnlBarraTitulo";
            PnlBarraTitulo.Size = new Size(1300, 35);
            PnlBarraTitulo.TabIndex = 0;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.Cursor = Cursors.Hand;
            BtnRestaurar.Image = (Image)resources.GetObject("BtnRestaurar.Image");
            BtnRestaurar.Location = new Point(1170, 4);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(25, 25);
            BtnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnRestaurar.TabIndex = 3;
            BtnRestaurar.TabStop = false;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimizar.Cursor = Cursors.Hand;
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(1201, 4);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(25, 25);
            BtnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMinimizar.TabIndex = 2;
            BtnMinimizar.TabStop = false;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // BtnMaximizar
            // 
            BtnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMaximizar.Cursor = Cursors.Hand;
            BtnMaximizar.Image = (Image)resources.GetObject("BtnMaximizar.Image");
            BtnMaximizar.Location = new Point(1232, 4);
            BtnMaximizar.Name = "BtnMaximizar";
            BtnMaximizar.Size = new Size(25, 25);
            BtnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMaximizar.TabIndex = 1;
            BtnMaximizar.TabStop = false;
            BtnMaximizar.Click += BtnMaximizar_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCerrar.Cursor = Cursors.Hand;
            BtnCerrar.Image = (Image)resources.GetObject("BtnCerrar.Image");
            BtnCerrar.Location = new Point(1263, 4);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(25, 25);
            BtnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnCerrar.TabIndex = 0;
            BtnCerrar.TabStop = false;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // PnlMenu
            // 
            PnlMenu.BackColor = Color.FromArgb(26, 32, 40);
            PnlMenu.Controls.Add(BtnInicio);
            PnlMenu.Controls.Add(BtnGrafos);
            PnlMenu.Controls.Add(BtnArbolBinario);
            PnlMenu.Controls.Add(label1);
            PnlMenu.Controls.Add(pictureBox2);
            PnlMenu.Controls.Add(pictureBox1);
            PnlMenu.Cursor = Cursors.Hand;
            PnlMenu.Dock = DockStyle.Left;
            PnlMenu.Location = new Point(0, 35);
            PnlMenu.Name = "PnlMenu";
            PnlMenu.Size = new Size(220, 615);
            PnlMenu.TabIndex = 1;
            // 
            // BtnInicio
            // 
            BtnInicio.BackColor = Color.FromArgb(0, 0, 192);
            BtnInicio.FlatStyle = FlatStyle.Popup;
            BtnInicio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BtnInicio.ForeColor = SystemColors.ButtonHighlight;
            BtnInicio.Location = new Point(54, 485);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(114, 35);
            BtnInicio.TabIndex = 4;
            BtnInicio.Text = "Inicio";
            BtnInicio.UseVisualStyleBackColor = false;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // BtnGrafos
            // 
            BtnGrafos.BackColor = Color.FromArgb(26, 32, 40);
            BtnGrafos.Cursor = Cursors.Hand;
            BtnGrafos.FlatAppearance.BorderSize = 0;
            BtnGrafos.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            BtnGrafos.FlatStyle = FlatStyle.Flat;
            BtnGrafos.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGrafos.ForeColor = SystemColors.ButtonFace;
            BtnGrafos.Location = new Point(44, 408);
            BtnGrafos.Name = "BtnGrafos";
            BtnGrafos.Size = new Size(124, 49);
            BtnGrafos.TabIndex = 4;
            BtnGrafos.Text = "Grafos";
            BtnGrafos.UseVisualStyleBackColor = false;
            BtnGrafos.Click += BtnGrafos_Click;
            // 
            // BtnArbolBinario
            // 
            BtnArbolBinario.BackColor = Color.FromArgb(26, 32, 40);
            BtnArbolBinario.Cursor = Cursors.Hand;
            BtnArbolBinario.FlatAppearance.BorderSize = 0;
            BtnArbolBinario.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            BtnArbolBinario.FlatStyle = FlatStyle.Flat;
            BtnArbolBinario.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnArbolBinario.ForeColor = SystemColors.ButtonFace;
            BtnArbolBinario.Location = new Point(44, 189);
            BtnArbolBinario.Name = "BtnArbolBinario";
            BtnArbolBinario.Size = new Size(124, 49);
            BtnArbolBinario.TabIndex = 3;
            BtnArbolBinario.Text = "Arboles Binarios";
            BtnArbolBinario.UseVisualStyleBackColor = false;
            BtnArbolBinario.Click += BtnArbolBinario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(75, 29);
            label1.Name = "label1";
            label1.Size = new Size(62, 22);
            label1.TabIndex = 2;
            label1.Text = "Menu";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 281);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PnlContenedor
            // 
            PnlContenedor.BackColor = Color.FromArgb(49, 66, 82);
            PnlContenedor.Dock = DockStyle.Fill;
            PnlContenedor.Location = new Point(220, 35);
            PnlContenedor.Name = "PnlContenedor";
            PnlContenedor.Size = new Size(1080, 615);
            PnlContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(PnlContenedor);
            Controls.Add(PnlMenu);
            Controls.Add(PnlBarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            PnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).EndInit();
            PnlMenu.ResumeLayout(false);
            PnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlBarraTitulo;
        private Panel PnlMenu;
        private Panel PnlContenedor;
        private PictureBox BtnCerrar;
        private PictureBox BtnMaximizar;
        private PictureBox BtnMinimizar;
        private PictureBox BtnRestaurar;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button BtnArbolBinario;
        private Button BtnGrafos;
        private Button BtnInicio;
    }
}