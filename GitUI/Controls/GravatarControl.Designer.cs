﻿namespace GitUI
{
    partial class GravatarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._gravatarImg = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearImagecacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.noImageGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identiconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monsterIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wavatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.registerAtGravatarcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this._gravatarImg)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _gravatarImg
            // 
            this._gravatarImg.ContextMenuStrip = this.contextMenuStrip;
            this._gravatarImg.Image = global::GitUI.Properties.Resources.User;
            this._gravatarImg.Location = new System.Drawing.Point(0, 0);
            this._gravatarImg.Name = "_gravatarImg";
            this._gravatarImg.Size = new System.Drawing.Size(93, 92);
            this._gravatarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._gravatarImg.TabIndex = 0;
            this._gravatarImg.TabStop = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.clearImagecacheToolStripMenuItem,
            this.imageSizeToolStripMenuItem,
            this.noImageGeneratorToolStripMenuItem,
            this.toolStripSeparator1,
            this.registerAtGravatarcomToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(203, 120);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.refreshToolStripMenuItem.Text = "Refresh image";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItemClick);
            // 
            // clearImagecacheToolStripMenuItem
            // 
            this.clearImagecacheToolStripMenuItem.Name = "clearImagecacheToolStripMenuItem";
            this.clearImagecacheToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.clearImagecacheToolStripMenuItem.Text = "Clear image cache";
            this.clearImagecacheToolStripMenuItem.Click += new System.EventHandler(this.ClearImagecacheToolStripMenuItemClick);
            // 
            // imageSizeToolStripMenuItem
            // 
            this.imageSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.toolStripMenuItem3,
            this.mediumToolStripMenuItem,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.largeToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem2,
            this.toolStripMenuItem6,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.imageSizeToolStripMenuItem.Name = "imageSizeToolStripMenuItem";
            this.imageSizeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.imageSizeToolStripMenuItem.Text = "Image size";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.smallToolStripMenuItem.Text = "80";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.SmallToolStripMenuItemClick);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "100";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.SmallToolStripMenuItemClick);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mediumToolStripMenuItem.Text = "120";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.SmallToolStripMenuItemClick);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem7.Text = "140";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.SmallToolStripMenuItemClick);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem8.Text = "160";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.SmallToolStripMenuItemClick);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.largeToolStripMenuItem.Text = "180";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.SmallToolStripMenuItemClick);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "200";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.SmallToolStripMenuItemClick);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "220";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.SmallToolStripMenuItemClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "240";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.SmallToolStripMenuItemClick);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem6.Text = "260";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.SmallToolStripMenuItemClick);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem9.Text = "280";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.SmallToolStripMenuItemClick);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem10.Text = "300";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.SmallToolStripMenuItemClick);
            // 
            // noImageGeneratorToolStripMenuItem
            // 
            this.noImageGeneratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.identiconToolStripMenuItem,
            this.monsterIdToolStripMenuItem,
            this.wavatarToolStripMenuItem,
            this.retroToolStripMenuItem});
            this.noImageGeneratorToolStripMenuItem.Name = "noImageGeneratorToolStripMenuItem";
            this.noImageGeneratorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.noImageGeneratorToolStripMenuItem.Text = "No image service";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // identiconToolStripMenuItem
            // 
            this.identiconToolStripMenuItem.Name = "identiconToolStripMenuItem";
            this.identiconToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.identiconToolStripMenuItem.Text = "Identicon";
            this.identiconToolStripMenuItem.Click += new System.EventHandler(this.identiconToolStripMenuItem_Click);
            // 
            // monsterIdToolStripMenuItem
            // 
            this.monsterIdToolStripMenuItem.Name = "monsterIdToolStripMenuItem";
            this.monsterIdToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.monsterIdToolStripMenuItem.Text = "Monster Id";
            this.monsterIdToolStripMenuItem.Click += new System.EventHandler(this.monsterIdToolStripMenuItem_Click);
            // 
            // wavatarToolStripMenuItem
            // 
            this.wavatarToolStripMenuItem.Name = "wavatarToolStripMenuItem";
            this.wavatarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.wavatarToolStripMenuItem.Text = "Wavatar";
            this.wavatarToolStripMenuItem.Click += new System.EventHandler(this.wavatarToolStripMenuItem_Click);
            // 
            // retroToolStripMenuItem
            // 
            this.retroToolStripMenuItem.Name = "retroToolStripMenuItem";
            this.retroToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.retroToolStripMenuItem.Text = "Retro";
            this.retroToolStripMenuItem.Click += new System.EventHandler(this.retroToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // registerAtGravatarcomToolStripMenuItem
            // 
            this.registerAtGravatarcomToolStripMenuItem.Name = "registerAtGravatarcomToolStripMenuItem";
            this.registerAtGravatarcomToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.registerAtGravatarcomToolStripMenuItem.Text = "Register at gravatar.com";
            this.registerAtGravatarcomToolStripMenuItem.Click += new System.EventHandler(this.RegisterAtGravatarcomToolStripMenuItemClick);
            // 
            // GravatarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._gravatarImg);
            this.Name = "GravatarControl";
            this.Size = new System.Drawing.Size(175, 173);
            ((System.ComponentModel.ISupportInitialize)(this._gravatarImg)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _gravatarImg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerAtGravatarcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearImagecacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem noImageGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identiconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monsterIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wavatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retroToolStripMenuItem;
    }
}
