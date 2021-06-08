
namespace Geome_0317
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.triangulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorfulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isConvex = new System.Windows.Forms.ToolStripMenuItem();
            this.hullsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grahamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jarvisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickHullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divideAndConquerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCordinatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intersection = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1136, 518);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.output);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1145, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 331);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Size:";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 32);
            this.textBox1.TabIndex = 2;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(-3, 151);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(149, 84);
            this.output.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 38);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 28);
            this.textBox2.TabIndex = 24;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1297, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPointsToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.hullsToolStripMenuItem,
            this.clearToolStripMenuItem1,
            this.extraToolStripMenuItem,
            this.editToolStripMenuItem,
            this.diagramToolStripMenuItem,
            this.intersection,
            this.testToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // addPointsToolStripMenuItem
            // 
            this.addPointsToolStripMenuItem.Name = "addPointsToolStripMenuItem";
            this.addPointsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.addPointsToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.addPointsToolStripMenuItem.Text = "Add Points";
            this.addPointsToolStripMenuItem.Click += new System.EventHandler(this.btn_addPoint_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawPolygon,
            this.triangulationToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.dualToolStripMenuItem,
            this.colorfulToolStripMenuItem,
            this.isConvex});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.clearToolStripMenuItem.Text = "Polygon";
            // 
            // drawPolygon
            // 
            this.drawPolygon.Name = "drawPolygon";
            this.drawPolygon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.drawPolygon.Size = new System.Drawing.Size(229, 26);
            this.drawPolygon.Text = "Draw";
            this.drawPolygon.Click += new System.EventHandler(this.draw_polygon_Click);
            // 
            // triangulationToolStripMenuItem
            // 
            this.triangulationToolStripMenuItem.Name = "triangulationToolStripMenuItem";
            this.triangulationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.triangulationToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.triangulationToolStripMenuItem.Text = "Triangulation";
            this.triangulationToolStripMenuItem.Click += new System.EventHandler(this.button_Triangulate_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.colorToolStripMenuItem.Text = "3color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.button_3color_Click);
            // 
            // dualToolStripMenuItem
            // 
            this.dualToolStripMenuItem.Name = "dualToolStripMenuItem";
            this.dualToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dualToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.dualToolStripMenuItem.Text = "dual";
            this.dualToolStripMenuItem.Click += new System.EventHandler(this.button_Dual_Click);
            // 
            // colorfulToolStripMenuItem
            // 
            this.colorfulToolStripMenuItem.Name = "colorfulToolStripMenuItem";
            this.colorfulToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.colorfulToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.colorfulToolStripMenuItem.Text = "Colorful";
            this.colorfulToolStripMenuItem.Click += new System.EventHandler(this.button_Colorful_Click);
            // 
            // isConvex
            // 
            this.isConvex.Name = "isConvex";
            this.isConvex.Size = new System.Drawing.Size(229, 26);
            this.isConvex.Text = "Is Convex?";
            this.isConvex.Click += new System.EventHandler(this.isConvex_Click);
            // 
            // hullsToolStripMenuItem
            // 
            this.hullsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grahamToolStripMenuItem,
            this.jarvisToolStripMenuItem,
            this.quickHullToolStripMenuItem,
            this.divideAndConquerToolStripMenuItem});
            this.hullsToolStripMenuItem.Name = "hullsToolStripMenuItem";
            this.hullsToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.hullsToolStripMenuItem.Text = "Hulls";
            // 
            // grahamToolStripMenuItem
            // 
            this.grahamToolStripMenuItem.Name = "grahamToolStripMenuItem";
            this.grahamToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.grahamToolStripMenuItem.Text = "Graham";
            this.grahamToolStripMenuItem.Click += new System.EventHandler(this.button_Graham_Click);
            // 
            // jarvisToolStripMenuItem
            // 
            this.jarvisToolStripMenuItem.Name = "jarvisToolStripMenuItem";
            this.jarvisToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.jarvisToolStripMenuItem.Text = "Jarvis";
            this.jarvisToolStripMenuItem.Click += new System.EventHandler(this.button_Jarvis_Click);
            // 
            // quickHullToolStripMenuItem
            // 
            this.quickHullToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.separatorLineToolStripMenuItem});
            this.quickHullToolStripMenuItem.Name = "quickHullToolStripMenuItem";
            this.quickHullToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quickHullToolStripMenuItem.Text = "Quick Hull";
            this.quickHullToolStripMenuItem.Click += new System.EventHandler(this.button_QuickHull_Click);
            // 
            // separatorLineToolStripMenuItem
            // 
            this.separatorLineToolStripMenuItem.Name = "separatorLineToolStripMenuItem";
            this.separatorLineToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.separatorLineToolStripMenuItem.Text = "separator line";
            // 
            // divideAndConquerToolStripMenuItem
            // 
            this.divideAndConquerToolStripMenuItem.Name = "divideAndConquerToolStripMenuItem";
            this.divideAndConquerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.divideAndConquerToolStripMenuItem.Text = "Divide and Conquer";
            this.divideAndConquerToolStripMenuItem.Click += new System.EventHandler(this.button_DivideEtConquer_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(255, 26);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCordinatesToolStripMenuItem,
            this.discoToolStripMenuItem});
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // showCordinatesToolStripMenuItem
            // 
            this.showCordinatesToolStripMenuItem.Name = "showCordinatesToolStripMenuItem";
            this.showCordinatesToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.showCordinatesToolStripMenuItem.Text = "Show Cordinates";
            this.showCordinatesToolStripMenuItem.Click += new System.EventHandler(this.button_ShowCoordonates_Click);
            // 
            // discoToolStripMenuItem
            // 
            this.discoToolStripMenuItem.Name = "discoToolStripMenuItem";
            this.discoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.discoToolStripMenuItem.Text = "Disco";
            this.discoToolStripMenuItem.Click += new System.EventHandler(this.button_Disco_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uNDOToolStripMenuItem,
            this.rEDOToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // uNDOToolStripMenuItem
            // 
            this.uNDOToolStripMenuItem.Name = "uNDOToolStripMenuItem";
            this.uNDOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.uNDOToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.uNDOToolStripMenuItem.Text = "UNDO";
            this.uNDOToolStripMenuItem.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // rEDOToolStripMenuItem
            // 
            this.rEDOToolStripMenuItem.Name = "rEDOToolStripMenuItem";
            this.rEDOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rEDOToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.rEDOToolStripMenuItem.Text = "REDO";
            // 
            // diagramToolStripMenuItem
            // 
            this.diagramToolStripMenuItem.Name = "diagramToolStripMenuItem";
            this.diagramToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.diagramToolStripMenuItem.Text = "diagram";
            this.diagramToolStripMenuItem.Click += new System.EventHandler(this.diagramToolStripMenuItem_Click);
            // 
            // intersection
            // 
            this.intersection.Name = "intersection";
            this.intersection.Size = new System.Drawing.Size(255, 26);
            this.intersection.Text = "intersection";
            this.intersection.Click += new System.EventHandler(this.intersection_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.button_test_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1297, 524);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawPolygon;
        private System.Windows.Forms.ToolStripMenuItem triangulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorfulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hullsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grahamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jarvisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickHullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem separatorLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divideAndConquerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCordinatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discoToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isConvex;
        private System.Windows.Forms.ToolStripMenuItem diagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intersection;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}

