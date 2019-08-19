namespace AutoUpdate
{
	partial class AutoUpdateDemo
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
			this.cmdArgs = new System.Windows.Forms.Label();
			this.vers = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hello World! Updated!";
			// 
			// cmdArgs
			// 
			this.cmdArgs.AutoSize = true;
			this.cmdArgs.Location = new System.Drawing.Point(1, 64);
			this.cmdArgs.Name = "cmdArgs";
			this.cmdArgs.Size = new System.Drawing.Size(46, 17);
			this.cmdArgs.TabIndex = 1;
			this.cmdArgs.Text = "label2";
			// 
			// vers
			// 
			this.vers.AutoSize = true;
			this.vers.Location = new System.Drawing.Point(1, 44);
			this.vers.Name = "vers";
			this.vers.Size = new System.Drawing.Size(46, 17);
			this.vers.TabIndex = 2;
			this.vers.Text = "label2";
			// 
			// AutoUpdateDemo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 90);
			this.Controls.Add(this.vers);
			this.Controls.Add(this.cmdArgs);
			this.Controls.Add(this.label1);
			this.Name = "AutoUpdateDemo";
			this.Text = "Demo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label cmdArgs;
		private System.Windows.Forms.Label vers;
	}
}

