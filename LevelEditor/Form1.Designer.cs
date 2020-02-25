namespace LevelEditor
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
            this.TilePanel = new System.Windows.Forms.Panel();
            this.ControlsGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TileSizeBox = new System.Windows.Forms.TextBox();
            this.MapYBox = new System.Windows.Forms.TextBox();
            this.MapXBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenMapButton = new System.Windows.Forms.Button();
            this.MapGroupBox = new System.Windows.Forms.GroupBox();
            this.ExportGroup = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MapNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExTileSizeBox = new System.Windows.Forms.TextBox();
            this.ExMapYBox = new System.Windows.Forms.TextBox();
            this.ExMapXBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ToolsBox = new System.Windows.Forms.GroupBox();
            this.NPCModeButton = new System.Windows.Forms.RadioButton();
            this.ItemModeButton = new System.Windows.Forms.RadioButton();
            this.WallModeButton = new System.Windows.Forms.RadioButton();
            this.TileModeButton = new System.Windows.Forms.RadioButton();
            this.EntryModeButton = new System.Windows.Forms.RadioButton();
            this.TriggerModeButton = new System.Windows.Forms.RadioButton();
            this.ExitModeButton = new System.Windows.Forms.RadioButton();
            this.SpawnPointModeButton = new System.Windows.Forms.RadioButton();
            this.ControlsGroup.SuspendLayout();
            this.ExportGroup.SuspendLayout();
            this.ToolsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TilePanel
            // 
            this.TilePanel.BackColor = System.Drawing.Color.Black;
            this.TilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TilePanel.Location = new System.Drawing.Point(1, 171);
            this.TilePanel.Name = "TilePanel";
            this.TilePanel.Size = new System.Drawing.Size(544, 512);
            this.TilePanel.TabIndex = 0;
            // 
            // ControlsGroup
            // 
            this.ControlsGroup.Controls.Add(this.label3);
            this.ControlsGroup.Controls.Add(this.TileSizeBox);
            this.ControlsGroup.Controls.Add(this.MapYBox);
            this.ControlsGroup.Controls.Add(this.MapXBox);
            this.ControlsGroup.Controls.Add(this.label2);
            this.ControlsGroup.Controls.Add(this.label1);
            this.ControlsGroup.Controls.Add(this.GenMapButton);
            this.ControlsGroup.Location = new System.Drawing.Point(1, 0);
            this.ControlsGroup.Name = "ControlsGroup";
            this.ControlsGroup.Size = new System.Drawing.Size(544, 43);
            this.ControlsGroup.TabIndex = 1;
            this.ControlsGroup.TabStop = false;
            this.ControlsGroup.Text = "Generate Map Controls";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tile Size";
            // 
            // TileSizeBox
            // 
            this.TileSizeBox.Location = new System.Drawing.Point(260, 13);
            this.TileSizeBox.Name = "TileSizeBox";
            this.TileSizeBox.Size = new System.Drawing.Size(56, 20);
            this.TileSizeBox.TabIndex = 5;
            // 
            // MapYBox
            // 
            this.MapYBox.Location = new System.Drawing.Point(145, 12);
            this.MapYBox.Name = "MapYBox";
            this.MapYBox.Size = new System.Drawing.Size(56, 20);
            this.MapYBox.TabIndex = 4;
            // 
            // MapXBox
            // 
            this.MapXBox.Location = new System.Drawing.Point(63, 12);
            this.MapXBox.Name = "MapXBox";
            this.MapXBox.Size = new System.Drawing.Size(56, 20);
            this.MapXBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Map Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // GenMapButton
            // 
            this.GenMapButton.Location = new System.Drawing.Point(322, 10);
            this.GenMapButton.Name = "GenMapButton";
            this.GenMapButton.Size = new System.Drawing.Size(75, 23);
            this.GenMapButton.TabIndex = 0;
            this.GenMapButton.Text = "Generate";
            this.GenMapButton.UseVisualStyleBackColor = true;
            this.GenMapButton.Click += new System.EventHandler(this.GenMapButton_Click);
            // 
            // MapGroupBox
            // 
            this.MapGroupBox.BackColor = System.Drawing.Color.Black;
            this.MapGroupBox.Location = new System.Drawing.Point(552, 106);
            this.MapGroupBox.Name = "MapGroupBox";
            this.MapGroupBox.Size = new System.Drawing.Size(687, 512);
            this.MapGroupBox.TabIndex = 2;
            this.MapGroupBox.TabStop = false;
            // 
            // ExportGroup
            // 
            this.ExportGroup.Controls.Add(this.label7);
            this.ExportGroup.Controls.Add(this.MapNameBox);
            this.ExportGroup.Controls.Add(this.label4);
            this.ExportGroup.Controls.Add(this.ExTileSizeBox);
            this.ExportGroup.Controls.Add(this.ExMapYBox);
            this.ExportGroup.Controls.Add(this.ExMapXBox);
            this.ExportGroup.Controls.Add(this.label5);
            this.ExportGroup.Controls.Add(this.label6);
            this.ExportGroup.Controls.Add(this.ExportButton);
            this.ExportGroup.Location = new System.Drawing.Point(551, 0);
            this.ExportGroup.Name = "ExportGroup";
            this.ExportGroup.Size = new System.Drawing.Size(544, 100);
            this.ExportGroup.TabIndex = 7;
            this.ExportGroup.TabStop = false;
            this.ExportGroup.Text = "Export Map Controls";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Map Name";
            // 
            // MapNameBox
            // 
            this.MapNameBox.Location = new System.Drawing.Point(63, 63);
            this.MapNameBox.Name = "MapNameBox";
            this.MapNameBox.Size = new System.Drawing.Size(100, 20);
            this.MapNameBox.TabIndex = 7;
            this.MapNameBox.TextChanged += new System.EventHandler(this.MapNameBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tile Size";
            // 
            // ExTileSizeBox
            // 
            this.ExTileSizeBox.Enabled = false;
            this.ExTileSizeBox.Location = new System.Drawing.Point(63, 36);
            this.ExTileSizeBox.Name = "ExTileSizeBox";
            this.ExTileSizeBox.Size = new System.Drawing.Size(56, 20);
            this.ExTileSizeBox.TabIndex = 5;
            // 
            // ExMapYBox
            // 
            this.ExMapYBox.Enabled = false;
            this.ExMapYBox.Location = new System.Drawing.Point(145, 12);
            this.ExMapYBox.Name = "ExMapYBox";
            this.ExMapYBox.Size = new System.Drawing.Size(56, 20);
            this.ExMapYBox.TabIndex = 4;
            // 
            // ExMapXBox
            // 
            this.ExMapXBox.Enabled = false;
            this.ExMapXBox.Location = new System.Drawing.Point(63, 12);
            this.ExMapXBox.Name = "ExMapXBox";
            this.ExMapXBox.Size = new System.Drawing.Size(56, 20);
            this.ExMapXBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Map Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "X";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(207, 9);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ToolsBox
            // 
            this.ToolsBox.Controls.Add(this.EntryModeButton);
            this.ToolsBox.Controls.Add(this.TriggerModeButton);
            this.ToolsBox.Controls.Add(this.ExitModeButton);
            this.ToolsBox.Controls.Add(this.SpawnPointModeButton);
            this.ToolsBox.Controls.Add(this.NPCModeButton);
            this.ToolsBox.Controls.Add(this.ItemModeButton);
            this.ToolsBox.Controls.Add(this.WallModeButton);
            this.ToolsBox.Controls.Add(this.TileModeButton);
            this.ToolsBox.Location = new System.Drawing.Point(1, 49);
            this.ToolsBox.Name = "ToolsBox";
            this.ToolsBox.Size = new System.Drawing.Size(544, 90);
            this.ToolsBox.TabIndex = 8;
            this.ToolsBox.TabStop = false;
            this.ToolsBox.Text = "Tools";
            // 
            // NPCModeButton
            // 
            this.NPCModeButton.AutoSize = true;
            this.NPCModeButton.Location = new System.Drawing.Point(260, 20);
            this.NPCModeButton.Name = "NPCModeButton";
            this.NPCModeButton.Size = new System.Drawing.Size(74, 17);
            this.NPCModeButton.TabIndex = 3;
            this.NPCModeButton.Text = "NPCMode";
            this.NPCModeButton.UseVisualStyleBackColor = true;
            this.NPCModeButton.CheckedChanged += new System.EventHandler(this.NPCModeButton_CheckedChanged);
            // 
            // ItemModeButton
            // 
            this.ItemModeButton.AutoSize = true;
            this.ItemModeButton.Location = new System.Drawing.Point(169, 20);
            this.ItemModeButton.Name = "ItemModeButton";
            this.ItemModeButton.Size = new System.Drawing.Size(72, 17);
            this.ItemModeButton.TabIndex = 2;
            this.ItemModeButton.Text = "ItemMode";
            this.ItemModeButton.UseVisualStyleBackColor = true;
            this.ItemModeButton.CheckedChanged += new System.EventHandler(this.ItemModeButton_CheckedChanged);
            // 
            // WallModeButton
            // 
            this.WallModeButton.AutoSize = true;
            this.WallModeButton.Location = new System.Drawing.Point(94, 19);
            this.WallModeButton.Name = "WallModeButton";
            this.WallModeButton.Size = new System.Drawing.Size(73, 17);
            this.WallModeButton.TabIndex = 1;
            this.WallModeButton.Text = "WallMode";
            this.WallModeButton.UseVisualStyleBackColor = true;
            this.WallModeButton.CheckedChanged += new System.EventHandler(this.WallModeButton_CheckedChanged);
            // 
            // TileModeButton
            // 
            this.TileModeButton.AutoSize = true;
            this.TileModeButton.Checked = true;
            this.TileModeButton.Location = new System.Drawing.Point(12, 20);
            this.TileModeButton.Name = "TileModeButton";
            this.TileModeButton.Size = new System.Drawing.Size(69, 17);
            this.TileModeButton.TabIndex = 0;
            this.TileModeButton.TabStop = true;
            this.TileModeButton.Text = "TileMode";
            this.TileModeButton.UseVisualStyleBackColor = true;
            this.TileModeButton.CheckedChanged += new System.EventHandler(this.TileModeButton_CheckedChanged);
            // 
            // EntryModeButton
            // 
            this.EntryModeButton.AutoSize = true;
            this.EntryModeButton.Location = new System.Drawing.Point(12, 43);
            this.EntryModeButton.Name = "EntryModeButton";
            this.EntryModeButton.Size = new System.Drawing.Size(76, 17);
            this.EntryModeButton.TabIndex = 7;
            this.EntryModeButton.Text = "EntryMode";
            this.EntryModeButton.UseVisualStyleBackColor = true;
            this.EntryModeButton.CheckedChanged += new System.EventHandler(this.EntryModeButton_CheckedChanged);
            // 
            // TriggerModeButton
            // 
            this.TriggerModeButton.AutoSize = true;
            this.TriggerModeButton.Location = new System.Drawing.Point(169, 43);
            this.TriggerModeButton.Name = "TriggerModeButton";
            this.TriggerModeButton.Size = new System.Drawing.Size(85, 17);
            this.TriggerModeButton.TabIndex = 6;
            this.TriggerModeButton.Text = "TriggerMode";
            this.TriggerModeButton.UseVisualStyleBackColor = true;
            this.TriggerModeButton.CheckedChanged += new System.EventHandler(this.TriggerModeButton_CheckedChanged);
            // 
            // ExitModeButton
            // 
            this.ExitModeButton.AutoSize = true;
            this.ExitModeButton.Location = new System.Drawing.Point(94, 43);
            this.ExitModeButton.Name = "ExitModeButton";
            this.ExitModeButton.Size = new System.Drawing.Size(69, 17);
            this.ExitModeButton.TabIndex = 5;
            this.ExitModeButton.Text = "ExitMode";
            this.ExitModeButton.UseVisualStyleBackColor = true;
            this.ExitModeButton.CheckedChanged += new System.EventHandler(this.ExitModeButton_CheckedChanged);
            // 
            // SpawnPointModeButton
            // 
            this.SpawnPointModeButton.AutoSize = true;
            this.SpawnPointModeButton.Location = new System.Drawing.Point(260, 43);
            this.SpawnPointModeButton.Name = "SpawnPointModeButton";
            this.SpawnPointModeButton.Size = new System.Drawing.Size(82, 17);
            this.SpawnPointModeButton.TabIndex = 4;
            this.SpawnPointModeButton.Text = "SpawnPoint";
            this.SpawnPointModeButton.UseVisualStyleBackColor = true;
            this.SpawnPointModeButton.CheckedChanged += new System.EventHandler(this.SpawnPointModeButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 798);
            this.Controls.Add(this.ToolsBox);
            this.Controls.Add(this.ExportGroup);
            this.Controls.Add(this.MapGroupBox);
            this.Controls.Add(this.ControlsGroup);
            this.Controls.Add(this.TilePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlsGroup.ResumeLayout(false);
            this.ControlsGroup.PerformLayout();
            this.ExportGroup.ResumeLayout(false);
            this.ExportGroup.PerformLayout();
            this.ToolsBox.ResumeLayout(false);
            this.ToolsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TilePanel;
        private System.Windows.Forms.GroupBox ControlsGroup;
        private System.Windows.Forms.TextBox MapYBox;
        private System.Windows.Forms.TextBox MapXBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenMapButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TileSizeBox;
        private System.Windows.Forms.GroupBox MapGroupBox;
        private System.Windows.Forms.GroupBox ExportGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ExTileSizeBox;
        private System.Windows.Forms.TextBox ExMapYBox;
        private System.Windows.Forms.TextBox ExMapXBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MapNameBox;
        private System.Windows.Forms.GroupBox ToolsBox;
        private System.Windows.Forms.RadioButton NPCModeButton;
        private System.Windows.Forms.RadioButton ItemModeButton;
        private System.Windows.Forms.RadioButton WallModeButton;
        private System.Windows.Forms.RadioButton TileModeButton;
        private System.Windows.Forms.RadioButton EntryModeButton;
        private System.Windows.Forms.RadioButton TriggerModeButton;
        private System.Windows.Forms.RadioButton ExitModeButton;
        private System.Windows.Forms.RadioButton SpawnPointModeButton;
    }
}

