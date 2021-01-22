/*
 * Created by SharpDevelop.
 * User: User
 * Date: 11/3/2020
 * Time: 5:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnotherTest
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
		{
			this.Hide();
			
			InitializeComponent();
			
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.Show();
				MainForm frm1 = new MainForm();
				frm1.Show();
				Form3 frm3 = new Form3();
				frm3.Show();
				
		}
		
		void form4_close(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			Form2 frm2 = new Form2();
			frm2.Show();
				MainForm frm1 = new MainForm();
				frm1.Show();
				Form3 frm3 = new Form3();
				frm3.Show();
		}
	}
}
