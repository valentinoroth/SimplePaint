namespace SimplePaint
{
    partial class PaintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.DrawingPanel = new System.Windows.Forms.PictureBox();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnLigne = new System.Windows.Forms.ToolStripButton();
            this.btnCarre = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolScripColorButton1 = new SimplePaint.ToolScripColorButton();
            this.toolStripDashStyleMenu1 = new SimplePaint.ToolStripDashStyleMenu();
            this.toolStripNumericUpDown1 = new SimplePaint.ToolStripNumericUpDown();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingPanel)).BeginInit();
            this.ToolStrip.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.DrawingPanel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.ToolStrip);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.Color.White;
            this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingPanel.Location = new System.Drawing.Point(0, 0);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(800, 425);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.TabStop = false;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            this.DrawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
            this.DrawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseUp);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLigne,
            this.btnCarre,
            this.btnEllipse});
            this.ToolStrip.Location = new System.Drawing.Point(3, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(81, 25);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnLigne
            // 
            this.btnLigne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLigne.Image = ((System.Drawing.Image)(resources.GetObject("btnLigne.Image")));
            this.btnLigne.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLigne.Name = "btnLigne";
            this.btnLigne.Size = new System.Drawing.Size(23, 22);
            this.btnLigne.Text = "toolStripButton1";
            // 
            // btnCarre
            // 
            this.btnCarre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCarre.Image = ((System.Drawing.Image)(resources.GetObject("btnCarre.Image")));
            this.btnCarre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCarre.Name = "btnCarre";
            this.btnCarre.Size = new System.Drawing.Size(23, 22);
            this.btnCarre.Text = "toolStripButton1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolScripColorButton1,
            this.toolStripDashStyleMenu1,
            this.toolStripNumericUpDown1});
            this.toolStrip2.Location = new System.Drawing.Point(84, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(152, 25);
            this.toolStrip2.TabIndex = 1;
            // 
            // btnEllipse
            // 
            this.btnEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnEllipse.Image")));
            this.btnEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(23, 22);
            this.btnEllipse.Text = "toolStripButton1";
            // 
            // toolScripColorButton1
            // 
            this.toolScripColorButton1.ColorRectangle = new System.Drawing.Rectangle(0, 13, 16, 3);
            this.toolScripColorButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolScripColorButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolScripColorButton1.Image")));
            this.toolScripColorButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolScripColorButton1.Name = "toolScripColorButton1";
            this.toolScripColorButton1.SelectedColor = System.Drawing.Color.Aqua;
            this.toolScripColorButton1.Size = new System.Drawing.Size(23, 22);
            this.toolScripColorButton1.Text = "toolScripColorButton1";
            // 
            // toolStripDashStyleMenu1
            // 
            this.toolStripDashStyleMenu1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDashStyleMenu1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDashStyleMenu1.Image")));
            this.toolStripDashStyleMenu1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDashStyleMenu1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDashStyleMenu1.Name = "toolStripDashStyleMenu1";
            this.toolStripDashStyleMenu1.SelectedDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.toolStripDashStyleMenu1.Size = new System.Drawing.Size(45, 22);
            this.toolStripDashStyleMenu1.Text = "toolStripDashStyleMenu1";
            // 
            // toolStripNumericUpDown1
            // 
            this.toolStripNumericUpDown1.Name = "toolStripNumericUpDown1";
            this.toolStripNumericUpDown1.Size = new System.Drawing.Size(41, 22);
            this.toolStripNumericUpDown1.Text = "0";
            this.toolStripNumericUpDown1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "PaintForm";
            this.Text = "Form1";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingPanel)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.PictureBox DrawingPanel;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton btnLigne;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private ToolScripColorButton toolScripColorButton1;
        private System.Windows.Forms.ToolStripButton btnCarre;
        private System.Windows.Forms.ToolStripButton btnEllipse;
        private ToolStripDashStyleMenu toolStripDashStyleMenu1;
        private ToolStripNumericUpDown toolStripNumericUpDown1;
    }
}