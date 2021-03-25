using System.Windows.Forms;

namespace GameOfLife
{
    partial class MainWindow
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
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.BoardWidth = new System.Windows.Forms.NumericUpDown();
            this.BoardHeight = new System.Windows.Forms.NumericUpDown();
            this.BoardSizeDesc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Board = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.Button();
            this.BoardCreationStatus = new System.Windows.Forms.ProgressBar();
            this.Create = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.generationDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoardWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(31, 470);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(94, 29);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.startClick);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(131, 470);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(94, 29);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.stopClick);
            // 
            // BoardWidth
            // 
            this.BoardWidth.Location = new System.Drawing.Point(634, 472);
            this.BoardWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BoardWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BoardWidth.Name = "BoardWidth";
            this.BoardWidth.Size = new System.Drawing.Size(74, 27);
            this.BoardWidth.TabIndex = 2;
            this.BoardWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // BoardHeight
            // 
            this.BoardHeight.Location = new System.Drawing.Point(735, 472);
            this.BoardHeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BoardHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BoardHeight.Name = "BoardHeight";
            this.BoardHeight.Size = new System.Drawing.Size(74, 27);
            this.BoardHeight.TabIndex = 3;
            this.BoardHeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // BoardSizeDesc
            // 
            this.BoardSizeDesc.AutoSize = true;
            this.BoardSizeDesc.Location = new System.Drawing.Point(545, 474);
            this.BoardSizeDesc.Name = "BoardSizeDesc";
            this.BoardSizeDesc.Size = new System.Drawing.Size(83, 20);
            this.BoardSizeDesc.TabIndex = 4;
            this.BoardSizeDesc.Text = "Board Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "x";
            // 
            // Board
            // 
            this.Board.Location = new System.Drawing.Point(13, 13);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(894, 451);
            this.Board.TabIndex = 6;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(231, 470);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(94, 29);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.resetClick);
            // 
            // BoardCreationStatus
            // 
            this.BoardCreationStatus.Location = new System.Drawing.Point(353, 470);
            this.BoardCreationStatus.Name = "BoardCreationStatus";
            this.BoardCreationStatus.Size = new System.Drawing.Size(186, 29);
            this.BoardCreationStatus.Step = 1;
            this.BoardCreationStatus.TabIndex = 8;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(827, 470);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(80, 29);
            this.Create.TabIndex = 9;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.createClick);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(31, 510);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(325, 20);
            this.InfoLabel.TabIndex = 10;
            this.InfoLabel.Text = "Choose a size and click create to create a Board";
            // 
            // generationDelay
            // 
            this.generationDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.generationDelay.Location = new System.Drawing.Point(735, 503);
            this.generationDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.generationDelay.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.generationDelay.Name = "generationDelay";
            this.generationDelay.Size = new System.Drawing.Size(74, 27);
            this.generationDelay.TabIndex = 11;
            this.generationDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.generationDelay.Click += new System.EventHandler(generationDelayChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "New Generation every";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(827, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "ms";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 532);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generationDelay);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.BoardCreationStatus);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoardSizeDesc);
            this.Controls.Add(this.BoardHeight);
            this.Controls.Add(this.BoardWidth);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.BoardWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Button Start;
        private Button Stop;
        private NumericUpDown BoardWidth;
        private NumericUpDown BoardHeight;
        private Label BoardSizeDesc;
        private Label label2;
        private Panel Board;
        private Button Reset;
        private ProgressBar BoardCreationStatus;
        private Button Create;
        private Label InfoLabel;
        private NumericUpDown generationDelay;
        private Label label1;
        private Label label3;
    }
}

