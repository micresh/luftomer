namespace ROTCHAK_Luft
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btntest = new System.Windows.Forms.ToolStripButton();
            this.btnpref = new System.Windows.Forms.ToolStripButton();
            this.btndb = new System.Windows.Forms.ToolStripButton();
            this.btnexit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(969, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btntest,
            this.btnpref,
            this.btndb,
            this.btnexit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(969, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "Панель элементов";
            // 
            // btntest
            // 
            this.btntest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntest.Image = ((System.Drawing.Image)(resources.GetObject("btntest.Image")));
            this.btntest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(23, 22);
            this.btntest.Text = "Тестирование";
            this.btntest.Click += new System.EventHandler(this.btntest_Click_1);
            // 
            // btnpref
            // 
            this.btnpref.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnpref.Image = ((System.Drawing.Image)(resources.GetObject("btnpref.Image")));
            this.btnpref.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnpref.Name = "btnpref";
            this.btnpref.Size = new System.Drawing.Size(23, 22);
            this.btnpref.Text = "Настройки";
            this.btnpref.Click += new System.EventHandler(this.btnpref_Click_1);
            // 
            // btndb
            // 
            this.btndb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btndb.Image = ((System.Drawing.Image)(resources.GetObject("btndb.Image")));
            this.btndb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndb.Name = "btndb";
            this.btndb.Size = new System.Drawing.Size(23, 22);
            this.btndb.Text = "База данных";
            this.btndb.Click += new System.EventHandler(this.btndb_Click);
            // 
            // btnexit
            // 
            this.btnexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(23, 22);
            this.btnexit.Text = "Выход";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click_1);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 483);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Name = "mainform";
            this.Text = "ROTCHAK Люфт";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btntest;
        private System.Windows.Forms.ToolStripButton btnpref;
        private System.Windows.Forms.ToolStripButton btndb;
        private System.Windows.Forms.ToolStripButton btnexit;
    }
}

