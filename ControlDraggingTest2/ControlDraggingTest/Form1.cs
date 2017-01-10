using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDraggingTest {
	public partial class Form1 : Form {
		bool IconMoveFlag;
		int gapX, gapY;
		public Form1() {
			InitializeComponent();
		}
		PictureBox icon;

		private void Icon_MouseDown(object sender, MouseEventArgs e) {
			if(icon != null && icon != (PictureBox) sender) icon.BorderStyle = BorderStyle.None;
			icon = (PictureBox)sender;
			if (!IconMoveFlag) {
				IconMoveFlag = true;
				gapX = e.Location.X;
				gapY = e.Location.Y;
				icon.BorderStyle = BorderStyle.Fixed3D;
			}
		}

		private void Icon_MouseMove(object sender, MouseEventArgs e) {
			if (IconMoveFlag && sender == icon) {
				icon.Location = new Point(
					(icon.Location.X + e.X) - gapX,
					(icon.Location.Y + e.Y) - gapY);
			}
		}

		private void Icon_MouseUp(object sender, MouseEventArgs e) {
			if (IconMoveFlag) {
				IconMoveFlag = false;
				icon.Location = new Point(
					(icon.Location.X + e.X) - gapX,
					(icon.Location.Y + e.Y) - gapY);
			}
			//icon.BorderStyle = BorderStyle.None;
		}
	}
}
