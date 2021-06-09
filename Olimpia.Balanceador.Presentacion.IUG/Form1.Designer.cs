namespace WindowsLiderEntrega
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
      this.btnCalcular = new System.Windows.Forms.Button();
      this.lblTiempoTotal = new System.Windows.Forms.Label();
      this.lblTiempo = new System.Windows.Forms.Label();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblCantCtas = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCalcular
      // 
      this.btnCalcular.Location = new System.Drawing.Point(12, 25);
      this.btnCalcular.Name = "btnCalcular";
      this.btnCalcular.Size = new System.Drawing.Size(75, 23);
      this.btnCalcular.TabIndex = 0;
      this.btnCalcular.Text = "Calcular";
      this.btnCalcular.UseVisualStyleBackColor = true;
      this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
      // 
      // lblTiempoTotal
      // 
      this.lblTiempoTotal.AutoSize = true;
      this.lblTiempoTotal.Location = new System.Drawing.Point(234, 30);
      this.lblTiempoTotal.Name = "lblTiempoTotal";
      this.lblTiempoTotal.Size = new System.Drawing.Size(0, 13);
      this.lblTiempoTotal.TabIndex = 1;
      // 
      // lblTiempo
      // 
      this.lblTiempo.AutoSize = true;
      this.lblTiempo.Location = new System.Drawing.Point(150, 30);
      this.lblTiempo.Name = "lblTiempo";
      this.lblTiempo.Size = new System.Drawing.Size(69, 13);
      this.lblTiempo.TabIndex = 2;
      this.lblTiempo.Text = "Tiempo Total";
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(91, 66);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(305, 23);
      this.progressBar1.TabIndex = 4;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(46, 141);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(252, 150);
      this.dataGridView1.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(150, 101);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Balance de Cuentas";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(43, 125);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(109, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Cantidad de Cuentas:";
      // 
      // lblCantCtas
      // 
      this.lblCantCtas.AutoSize = true;
      this.lblCantCtas.Location = new System.Drawing.Point(150, 125);
      this.lblCantCtas.Name = "lblCantCtas";
      this.lblCantCtas.Size = new System.Drawing.Size(13, 13);
      this.lblCantCtas.TabIndex = 8;
      this.lblCantCtas.Text = "0";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(481, 321);
      this.Controls.Add(this.lblCantCtas);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.lblTiempo);
      this.Controls.Add(this.lblTiempoTotal);
      this.Controls.Add(this.btnCalcular);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Prueba Lider";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTiempoTotal;
        private System.Windows.Forms.Label lblTiempo;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblCantCtas;
  }
}

