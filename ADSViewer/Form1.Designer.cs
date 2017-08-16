namespace ADSViewer
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
            this.components = new System.ComponentModel.Container();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.GObtn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnStart = new System.Windows.Forms.Button();
            this.STOPbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(13, 13);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(682, 20);
            this.urlTB.TabIndex = 0;
            // 
            // GObtn
            // 
            this.GObtn.Location = new System.Drawing.Point(702, 13);
            this.GObtn.Name = "GObtn";
            this.GObtn.Size = new System.Drawing.Size(75, 23);
            this.GObtn.TabIndex = 1;
            this.GObtn.Text = "GO";
            this.GObtn.UseVisualStyleBackColor = true;
            this.GObtn.Click += new System.EventHandler(this.GObtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 39);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1055, 481);
            this.webBrowser1.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(811, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // STOPbtn
            // 
            this.STOPbtn.Location = new System.Drawing.Point(909, 9);
            this.STOPbtn.Name = "STOPbtn";
            this.STOPbtn.Size = new System.Drawing.Size(75, 23);
            this.STOPbtn.TabIndex = 5;
            this.STOPbtn.Text = "STOP";
            this.STOPbtn.UseVisualStyleBackColor = true;
            this.STOPbtn.Click += new System.EventHandler(this.STOPbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 524);
            this.Controls.Add(this.STOPbtn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.GObtn);
            this.Controls.Add(this.urlTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.Button GObtn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button STOPbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

