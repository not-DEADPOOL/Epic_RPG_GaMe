namespace visuale_rpg
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLeftArrow = new System.Windows.Forms.Button();
            this.btnRightArrow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbPersonaggio = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonaggio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeftArrow
            // 
            this.btnLeftArrow.Location = new System.Drawing.Point(87, 280);
            this.btnLeftArrow.Name = "btnLeftArrow";
            this.btnLeftArrow.Size = new System.Drawing.Size(28, 23);
            this.btnLeftArrow.TabIndex = 0;
            this.btnLeftArrow.Text = "<";
            this.btnLeftArrow.UseVisualStyleBackColor = true;
            this.btnLeftArrow.Click += new System.EventHandler(this.btnLeftArrow_Click);
            // 
            // btnRightArrow
            // 
            this.btnRightArrow.Location = new System.Drawing.Point(321, 280);
            this.btnRightArrow.Name = "btnRightArrow";
            this.btnRightArrow.Size = new System.Drawing.Size(28, 23);
            this.btnRightArrow.TabIndex = 1;
            this.btnRightArrow.Text = ">";
            this.btnRightArrow.UseVisualStyleBackColor = true;
            this.btnRightArrow.Click += new System.EventHandler(this.btnRightArrow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Location = new System.Drawing.Point(121, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Green;
            this.btnPlay.Location = new System.Drawing.Point(121, 251);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(194, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pbPersonaggio
            // 
            this.pbPersonaggio.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonaggio.Image")));
            this.pbPersonaggio.Location = new System.Drawing.Point(121, 12);
            this.pbPersonaggio.Name = "pbPersonaggio";
            this.pbPersonaggio.Size = new System.Drawing.Size(194, 193);
            this.pbPersonaggio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonaggio.TabIndex = 4;
            this.pbPersonaggio.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(121, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mont Heavy DEMO", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(92, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Crea il tuo Party!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbPersonaggio);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRightArrow);
            this.Controls.Add(this.btnLeftArrow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 408);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(455, 408);
            this.Name = "Form1";
            this.Text = "RPG GAME";
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonaggio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeftArrow;
        private System.Windows.Forms.Button btnRightArrow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pbPersonaggio;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

