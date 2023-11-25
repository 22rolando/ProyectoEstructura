namespace ProyectoEstructura
{
    partial class FrmArboles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArboles));
            label1 = new Label();
            BtnInsertarNodo = new Button();
            BtnBuscarElimNodo = new Button();
            BtnImprimirNodo = new Button();
            label2 = new Label();
            TxBIngresarnodo = new TextBox();
            TxBEliminiraBuscarNodo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            treeView1 = new TreeView();
            label5 = new Label();
            button1 = new Button();
            TxBEliminar = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Lucida Bright", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(91, 19);
            label1.Name = "label1";
            label1.Size = new Size(245, 24);
            label1.TabIndex = 0;
            label1.Text = "Operaciones con Arboles";
            // 
            // BtnInsertarNodo
            // 
            BtnInsertarNodo.BackColor = SystemColors.ButtonHighlight;
            BtnInsertarNodo.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnInsertarNodo.Image = (Image)resources.GetObject("BtnInsertarNodo.Image");
            BtnInsertarNodo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnInsertarNodo.Location = new Point(24, 98);
            BtnInsertarNodo.Name = "BtnInsertarNodo";
            BtnInsertarNodo.Size = new Size(163, 35);
            BtnInsertarNodo.TabIndex = 1;
            BtnInsertarNodo.Text = "Insertar nodo";
            BtnInsertarNodo.UseVisualStyleBackColor = false;
            BtnInsertarNodo.Click += BtnInsertarNodo_Click;
            // 
            // BtnBuscarElimNodo
            // 
            BtnBuscarElimNodo.BackColor = SystemColors.ButtonHighlight;
            BtnBuscarElimNodo.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBuscarElimNodo.Image = (Image)resources.GetObject("BtnBuscarElimNodo.Image");
            BtnBuscarElimNodo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscarElimNodo.Location = new Point(30, 176);
            BtnBuscarElimNodo.Name = "BtnBuscarElimNodo";
            BtnBuscarElimNodo.Size = new Size(149, 35);
            BtnBuscarElimNodo.TabIndex = 2;
            BtnBuscarElimNodo.Text = "Buscar nodo";
            BtnBuscarElimNodo.UseVisualStyleBackColor = false;
            BtnBuscarElimNodo.Click += BtnBuscarElimNodo_Click;
            // 
            // BtnImprimirNodo
            // 
            BtnImprimirNodo.BackColor = SystemColors.ButtonHighlight;
            BtnImprimirNodo.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnImprimirNodo.Image = (Image)resources.GetObject("BtnImprimirNodo.Image");
            BtnImprimirNodo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnImprimirNodo.Location = new Point(125, 356);
            BtnImprimirNodo.Name = "BtnImprimirNodo";
            BtnImprimirNodo.Size = new Size(169, 35);
            BtnImprimirNodo.TabIndex = 3;
            BtnImprimirNodo.Text = "Imprimir Arbol";
            BtnImprimirNodo.UseVisualStyleBackColor = false;
            BtnImprimirNodo.Click += BtnImprimirNodo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(199, 106);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 4;
            label2.Text = "Digite el nodo a insertar";
            // 
            // TxBIngresarnodo
            // 
            TxBIngresarnodo.Location = new Point(345, 103);
            TxBIngresarnodo.Name = "TxBIngresarnodo";
            TxBIngresarnodo.Size = new Size(100, 23);
            TxBIngresarnodo.TabIndex = 5;
            // 
            // TxBEliminiraBuscarNodo
            // 
            TxBEliminiraBuscarNodo.Location = new Point(354, 184);
            TxBEliminiraBuscarNodo.Name = "TxBEliminiraBuscarNodo";
            TxBEliminiraBuscarNodo.Size = new Size(100, 23);
            TxBEliminiraBuscarNodo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(209, 187);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 6;
            label3.Text = "Digite el nodo a buscar  ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 294);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            label4.Click += label4_Click;
            // 
            // treeView1
            // 
            treeView1.BackColor = SystemColors.InactiveCaption;
            treeView1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            treeView1.Location = new Point(407, 356);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(377, 216);
            treeView1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(503, 323);
            label5.Name = "label5";
            label5.Size = new Size(154, 30);
            label5.TabIndex = 10;
            label5.Text = "Vista del Arbol";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(30, 258);
            button1.Name = "button1";
            button1.Size = new Size(157, 35);
            button1.TabIndex = 11;
            button1.Text = "Eliminar nodo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TxBEliminar
            // 
            TxBEliminar.Location = new Point(362, 266);
            TxBEliminar.Name = "TxBEliminar";
            TxBEliminar.Size = new Size(100, 23);
            TxBEliminar.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(209, 269);
            label6.Name = "label6";
            label6.Size = new Size(147, 15);
            label6.TabIndex = 12;
            label6.Text = "Digite el nodo a Eliminar  ";
            // 
            // FrmArboles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(806, 584);
            Controls.Add(TxBEliminar);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(treeView1);
            Controls.Add(label4);
            Controls.Add(TxBEliminiraBuscarNodo);
            Controls.Add(label3);
            Controls.Add(TxBIngresarnodo);
            Controls.Add(label2);
            Controls.Add(BtnImprimirNodo);
            Controls.Add(BtnBuscarElimNodo);
            Controls.Add(BtnInsertarNodo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmArboles";
            Text = "FrmArboles";
            Load += FrmArboles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnInsertarNodo;
        private Button BtnBuscarElimNodo;
        private Button BtnImprimirNodo;
        private Label label2;
        private TextBox TxBIngresarnodo;
        private TextBox TxBEliminiraBuscarNodo;
        private Label label3;
        private Label label4;
        private TreeView treeView1;
        private Label label5;
        private Button button1;
        private TextBox TxBEliminar;
        private Label label6;
    }
}