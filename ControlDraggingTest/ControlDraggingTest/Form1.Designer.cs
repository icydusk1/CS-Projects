namespace ControlDraggingTest {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Icon1 = new System.Windows.Forms.PictureBox();
			this.Icon2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Icon1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Icon2)).BeginInit();
			this.SuspendLayout();
			// 
			// Icon1
			// 
			this.Icon1.Image = ((System.Drawing.Image)(resources.GetObject("Icon1.Image")));
			this.Icon1.Location = new System.Drawing.Point(161, 179);
			this.Icon1.Name = "Icon1";
			this.Icon1.Size = new System.Drawing.Size(70, 86);
			this.Icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Icon1.TabIndex = 0;
			this.Icon1.TabStop = false;
			this.Icon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Icon_MouseDown);
			this.Icon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Icon_MouseMove);
			this.Icon1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Icon_MouseUp);
			// 
			// Icon2
			// 
			this.Icon2.Image = ((System.Drawing.Image)(resources.GetObject("Icon2.Image")));
			this.Icon2.Location = new System.Drawing.Point(468, 195);
			this.Icon2.Name = "Icon2";
			this.Icon2.Size = new System.Drawing.Size(68, 96);
			this.Icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Icon2.TabIndex = 1;
			this.Icon2.TabStop = false;
			this.Icon2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Icon_MouseDown);
			this.Icon2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Icon_MouseMove);
			this.Icon2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Icon_MouseUp);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 558);
			this.Controls.Add(this.Icon2);
			this.Controls.Add(this.Icon1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.Icon1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Icon2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox Icon1;
		private System.Windows.Forms.PictureBox Icon2;
	}
}

