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

		Label lb = new Label();
		lb.Width = fm.Width;
		lb.Height = fm.Height;

		string[] str = new string [3]{"シャーペン","下敷き","マウス"};

		foreach (string str2 in str)
		{
			lb.Text += str2 + "\n";
		}
		
		lb.Parent = fm;

		Application.Run(fm);
	}

}