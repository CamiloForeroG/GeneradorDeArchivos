namespace GeneradorDeArchivos
{
    partial class Comparaciones
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OriginalFile = new SyncTextBox();
            this.GeneratedFile = new SyncTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.OriginalFile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.GeneratedFile);
            this.splitContainer1.Size = new System.Drawing.Size(1855, 542);
            this.splitContainer1.SplitterDistance = 923;
            this.splitContainer1.TabIndex = 0;
            // 
            // OriginalFile
            // 
            this.OriginalFile.Buddy = this.GeneratedFile;
            this.OriginalFile.Location = new System.Drawing.Point(3, 41);
            this.OriginalFile.Multiline = true;
            this.OriginalFile.Name = "OriginalFile";
            this.OriginalFile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;//System.Windows.Forms.ScrollBars.Vertical;
            this.OriginalFile.Size = new System.Drawing.Size(910, 489);
            this.OriginalFile.TabIndex = 0;
            // 
            // GeneratedFile
            // 
            this.GeneratedFile.Buddy = this.OriginalFile;
            this.GeneratedFile.Location = new System.Drawing.Point(12, 41);
            this.GeneratedFile.Multiline = true;
            this.GeneratedFile.Name = "GeneratedFile";
            this.GeneratedFile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;//System.Windows.Forms.ScrollBars.Vertical;
            this.GeneratedFile.Size = new System.Drawing.Size(903, 489);
            this.GeneratedFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Archivo Original:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Archivo Generado:";
            // 
            // Comparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1855, 542);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Comparaciones";
            this.Text = "Comparaciones";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private SyncTextBox GeneratedFile;//System.Windows.Forms.RichTextBox GeneratedFile;
        private SyncTextBox OriginalFile;//System.Windows.Forms.RichTextBox OriginalFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}