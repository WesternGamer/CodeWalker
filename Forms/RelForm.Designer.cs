﻿namespace CodeWalker.Forms
{
    partial class RelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelForm));
            this.RelPropertyGrid = new CodeWalker.WinForms.PropertyGridFix();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.XmlTabPage = new System.Windows.Forms.TabPage();
            this.XmlTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.DetailsTabPage = new System.Windows.Forms.TabPage();
            this.NameTableTabPage = new System.Windows.Forms.TabPage();
            this.MainTextBox = new CodeWalker.WinForms.TextBoxFix();
            this.SearchTabPage = new System.Windows.Forms.TabPage();
            this.SearchTextRadio = new System.Windows.Forms.RadioButton();
            this.SearchHashRadio = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchResultsGrid = new CodeWalker.WinForms.PropertyGridFix();
            this.MainToolbar = new System.Windows.Forms.ToolStrip();
            this.NewButton = new System.Windows.Forms.ToolStripSplitButton();
            this.OpenButton = new System.Windows.Forms.ToolStripSplitButton();
            this.SaveButton = new System.Windows.Forms.ToolStripSplitButton();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FileCloseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.wIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.wIPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainTabControl.SuspendLayout();
            this.XmlTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XmlTextBox)).BeginInit();
            this.DetailsTabPage.SuspendLayout();
            this.NameTableTabPage.SuspendLayout();
            this.SearchTabPage.SuspendLayout();
            this.MainToolbar.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // RelPropertyGrid
            // 
            this.RelPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RelPropertyGrid.HelpVisible = false;
            this.RelPropertyGrid.Location = new System.Drawing.Point(6, 6);
            this.RelPropertyGrid.Name = "RelPropertyGrid";
            this.RelPropertyGrid.Size = new System.Drawing.Size(819, 448);
            this.RelPropertyGrid.TabIndex = 0;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.XmlTabPage);
            this.MainTabControl.Controls.Add(this.DetailsTabPage);
            this.MainTabControl.Controls.Add(this.NameTableTabPage);
            this.MainTabControl.Controls.Add(this.SearchTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 49);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(839, 486);
            this.MainTabControl.TabIndex = 1;
            // 
            // XmlTabPage
            // 
            this.XmlTabPage.Controls.Add(this.XmlTextBox);
            this.XmlTabPage.Location = new System.Drawing.Point(4, 22);
            this.XmlTabPage.Name = "XmlTabPage";
            this.XmlTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.XmlTabPage.Size = new System.Drawing.Size(831, 460);
            this.XmlTabPage.TabIndex = 3;
            this.XmlTabPage.Text = "XML";
            this.XmlTabPage.UseVisualStyleBackColor = true;
            // 
            // XmlTextBox
            // 
            this.XmlTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.XmlTextBox.AutoIndentChars = false;
            this.XmlTextBox.AutoIndentCharsPatterns = "";
            this.XmlTextBox.AutoIndentExistingLines = false;
            this.XmlTextBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.XmlTextBox.BackBrush = null;
            this.XmlTextBox.CharHeight = 14;
            this.XmlTextBox.CharWidth = 8;
            this.XmlTextBox.CommentPrefix = null;
            this.XmlTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.XmlTextBox.DelayedEventsInterval = 1;
            this.XmlTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.XmlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XmlTextBox.IsReplaceMode = false;
            this.XmlTextBox.Language = FastColoredTextBoxNS.Language.XML;
            this.XmlTextBox.LeftBracket = '<';
            this.XmlTextBox.LeftBracket2 = '(';
            this.XmlTextBox.Location = new System.Drawing.Point(3, 3);
            this.XmlTextBox.Name = "XmlTextBox";
            this.XmlTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.XmlTextBox.RightBracket = '>';
            this.XmlTextBox.RightBracket2 = ')';
            this.XmlTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.XmlTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("XmlTextBox.ServiceColors")));
            this.XmlTextBox.Size = new System.Drawing.Size(825, 454);
            this.XmlTextBox.TabIndex = 2;
            this.XmlTextBox.Zoom = 100;
            this.XmlTextBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.XmlTextBox_TextChanged);
            this.XmlTextBox.VisibleRangeChangedDelayed += new System.EventHandler(this.XmlTextBox_VisibleRangeChangedDelayed);
            // 
            // DetailsTabPage
            // 
            this.DetailsTabPage.Controls.Add(this.RelPropertyGrid);
            this.DetailsTabPage.Location = new System.Drawing.Point(4, 22);
            this.DetailsTabPage.Name = "DetailsTabPage";
            this.DetailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DetailsTabPage.Size = new System.Drawing.Size(831, 460);
            this.DetailsTabPage.TabIndex = 1;
            this.DetailsTabPage.Text = "Details";
            this.DetailsTabPage.UseVisualStyleBackColor = true;
            // 
            // NameTableTabPage
            // 
            this.NameTableTabPage.Controls.Add(this.MainTextBox);
            this.NameTableTabPage.Location = new System.Drawing.Point(4, 22);
            this.NameTableTabPage.Name = "NameTableTabPage";
            this.NameTableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NameTableTabPage.Size = new System.Drawing.Size(831, 460);
            this.NameTableTabPage.TabIndex = 0;
            this.NameTableTabPage.Text = "Names";
            this.NameTableTabPage.UseVisualStyleBackColor = true;
            // 
            // MainTextBox
            // 
            this.MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextBox.HideSelection = false;
            this.MainTextBox.Location = new System.Drawing.Point(6, 6);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MainTextBox.Size = new System.Drawing.Size(819, 448);
            this.MainTextBox.TabIndex = 1;
            this.MainTextBox.WordWrap = false;
            // 
            // SearchTabPage
            // 
            this.SearchTabPage.Controls.Add(this.SearchTextRadio);
            this.SearchTabPage.Controls.Add(this.SearchHashRadio);
            this.SearchTabPage.Controls.Add(this.label12);
            this.SearchTabPage.Controls.Add(this.SearchTextBox);
            this.SearchTabPage.Controls.Add(this.SearchButton);
            this.SearchTabPage.Controls.Add(this.SearchResultsGrid);
            this.SearchTabPage.Location = new System.Drawing.Point(4, 22);
            this.SearchTabPage.Name = "SearchTabPage";
            this.SearchTabPage.Size = new System.Drawing.Size(831, 460);
            this.SearchTabPage.TabIndex = 2;
            this.SearchTabPage.Text = "Search";
            this.SearchTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchTextRadio
            // 
            this.SearchTextRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextRadio.AutoSize = true;
            this.SearchTextRadio.Location = new System.Drawing.Point(518, 4);
            this.SearchTextRadio.Name = "SearchTextRadio";
            this.SearchTextRadio.Size = new System.Drawing.Size(46, 17);
            this.SearchTextRadio.TabIndex = 36;
            this.SearchTextRadio.Text = "Text";
            this.SearchTextRadio.UseVisualStyleBackColor = true;
            // 
            // SearchHashRadio
            // 
            this.SearchHashRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchHashRadio.AutoSize = true;
            this.SearchHashRadio.Checked = true;
            this.SearchHashRadio.Location = new System.Drawing.Point(462, 4);
            this.SearchHashRadio.Name = "SearchHashRadio";
            this.SearchHashRadio.Size = new System.Drawing.Size(50, 17);
            this.SearchHashRadio.TabIndex = 35;
            this.SearchHashRadio.TabStop = true;
            this.SearchHashRadio.Text = "Hash";
            this.SearchHashRadio.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Find:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(44, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(412, 20);
            this.SearchTextBox.TabIndex = 33;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(570, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(68, 23);
            this.SearchButton.TabIndex = 34;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchResultsGrid
            // 
            this.SearchResultsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResultsGrid.HelpVisible = false;
            this.SearchResultsGrid.Location = new System.Drawing.Point(3, 31);
            this.SearchResultsGrid.Name = "SearchResultsGrid";
            this.SearchResultsGrid.Size = new System.Drawing.Size(822, 423);
            this.SearchResultsGrid.TabIndex = 1;
            // 
            // MainToolbar
            // 
            this.MainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.OpenButton,
            this.SaveButton});
            this.MainToolbar.Location = new System.Drawing.Point(0, 24);
            this.MainToolbar.Name = "MainToolbar";
            this.MainToolbar.Size = new System.Drawing.Size(839, 25);
            this.MainToolbar.TabIndex = 9;
            this.MainToolbar.Text = "Main Toolbar";
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(32, 22);
            this.NewButton.Text = "New...";
            this.NewButton.ButtonClick += new System.EventHandler(this.NewButton_ButtonClick);
            // 
            // OpenButton
            // 
            this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenButton.Image")));
            this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(32, 22);
            this.OpenButton.Text = "Open...";
            this.OpenButton.ButtonClick += new System.EventHandler(this.OpenButton_ButtonClick);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(32, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.ButtonClick += new System.EventHandler(this.SaveButton_ButtonClick);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 535);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(839, 22);
            this.MainStatusStrip.TabIndex = 7;
            this.MainStatusStrip.Text = "Main Status Strip";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(824, 17);
            this.StatusLabel.Spring = true;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.ViewMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(839, 24);
            this.MainMenu.TabIndex = 8;
            this.MainMenu.Text = "Main Menu";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileNewMenu,
            this.FileOpenMenu,
            this.FileSaveMenu,
            this.FileSaveAsMenu,
            this.toolStripSeparator1,
            this.FileCloseMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // FileNewMenu
            // 
            this.FileNewMenu.Name = "FileNewMenu";
            this.FileNewMenu.Size = new System.Drawing.Size(145, 22);
            this.FileNewMenu.Text = "New";
            this.FileNewMenu.Click += new System.EventHandler(this.FileNewMenu_Click);
            // 
            // FileOpenMenu
            // 
            this.FileOpenMenu.Name = "FileOpenMenu";
            this.FileOpenMenu.Size = new System.Drawing.Size(145, 22);
            this.FileOpenMenu.Text = "Open...";
            this.FileOpenMenu.Click += new System.EventHandler(this.FileOpenMenu_Click);
            // 
            // FileSaveMenu
            // 
            this.FileSaveMenu.Name = "FileSaveMenu";
            this.FileSaveMenu.Size = new System.Drawing.Size(145, 22);
            this.FileSaveMenu.Text = "Save";
            this.FileSaveMenu.Click += new System.EventHandler(this.FileSaveMenu_Click);
            // 
            // FileSaveAsMenu
            // 
            this.FileSaveAsMenu.Name = "FileSaveAsMenu";
            this.FileSaveAsMenu.Size = new System.Drawing.Size(145, 22);
            this.FileSaveAsMenu.Text = "Save As...";
            this.FileSaveAsMenu.Click += new System.EventHandler(this.FileSaveAsMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // FileCloseMenu
            // 
            this.FileCloseMenu.Name = "FileCloseMenu";
            this.FileCloseMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.FileCloseMenu.Size = new System.Drawing.Size(145, 22);
            this.FileCloseMenu.Text = "Close";
            this.FileCloseMenu.Click += new System.EventHandler(this.FileCloseMenu_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wIPToolStripMenuItem});
            this.EditMenu.Enabled = false;
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(39, 20);
            this.EditMenu.Text = "Edit";
            // 
            // wIPToolStripMenuItem
            // 
            this.wIPToolStripMenuItem.Name = "wIPToolStripMenuItem";
            this.wIPToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.wIPToolStripMenuItem.Text = "[WIP!]";
            // 
            // ViewMenu
            // 
            this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wIPToolStripMenuItem1});
            this.ViewMenu.Enabled = false;
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(44, 20);
            this.ViewMenu.Text = "View";
            // 
            // wIPToolStripMenuItem1
            // 
            this.wIPToolStripMenuItem1.Name = "wIPToolStripMenuItem1";
            this.wIPToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.wIPToolStripMenuItem1.Text = "[WIP!]";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "XML files|*.xml|All files|*.*";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "XML files|*.xml|All files|*.*";
            // 
            // RelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 557);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainToolbar);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelForm";
            this.Text = "Audio dat.rel Editor - CodeWalker by dexyfex";
            this.MainTabControl.ResumeLayout(false);
            this.XmlTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.XmlTextBox)).EndInit();
            this.DetailsTabPage.ResumeLayout(false);
            this.NameTableTabPage.ResumeLayout(false);
            this.NameTableTabPage.PerformLayout();
            this.SearchTabPage.ResumeLayout(false);
            this.SearchTabPage.PerformLayout();
            this.MainToolbar.ResumeLayout(false);
            this.MainToolbar.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinForms.PropertyGridFix RelPropertyGrid;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage NameTableTabPage;
        private System.Windows.Forms.TabPage DetailsTabPage;
        private WinForms.TextBoxFix MainTextBox;
        private System.Windows.Forms.TabPage SearchTabPage;
        private WinForms.PropertyGridFix SearchResultsGrid;
        private System.Windows.Forms.RadioButton SearchTextRadio;
        private System.Windows.Forms.RadioButton SearchHashRadio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TabPage XmlTabPage;
        private FastColoredTextBoxNS.FastColoredTextBox XmlTextBox;
        private System.Windows.Forms.ToolStrip MainToolbar;
        private System.Windows.Forms.ToolStripSplitButton NewButton;
        private System.Windows.Forms.ToolStripSplitButton OpenButton;
        private System.Windows.Forms.ToolStripSplitButton SaveButton;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem FileNewMenu;
        private System.Windows.Forms.ToolStripMenuItem FileOpenMenu;
        private System.Windows.Forms.ToolStripMenuItem FileSaveMenu;
        private System.Windows.Forms.ToolStripMenuItem FileSaveAsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem FileCloseMenu;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem wIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewMenu;
        private System.Windows.Forms.ToolStripMenuItem wIPToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}