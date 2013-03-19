namespace SpriteGenerator
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numHorizontalItemCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImagesFolderName = new System.Windows.Forms.TextBox();
            this.txtIconClassName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlItems = new System.Windows.Forms.FlowLayoutPanel();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOutputFolderChooser = new System.Windows.Forms.Button();
            this.txtSpriteImageName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtItemSource = new System.Windows.Forms.TextBox();
            this.btnItemSourceChooser = new System.Windows.Forms.Button();
            this.fItemChooser = new System.Windows.Forms.OpenFileDialog();
            this.fOutputChooser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizontalItemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Width:";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(79, 7);
            this.numWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(35, 20);
            this.numWidth.TabIndex = 1;
            this.numWidth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item Height:";
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(193, 7);
            this.numHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(35, 20);
            this.numHeight.TabIndex = 1;
            this.numHeight.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numHeight.ValueChanged += new System.EventHandler(this.numHeight_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horizontal Item Count:";
            // 
            // numHorizontalItemCount
            // 
            this.numHorizontalItemCount.Location = new System.Drawing.Point(369, 7);
            this.numHorizontalItemCount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numHorizontalItemCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHorizontalItemCount.Name = "numHorizontalItemCount";
            this.numHorizontalItemCount.Size = new System.Drawing.Size(35, 20);
            this.numHorizontalItemCount.TabIndex = 3;
            this.numHorizontalItemCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHorizontalItemCount.ValueChanged += new System.EventHandler(this.numHorizontalItemCount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Images Folder Name:";
            // 
            // txtImagesFolderName
            // 
            this.txtImagesFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImagesFolderName.Location = new System.Drawing.Point(128, 59);
            this.txtImagesFolderName.Name = "txtImagesFolderName";
            this.txtImagesFolderName.Size = new System.Drawing.Size(296, 20);
            this.txtImagesFolderName.TabIndex = 5;
            this.txtImagesFolderName.Text = "images";
            // 
            // txtIconClassName
            // 
            this.txtIconClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIconClassName.Location = new System.Drawing.Point(128, 85);
            this.txtIconClassName.Name = "txtIconClassName";
            this.txtIconClassName.Size = new System.Drawing.Size(296, 20);
            this.txtIconClassName.TabIndex = 7;
            this.txtIconClassName.Text = "icon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Icon Class Name:";
            // 
            // pnlItems
            // 
            this.pnlItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlItems.AutoScroll = true;
            this.pnlItems.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItems.Location = new System.Drawing.Point(18, 136);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Padding = new System.Windows.Forms.Padding(2);
            this.pnlItems.Size = new System.Drawing.Size(406, 357);
            this.pnlItems.TabIndex = 9;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputFolder.Location = new System.Drawing.Point(128, 33);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(253, 20);
            this.txtOutputFolder.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Output Folder:";
            // 
            // btnOutputFolderChooser
            // 
            this.btnOutputFolderChooser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputFolderChooser.Location = new System.Drawing.Point(388, 31);
            this.btnOutputFolderChooser.Name = "btnOutputFolderChooser";
            this.btnOutputFolderChooser.Size = new System.Drawing.Size(36, 23);
            this.btnOutputFolderChooser.TabIndex = 12;
            this.btnOutputFolderChooser.Text = "...";
            this.btnOutputFolderChooser.UseVisualStyleBackColor = true;
            this.btnOutputFolderChooser.Click += new System.EventHandler(this.btnOutputFolderChooser_Click);
            // 
            // txtSpriteImageName
            // 
            this.txtSpriteImageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpriteImageName.Location = new System.Drawing.Point(128, 110);
            this.txtSpriteImageName.Name = "txtSpriteImageName";
            this.txtSpriteImageName.Size = new System.Drawing.Size(262, 20);
            this.txtSpriteImageName.TabIndex = 14;
            this.txtSpriteImageName.Text = "sprite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sprite Image Name:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = ".png";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(349, 528);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtItemName.Location = new System.Drawing.Point(58, 501);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(142, 20);
            this.txtItemName.TabIndex = 18;
            this.txtItemName.Leave += new System.EventHandler(this.txtItemName_Leave);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Source:";
            // 
            // txtItemSource
            // 
            this.txtItemSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemSource.Location = new System.Drawing.Point(254, 501);
            this.txtItemSource.Name = "txtItemSource";
            this.txtItemSource.Size = new System.Drawing.Size(127, 20);
            this.txtItemSource.TabIndex = 18;
            this.txtItemSource.Leave += new System.EventHandler(this.txtItemSource_Leave);
            // 
            // btnItemSourceChooser
            // 
            this.btnItemSourceChooser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemSourceChooser.Location = new System.Drawing.Point(387, 499);
            this.btnItemSourceChooser.Name = "btnItemSourceChooser";
            this.btnItemSourceChooser.Size = new System.Drawing.Size(36, 23);
            this.btnItemSourceChooser.TabIndex = 19;
            this.btnItemSourceChooser.Text = "...";
            this.btnItemSourceChooser.UseVisualStyleBackColor = true;
            this.btnItemSourceChooser.Click += new System.EventHandler(this.btnItemSourceChooser_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(268, 528);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(18, 528);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 21;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 561);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnItemSourceChooser);
            this.Controls.Add(this.txtItemSource);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSpriteImageName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOutputFolderChooser);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.txtIconClassName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImagesFolderName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numHorizontalItemCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Sprite Generator - ETEN";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizontalItemCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHorizontalItemCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImagesFolderName;
        private System.Windows.Forms.TextBox txtIconClassName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel pnlItems;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOutputFolderChooser;
        private System.Windows.Forms.TextBox txtSpriteImageName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtItemSource;
        private System.Windows.Forms.Button btnItemSourceChooser;
        private System.Windows.Forms.OpenFileDialog fItemChooser;
        private System.Windows.Forms.FolderBrowserDialog fOutputChooser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

