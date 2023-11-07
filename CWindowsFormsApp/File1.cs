using System;
using System.Windows.Forms;


class File1
{

	public static void Main()
	{
		Form fm = new Form();
		fm.Text = "サンプル";
		fm.Width = 250;
		fm.Height = 100;


		Application.Run(fm);
	}

}