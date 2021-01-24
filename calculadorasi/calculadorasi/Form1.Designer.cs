namespace calculadorasi
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
            this.cbxOperacion = new System.Windows.Forms.ComboBox();
            this.lblv1 = new System.Windows.Forms.Label();
            this.lblv2 = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.cmdResultado = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxOperacion
            // 
            this.cbxOperacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOperacion.FormattingEnabled = true;
            this.cbxOperacion.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División"});
            this.cbxOperacion.Location = new System.Drawing.Point(319, 238);
            this.cbxOperacion.Name = "cbxOperacion";
            this.cbxOperacion.Size = new System.Drawing.Size(152, 27);
            this.cbxOperacion.TabIndex = 0;
            // 
            // lblv1
            // 
            this.lblv1.AutoSize = true;
            this.lblv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblv1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblv1.Location = new System.Drawing.Point(215, 91);
            this.lblv1.Name = "lblv1";
            this.lblv1.Size = new System.Drawing.Size(56, 18);
            this.lblv1.TabIndex = 1;
            this.lblv1.Text = "Valor 1";
            // 
            // lblv2
            // 
            this.lblv2.AutoSize = true;
            this.lblv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblv2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblv2.Location = new System.Drawing.Point(215, 161);
            this.lblv2.Name = "lblv2";
            this.lblv2.Size = new System.Drawing.Size(56, 18);
            this.lblv2.TabIndex = 2;
            this.lblv2.Text = "Valor 2";
            // 
            // txtv1
            // 
            this.txtv1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtv1.Location = new System.Drawing.Point(319, 94);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(100, 27);
            this.txtv1.TabIndex = 3;
            // 
            // txtv2
            // 
            this.txtv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtv2.Location = new System.Drawing.Point(319, 162);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(100, 24);
            this.txtv2.TabIndex = 4;
            this.txtv2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmdResultado
            // 
            this.cmdResultado.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResultado.Location = new System.Drawing.Point(547, 81);
            this.cmdResultado.Name = "cmdResultado";
            this.cmdResultado.Size = new System.Drawing.Size(94, 38);
            this.cmdResultado.TabIndex = 5;
            this.cmdResultado.Text = "Resultado";
            this.cmdResultado.UseVisualStyleBackColor = true;
            this.cmdResultado.Click += new System.EventHandler(this.cmdResultado_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(587, 132);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(16, 17);
            this.lblRes.TabIndex = 6;
            this.lblRes.Text = "0";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblOp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(215, 241);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(72, 18);
            this.lblOp.TabIndex = 7;
            this.lblOp.Text = "Operación";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.cmdResultado);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.lblv2);
            this.Controls.Add(this.lblv1);
            this.Controls.Add(this.cbxOperacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxOperacion;
        private System.Windows.Forms.Label lblv1;
        private System.Windows.Forms.Label lblv2;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.TextBox txtv2;
        private System.Windows.Forms.Button cmdResultado;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblOp;
    }
}

