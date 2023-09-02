using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using AIMLbot;

namespace Robert
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Bot Robert = new Bot();
			Robert.loadSettings();
			Robert.loadAIMLFromFiles();
			Robert.isAcceptingUserInput = false;
			User User = new User("user", Robert);
			Robert.isAcceptingUserInput = true;

		}
	}
}
