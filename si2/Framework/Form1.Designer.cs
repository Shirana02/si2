﻿namespace Framework {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			menuStrip1 = new MenuStrip();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tabPage2 = new TabPage();
			tabControl1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Location = new Point(0,0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800,24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0,24);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(800,426);
			tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			tabPage1.Location = new Point(4,24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(792,398);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "tabPage1";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			tabPage2.Location = new Point(4,24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(192,72);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "tabPage2";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F,15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800,450);
			Controls.Add(tabControl1);
			Controls.Add(menuStrip1);
			Name = "Form1";
			Text = "Form1";
			tabControl1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
	}
}
