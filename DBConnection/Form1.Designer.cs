﻿
namespace DBConnection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.подключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключениеОтБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ассинхронноеПодключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеКБДToolStripMenuItem,
            this.отключениеОтБДToolStripMenuItem,
            this.ассинхронноеПодключениеКБДToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // подключениеКБДToolStripMenuItem
            // 
            this.подключениеКБДToolStripMenuItem.Name = "подключениеКБДToolStripMenuItem";
            this.подключениеКБДToolStripMenuItem.Size = new System.Drawing.Size(249, 36);
            this.подключениеКБДToolStripMenuItem.Text = "Подключение к БД";
            this.подключениеКБДToolStripMenuItem.Click += new System.EventHandler(this.подключениеКБДToolStripMenuItem_Click);
            // 
            // отключениеОтБДToolStripMenuItem
            // 
            this.отключениеОтБДToolStripMenuItem.Name = "отключениеОтБДToolStripMenuItem";
            this.отключениеОтБДToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.отключениеОтБДToolStripMenuItem.Text = "Отключение от БД";
            this.отключениеОтБДToolStripMenuItem.Click += new System.EventHandler(this.отключениеОтБДToolStripMenuItem_Click);
            // 
            // ассинхронноеПодключениеКБДToolStripMenuItem
            // 
            this.ассинхронноеПодключениеКБДToolStripMenuItem.Name = "ассинхронноеПодключениеКБДToolStripMenuItem";
            this.ассинхронноеПодключениеКБДToolStripMenuItem.Size = new System.Drawing.Size(412, 38);
            this.ассинхронноеПодключениеКБДToolStripMenuItem.Text = "Ассинхронное подключение к БД";
            this.ассинхронноеПодключениеКБДToolStripMenuItem.Click += new System.EventHandler(this.ассинхронноеПодключениеКБДToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem подключениеКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отключениеОтБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ассинхронноеПодключениеКБДToolStripMenuItem;
    }
}

