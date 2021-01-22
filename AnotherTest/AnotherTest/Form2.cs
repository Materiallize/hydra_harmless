/*
 * Created by SharpDevelop.
 * User: User
 * Date: 11/2/2020
 * Time: 8:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnotherTest
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		
		public Form2()
		{
			this.Hide();
			InitializeComponent();
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			Form3 frm3 = new Form3();
				frm3.Show();
				MainForm frm1 = new MainForm();
				frm1.Show();
		}
		
		void frm2_close(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			Form3 frm3 = new Form3();
				frm3.Show();
				MainForm frm1 = new MainForm();
				frm1.Show();
				Form4 frm4 = new Form4();
				frm4.Show();
		}
		
		void Form2Load(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form3 frm3 = new Form3();
				frm3.Show();
				MainForm frm1 = new MainForm();
				frm1.Show();
				Form4 frm4 = new Form4();
				frm4.Show();
		}
	}
}
