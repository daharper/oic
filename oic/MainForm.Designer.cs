namespace oic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DfmPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExampleTwoButton = new System.Windows.Forms.Button();
            this.ExampleOneButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeGenButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CodePanel = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.ExmpleThreeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DfmPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 999);
            this.panel1.TabIndex = 2;
            // 
            // DfmPanel
            // 
            this.DfmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DfmPanel.Location = new System.Drawing.Point(0, 25);
            this.DfmPanel.Name = "DfmPanel";
            this.DfmPanel.Size = new System.Drawing.Size(644, 974);
            this.DfmPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ExmpleThreeButton);
            this.panel2.Controls.Add(this.ExampleTwoButton);
            this.panel2.Controls.Add(this.ExampleOneButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CodeGenButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 25);
            this.panel2.TabIndex = 0;
            // 
            // ExampleTwoButton
            // 
            this.ExampleTwoButton.Location = new System.Drawing.Point(122, 3);
            this.ExampleTwoButton.Name = "ExampleTwoButton";
            this.ExampleTwoButton.Size = new System.Drawing.Size(26, 21);
            this.ExampleTwoButton.TabIndex = 3;
            this.ExampleTwoButton.Tag = "2";
            this.ExampleTwoButton.Text = "2";
            this.ExampleTwoButton.UseVisualStyleBackColor = true;
            this.ExampleTwoButton.Click += new System.EventHandler(this.ExampleButton_Click);
            // 
            // ExampleOneButton
            // 
            this.ExampleOneButton.Location = new System.Drawing.Point(91, 3);
            this.ExampleOneButton.Name = "ExampleOneButton";
            this.ExampleOneButton.Size = new System.Drawing.Size(26, 21);
            this.ExampleOneButton.TabIndex = 2;
            this.ExampleOneButton.Tag = "1";
            this.ExampleOneButton.Text = "1";
            this.ExampleOneButton.UseVisualStyleBackColor = true;
            this.ExampleOneButton.Click += new System.EventHandler(this.ExampleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DFM";
            // 
            // CodeGenButton
            // 
            this.CodeGenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeGenButton.Location = new System.Drawing.Point(608, 3);
            this.CodeGenButton.Name = "CodeGenButton";
            this.CodeGenButton.Size = new System.Drawing.Size(30, 20);
            this.CodeGenButton.TabIndex = 0;
            this.CodeGenButton.Text = ">>";
            this.CodeGenButton.UseVisualStyleBackColor = true;
            this.CodeGenButton.Click += new System.EventHandler(this.CodeGenButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(644, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 999);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(647, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 999);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CodePanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(806, 973);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CodePanel
            // 
            this.CodePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodePanel.Location = new System.Drawing.Point(3, 3);
            this.CodePanel.Name = "CodePanel";
            this.CodePanel.Size = new System.Drawing.Size(800, 967);
            this.CodePanel.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LogTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(806, 973);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogTextBox.Location = new System.Drawing.Point(3, 3);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(800, 967);
            this.LogTextBox.TabIndex = 0;
            // 
            // ExmpleThreeButton
            // 
            this.ExmpleThreeButton.Location = new System.Drawing.Point(154, 3);
            this.ExmpleThreeButton.Name = "ExmpleThreeButton";
            this.ExmpleThreeButton.Size = new System.Drawing.Size(26, 21);
            this.ExmpleThreeButton.TabIndex = 4;
            this.ExmpleThreeButton.Tag = "3";
            this.ExmpleThreeButton.Text = "3";
            this.ExmpleThreeButton.UseVisualStyleBackColor = true;
            this.ExmpleThreeButton.Click += new System.EventHandler(this.ExampleButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1461, 999);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OIC - Object Into Code";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DfmPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExampleOneButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CodeGenButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel CodePanel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button ExampleTwoButton;
        private System.Windows.Forms.Button ExmpleThreeButton;
    }
}

