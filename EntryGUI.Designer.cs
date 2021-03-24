namespace GameOfLife
{
    partial class EntryGUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblGenerations = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.numGenerations = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(31, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(241, 44);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Willkommen";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(36, 88);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(224, 17);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Bitte gewünschte Werte eingeben.";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(36, 141);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(90, 17);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Feldgroesse:";
            // 
            // lblGenerations
            // 
            this.lblGenerations.AutoSize = true;
            this.lblGenerations.Location = new System.Drawing.Point(36, 191);
            this.lblGenerations.Name = "lblGenerations";
            this.lblGenerations.Size = new System.Drawing.Size(99, 17);
            this.lblGenerations.TabIndex = 3;
            this.lblGenerations.Text = "Generationen:";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOk.Location = new System.Drawing.Point(39, 257);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(221, 52);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Okay";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(150, 141);
            this.numX.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numX.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(46, 22);
            this.numX.TabIndex = 5;
            this.numX.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // numGenerations
            // 
            this.numGenerations.Location = new System.Drawing.Point(150, 186);
            this.numGenerations.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numGenerations.Name = "numGenerations";
            this.numGenerations.Size = new System.Drawing.Size(46, 22);
            this.numGenerations.TabIndex = 6;
            this.numGenerations.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(273, 141);
            this.numY.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numY.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(46, 22);
            this.numY.TabIndex = 7;
            this.numY.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(229, 146);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 17);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "x";
            // 
            // EntryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 356);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numGenerations);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblGenerations);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EntryGUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblGenerations;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.NumericUpDown numGenerations;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.Label lblX;
    }
}

