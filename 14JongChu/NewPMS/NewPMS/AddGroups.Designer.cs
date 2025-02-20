﻿namespace NewPMS
{
    partial class AddGroups
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
            this.CreateGroups = new System.Windows.Forms.GroupBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.CreateGroupButton = new System.Windows.Forms.Button();
            this.GroupNameTxt = new System.Windows.Forms.TextBox();
            this.GroupIdTxt = new System.Windows.Forms.TextBox();
            this.GroupName = new System.Windows.Forms.Label();
            this.GroupId = new System.Windows.Forms.Label();
            this.topPanel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.CreateGroups.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateGroups
            // 
            this.CreateGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateGroups.AutoSize = true;
            this.CreateGroups.Controls.Add(this.ResetBtn);
            this.CreateGroups.Controls.Add(this.CreateGroupButton);
            this.CreateGroups.Controls.Add(this.GroupNameTxt);
            this.CreateGroups.Controls.Add(this.GroupIdTxt);
            this.CreateGroups.Controls.Add(this.GroupName);
            this.CreateGroups.Controls.Add(this.GroupId);
            this.CreateGroups.Location = new System.Drawing.Point(104, 68);
            this.CreateGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreateGroups.Name = "CreateGroups";
            this.CreateGroups.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreateGroups.Size = new System.Drawing.Size(303, 195);
            this.CreateGroups.TabIndex = 5;
            this.CreateGroups.TabStop = false;
            this.CreateGroups.Text = "Create Groups";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(37, 140);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(113, 27);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // CreateGroupButton
            // 
            this.CreateGroupButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateGroupButton.AutoSize = true;
            this.CreateGroupButton.Location = new System.Drawing.Point(159, 142);
            this.CreateGroupButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreateGroupButton.Name = "CreateGroupButton";
            this.CreateGroupButton.Size = new System.Drawing.Size(139, 29);
            this.CreateGroupButton.TabIndex = 4;
            this.CreateGroupButton.Text = "Create Group";
            this.CreateGroupButton.UseVisualStyleBackColor = true;
            this.CreateGroupButton.Click += new System.EventHandler(this.CreateGroupButton_Click);
            // 
            // GroupNameTxt
            // 
            this.GroupNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupNameTxt.Location = new System.Drawing.Point(159, 87);
            this.GroupNameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupNameTxt.Name = "GroupNameTxt";
            this.GroupNameTxt.Size = new System.Drawing.Size(117, 25);
            this.GroupNameTxt.TabIndex = 3;
            // 
            // GroupIdTxt
            // 
            this.GroupIdTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupIdTxt.Location = new System.Drawing.Point(159, 46);
            this.GroupIdTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupIdTxt.Name = "GroupIdTxt";
            this.GroupIdTxt.Size = new System.Drawing.Size(117, 25);
            this.GroupIdTxt.TabIndex = 2;
            // 
            // GroupName
            // 
            this.GroupName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupName.AutoSize = true;
            this.GroupName.Location = new System.Drawing.Point(33, 91);
            this.GroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(88, 15);
            this.GroupName.TabIndex = 1;
            this.GroupName.Text = "Group Name";
            // 
            // GroupId
            // 
            this.GroupId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupId.AutoSize = true;
            this.GroupId.Location = new System.Drawing.Point(33, 46);
            this.GroupId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GroupId.Name = "GroupId";
            this.GroupId.Size = new System.Drawing.Size(63, 15);
            this.GroupId.TabIndex = 0;
            this.GroupId.Text = "Group Id";
            // 
            // topPanel
            // 
            this.topPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(148)))));
            this.topPanel.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(170)))));
            this.topPanel.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.topPanel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.topPanel.Location = new System.Drawing.Point(-2, 1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(398, 50);
            this.topPanel.Click += new System.EventHandler(this.topPanel_Click);
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.topPanel});
            this.shapeContainer1.Size = new System.Drawing.Size(525, 314);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bottomPanel.Controls.Add(this.okButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 266);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(525, 48);
            this.bottomPanel.TabIndex = 9;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(409, 10);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 27);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AddGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 314);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.CreateGroups);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGroups";
            this.Load += new System.EventHandler(this.AddGroups_Load);
            this.CreateGroups.ResumeLayout(false);
            this.CreateGroups.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CreateGroups;
        private System.Windows.Forms.Button CreateGroupButton;
        private System.Windows.Forms.TextBox GroupNameTxt;
        private System.Windows.Forms.TextBox GroupIdTxt;
        private System.Windows.Forms.Label GroupName;
        private System.Windows.Forms.Label GroupId;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;
    }
}