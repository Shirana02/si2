namespace Shell {
	partial class fm_shell {
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
			rtb_cwd = new RichTextBox();
			tb_output = new TextBox();
			sp_main = new SplitContainer();
			tab_main = new TabControl();
			tab_main_dir = new TabPage();
			rtb_dir = new RichTextBox();
			tab_main_script = new TabPage();
			rtb_script = new RichTextBox();
			tab_util = new TabControl();
			tab_util_ = new TabPage();
			((System.ComponentModel.ISupportInitialize)sp_main).BeginInit();
			sp_main.Panel1.SuspendLayout();
			sp_main.Panel2.SuspendLayout();
			sp_main.SuspendLayout();
			tab_main.SuspendLayout();
			tab_main_dir.SuspendLayout();
			tab_main_script.SuspendLayout();
			tab_util.SuspendLayout();
			SuspendLayout();
			// 
			// rtb_cwd
			// 
			rtb_cwd.BackColor = SystemColors.ActiveCaption;
			rtb_cwd.Dock = DockStyle.Top;
			rtb_cwd.Location = new Point(0,0);
			rtb_cwd.Multiline = false;
			rtb_cwd.Name = "rtb_cwd";
			rtb_cwd.ReadOnly = true;
			rtb_cwd.ScrollBars = RichTextBoxScrollBars.None;
			rtb_cwd.Size = new Size(800,25);
			rtb_cwd.TabIndex = 0;
			rtb_cwd.Text = "";
			// 
			// tb_output
			// 
			tb_output.BackColor = SystemColors.ControlDark;
			tb_output.Dock = DockStyle.Bottom;
			tb_output.Location = new Point(0,332);
			tb_output.Multiline = true;
			tb_output.Name = "tb_output";
			tb_output.Size = new Size(800,118);
			tb_output.TabIndex = 1;
			// 
			// sp_main
			// 
			sp_main.Dock = DockStyle.Fill;
			sp_main.Location = new Point(0,25);
			sp_main.Name = "sp_main";
			// 
			// sp_main.Panel1
			// 
			sp_main.Panel1.Controls.Add(tab_main);
			// 
			// sp_main.Panel2
			// 
			sp_main.Panel2.Controls.Add(tab_util);
			sp_main.Size = new Size(800,307);
			sp_main.SplitterDistance = 354;
			sp_main.TabIndex = 2;
			// 
			// tab_main
			// 
			tab_main.Controls.Add(tab_main_dir);
			tab_main.Controls.Add(tab_main_script);
			tab_main.Dock = DockStyle.Fill;
			tab_main.Location = new Point(0,0);
			tab_main.Name = "tab_main";
			tab_main.SelectedIndex = 0;
			tab_main.Size = new Size(354,307);
			tab_main.TabIndex = 0;
			// 
			// tab_main_dir
			// 
			tab_main_dir.BackColor = SystemColors.ControlDark;
			tab_main_dir.Controls.Add(rtb_dir);
			tab_main_dir.Location = new Point(4,24);
			tab_main_dir.Name = "tab_main_dir";
			tab_main_dir.Padding = new Padding(3);
			tab_main_dir.Size = new Size(346,279);
			tab_main_dir.TabIndex = 0;
			tab_main_dir.Text = "Dir";
			// 
			// rtb_dir
			// 
			rtb_dir.BackColor = SystemColors.ControlDark;
			rtb_dir.Dock = DockStyle.Fill;
			rtb_dir.Location = new Point(3,3);
			rtb_dir.Name = "rtb_dir";
			rtb_dir.Size = new Size(340,273);
			rtb_dir.TabIndex = 0;
			rtb_dir.Text = "";
			// 
			// tab_main_script
			// 
			tab_main_script.Controls.Add(rtb_script);
			tab_main_script.Location = new Point(4,24);
			tab_main_script.Name = "tab_main_script";
			tab_main_script.Padding = new Padding(3);
			tab_main_script.Size = new Size(346,279);
			tab_main_script.TabIndex = 1;
			tab_main_script.Text = "Script";
			tab_main_script.UseVisualStyleBackColor = true;
			// 
			// rtb_script
			// 
			rtb_script.BackColor = SystemColors.ControlDark;
			rtb_script.Dock = DockStyle.Fill;
			rtb_script.Location = new Point(3,3);
			rtb_script.Name = "rtb_script";
			rtb_script.Size = new Size(340,273);
			rtb_script.TabIndex = 0;
			rtb_script.Text = "";
			// 
			// tab_util
			// 
			tab_util.Controls.Add(tab_util_);
			tab_util.Dock = DockStyle.Fill;
			tab_util.Location = new Point(0,0);
			tab_util.Name = "tab_util";
			tab_util.SelectedIndex = 0;
			tab_util.Size = new Size(442,307);
			tab_util.TabIndex = 0;
			// 
			// tab_util_
			// 
			tab_util_.BackColor = SystemColors.ControlDark;
			tab_util_.Location = new Point(4,24);
			tab_util_.Name = "tab_util_";
			tab_util_.Padding = new Padding(3);
			tab_util_.Size = new Size(434,279);
			tab_util_.TabIndex = 0;
			tab_util_.Text = "tabPage1";
			// 
			// fm_shell
			// 
			AutoScaleDimensions = new SizeF(7F,15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			ClientSize = new Size(800,450);
			Controls.Add(sp_main);
			Controls.Add(tb_output);
			Controls.Add(rtb_cwd);
			Name = "fm_shell";
			Text = "Shell";
			sp_main.Panel1.ResumeLayout(false);
			sp_main.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)sp_main).EndInit();
			sp_main.ResumeLayout(false);
			tab_main.ResumeLayout(false);
			tab_main_dir.ResumeLayout(false);
			tab_main_script.ResumeLayout(false);
			tab_util.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RichTextBox rtb_cwd;
		private TextBox tb_output;
		private SplitContainer sp_main;
		private TabControl tab_util;
		private TabPage tab_util_;
		private TabControl tab_main;
		private TabPage tab_main_dir;
		private TabPage tab_main_script;
		private RichTextBox rtb_dir;
		private RichTextBox rtb_script;
	}
}
