using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
			Size = new Size(1500, 700);
			var label = new Label
			{
				Location = new Point(10, 10),
				Size = new Size(ClientSize.Width/2, 30),
				Text = "basketball"
			};
			var button1 = new Button
			{
				Location = new Point(10, 100),
				Size = new Size(200, 50),
				Text = "Start"
			};
			var button2 = new Button
			{
				Location = new Point(10, 200),
				Size = new Size(200, 50),
				Text = "2"
			};
			var button3 = new Button
			{
				Location = new Point(10, 300),
				Size = new Size(200, 50),
				Text = "3"
			};
			Controls.Add(label);
			Controls.Add(button1);
			Controls.Add(button2);
			Controls.Add(button3);
			button1.Click += (sender, args) => Onbutton1Clicked(sender, args);
		}
		protected virtual void Onbutton1Clicked(object sender, System.EventArgs e)
		{
			Form a = new Form();
			a.Size = new Size(1500, 700);
			a.Location = new Point(0, 0);
			a.Show();
		}
	}
}
