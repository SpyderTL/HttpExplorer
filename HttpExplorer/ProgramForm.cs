using System;
using System.Windows.Forms;

namespace HttpExplorer
{
	internal class ProgramForm
	{
		internal static ExplorerForm Form;

		internal static void Show()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Form = new ExplorerForm();

			Form.Text = "HTTP Explorer v1.0";

			Form.UrlTextBox.KeyDown += UrlTextBox_KeyDown;

			Form.UrlTextBox.Focus();

			Application.Run(Form);
		}

		private static void UrlTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				Form.TreeView.Nodes.Add(new TreeNode(Form.UrlTextBox.Text)
				{
					Tag = Form.UrlTextBox.Text
				});
			}
		}
	}
}