namespace AStarWinApp
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAlgorithm = new System.Windows.Forms.ComboBox();
            this.CellGrid = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            this.flowLayoutPanel1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.CellGrid);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(614, 498);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel2.Controls.Add(this.btnStart);
            this.flowLayoutPanel2.Controls.Add(this.btnReset);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.cbAlgorithm);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 3);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(488, 31);
            this.flowLayoutPanel2.TabIndex = 0;
            this.btnStart.Location = new System.Drawing.Point(4, 3);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnReset.Location = new System.Drawing.Point(87, 3);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.label1.Location = new System.Drawing.Point(170, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Algorihtm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAlgorithm.FormattingEnabled = true;
            this.cbAlgorithm.Items.AddRange(new object[] {"A* ", "Dijkstra"});
            this.cbAlgorithm.Location = new System.Drawing.Point(247, 3);
            this.cbAlgorithm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbAlgorithm.Name = "cbAlgorithm";
            this.cbAlgorithm.Size = new System.Drawing.Size(121, 23);
            this.cbAlgorithm.Sorted = true;
            this.cbAlgorithm.TabIndex = 4;
            this.CellGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CellGrid.ColumnCount = 10;
            this.CellGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CellGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CellGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CellGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CellGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CellGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CellGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CellGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CellGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CellGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CellGrid.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.CellGrid.Location = new System.Drawing.Point(4, 40);
            this.CellGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CellGrid.Name = "CellGrid";
            this.CellGrid.RowCount = 10;
            this.CellGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CellGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CellGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CellGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CellGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CellGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CellGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CellGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CellGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CellGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CellGrid.Size = new System.Drawing.Size(606, 449);
            this.CellGrid.TabIndex = 0;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(611, 489);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "A* Visualizer";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAlgorithm;
        private System.Windows.Forms.TableLayoutPanel CellGrid;
    }
}