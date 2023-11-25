namespace ProyectoEstructura
{
    partial class FrmGrafos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrafos));
            label1 = new Label();
            BtnInsertarGrafo = new Button();
            TxBIngresarnodoG = new TextBox();
            label2 = new Label();
            TxBBuscarNodoG = new TextBox();
            label3 = new Label();
            BtnBuscarNodoG = new Button();
            TxBEliminar = new TextBox();
            label6 = new Label();
            BtnEliminarNodoG = new Button();
            BtnImprimirGrafo = new Button();
            label5 = new Label();
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Lucida Bright", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(101, 26);
            label1.Name = "label1";
            label1.Size = new Size(238, 24);
            label1.TabIndex = 1;
            label1.Text = "Operaciones con Grafos";
            // 
            // BtnInsertarGrafo
            // 
            BtnInsertarGrafo.BackColor = SystemColors.ButtonHighlight;
            BtnInsertarGrafo.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnInsertarGrafo.Image = (Image)resources.GetObject("BtnInsertarGrafo.Image");
            BtnInsertarGrafo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnInsertarGrafo.Location = new Point(48, 109);
            BtnInsertarGrafo.Name = "BtnInsertarGrafo";
            BtnInsertarGrafo.Size = new Size(163, 35);
            BtnInsertarGrafo.TabIndex = 2;
            BtnInsertarGrafo.Text = "Insertar nodo";
            BtnInsertarGrafo.UseVisualStyleBackColor = false;
            BtnInsertarGrafo.Click += BtnInsertarGrafo_Click;
            // 
            // TxBIngresarnodoG
            // 
            TxBIngresarnodoG.Location = new Point(373, 117);
            TxBIngresarnodoG.Name = "TxBIngresarnodoG";
            TxBIngresarnodoG.Size = new Size(100, 23);
            TxBIngresarnodoG.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(227, 120);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 6;
            label2.Text = "Digite el nodo a insertar";
            // 
            // TxBBuscarNodoG
            // 
            TxBBuscarNodoG.Location = new Point(372, 193);
            TxBBuscarNodoG.Name = "TxBBuscarNodoG";
            TxBBuscarNodoG.Size = new Size(100, 23);
            TxBBuscarNodoG.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(227, 196);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 9;
            label3.Text = "Digite el nodo a buscar  ";
            // 
            // BtnBuscarNodoG
            // 
            BtnBuscarNodoG.BackColor = SystemColors.ButtonHighlight;
            BtnBuscarNodoG.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBuscarNodoG.Image = (Image)resources.GetObject("BtnBuscarNodoG.Image");
            BtnBuscarNodoG.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscarNodoG.Location = new Point(48, 185);
            BtnBuscarNodoG.Name = "BtnBuscarNodoG";
            BtnBuscarNodoG.Size = new Size(149, 35);
            BtnBuscarNodoG.TabIndex = 8;
            BtnBuscarNodoG.Text = "Buscar nodo";
            BtnBuscarNodoG.UseVisualStyleBackColor = false;
            BtnBuscarNodoG.Click += BtnBuscarNodoG_Click;
            // 
            // TxBEliminar
            // 
            TxBEliminar.Location = new Point(380, 268);
            TxBEliminar.Name = "TxBEliminar";
            TxBEliminar.Size = new Size(100, 23);
            TxBEliminar.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(227, 271);
            label6.Name = "label6";
            label6.Size = new Size(147, 15);
            label6.TabIndex = 15;
            label6.Text = "Digite el nodo a Eliminar  ";
            // 
            // BtnEliminarNodoG
            // 
            BtnEliminarNodoG.BackColor = SystemColors.ButtonHighlight;
            BtnEliminarNodoG.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEliminarNodoG.Image = (Image)resources.GetObject("BtnEliminarNodoG.Image");
            BtnEliminarNodoG.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminarNodoG.Location = new Point(48, 260);
            BtnEliminarNodoG.Name = "BtnEliminarNodoG";
            BtnEliminarNodoG.Size = new Size(157, 35);
            BtnEliminarNodoG.TabIndex = 14;
            BtnEliminarNodoG.Text = "Eliminar nodo";
            BtnEliminarNodoG.UseVisualStyleBackColor = false;
            BtnEliminarNodoG.Click += BtnEliminarNodoG_Click;
            // 
            // BtnImprimirGrafo
            // 
            BtnImprimirGrafo.BackColor = SystemColors.ButtonHighlight;
            BtnImprimirGrafo.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnImprimirGrafo.Image = (Image)resources.GetObject("BtnImprimirGrafo.Image");
            BtnImprimirGrafo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnImprimirGrafo.Location = new Point(205, 358);
            BtnImprimirGrafo.Name = "BtnImprimirGrafo";
            BtnImprimirGrafo.Size = new Size(169, 35);
            BtnImprimirGrafo.TabIndex = 17;
            BtnImprimirGrafo.Text = "Imprimir Grafo";
            BtnImprimirGrafo.UseVisualStyleBackColor = false;
            BtnImprimirGrafo.Click += BtnImprimirGrafo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(636, 261);
            label5.Name = "label5";
            label5.Size = new Size(156, 30);
            label5.TabIndex = 18;
            label5.Text = "Vista del Grafo";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(558, 294);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(316, 196);
            treeView1.TabIndex = 19;
            // 
            // FrmGrafos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(949, 565);
            Controls.Add(treeView1);
            Controls.Add(label5);
            Controls.Add(BtnImprimirGrafo);
            Controls.Add(TxBEliminar);
            Controls.Add(label6);
            Controls.Add(BtnEliminarNodoG);
            Controls.Add(TxBBuscarNodoG);
            Controls.Add(label3);
            Controls.Add(BtnBuscarNodoG);
            Controls.Add(TxBIngresarnodoG);
            Controls.Add(label2);
            Controls.Add(BtnInsertarGrafo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGrafos";
            Text = "FrmGrafos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnInsertarGrafo;
        private TextBox TxBIngresarnodoG;
        private Label label2;
        private TextBox TxBBuscarNodoG;
        private Label label3;
        private Button BtnBuscarNodoG;
        private TextBox TxBEliminar;
        private Label label6;
        private Button BtnEliminarNodoG;
        private Button BtnImprimirGrafo;
        private Label label5;
        private TreeView treeView1;
    }
}