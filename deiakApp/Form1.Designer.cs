﻿namespace deiakApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvCalls = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnUnhold = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuObject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuIrten = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.mnuObject.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCalls
            // 
            this.lvCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCalls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvCalls.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCalls.HideSelection = false;
            this.lvCalls.Location = new System.Drawing.Point(12, 12);
            this.lvCalls.MultiSelect = false;
            this.lvCalls.Name = "lvCalls";
            this.lvCalls.Size = new System.Drawing.Size(695, 195);
            this.lvCalls.TabIndex = 0;
            this.lvCalls.UseCompatibleStateImageBehavior = false;
            this.lvCalls.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Luzapena";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Deia";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Egoera";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nork";
            this.columnHeader4.Width = 131;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nori";
            this.columnHeader5.Width = 150;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(173, 213);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Onartu";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnswer.Enabled = false;
            this.btnAnswer.Location = new System.Drawing.Point(254, 213);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Erantzun";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click_1);
            // 
            // btnDrop
            // 
            this.btnDrop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDrop.Enabled = false;
            this.btnDrop.Location = new System.Drawing.Point(335, 213);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(75, 23);
            this.btnDrop.TabIndex = 3;
            this.btnDrop.Text = "Eskegi";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click_1);
            // 
            // btnHold
            // 
            this.btnHold.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHold.Enabled = false;
            this.btnHold.Location = new System.Drawing.Point(416, 213);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(75, 23);
            this.btnHold.TabIndex = 4;
            this.btnHold.Text = "Baitu";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click_1);
            // 
            // btnUnhold
            // 
            this.btnUnhold.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUnhold.Enabled = false;
            this.btnUnhold.Location = new System.Drawing.Point(497, 213);
            this.btnUnhold.Name = "btnUnhold";
            this.btnUnhold.Size = new System.Drawing.Size(75, 23);
            this.btnUnhold.TabIndex = 5;
            this.btnUnhold.Text = "Libratu";
            this.btnUnhold.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 251);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(719, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(704, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Prest";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.mnuObject;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "deiakApp";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick_1);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick_1);
            // 
            // mnuObject
            // 
            this.mnuObject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIrten});
            this.mnuObject.Name = "mnuIrten";
            this.mnuObject.Size = new System.Drawing.Size(110, 26);
            // 
            // mnuIrten
            // 
            this.mnuIrten.Name = "mnuIrten";
            this.mnuIrten.Size = new System.Drawing.Size(109, 22);
            this.mnuIrten.Text = "Irten";
            this.mnuIrten.Click += new System.EventHandler(this.mnuIrten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 273);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnUnhold);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lvCalls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pasiako Udala. Dei Kudeatzailea";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mnuObject.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCalls;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnUnhold;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip mnuObject;
        private System.Windows.Forms.ToolStripMenuItem mnuIrten;
    }
}

