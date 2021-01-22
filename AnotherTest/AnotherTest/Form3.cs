/*
 * Created by SharpDevelop.
 * User: User
 * Date: 11/2/2020
 * Time: 8:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnotherTest
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		
		public Form3()
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
				Form4 frm4 = new Form4();
				frm4.Show();
				
			
		}
		
		
		void frm3_close(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			Form2 frm2 = new Form2();
			frm2.Show();
				MainForm frm1 = new MainForm();
				frm1.Show();
				Form4 frm4 = new Form4();
				frm4.Show();
				
			
		}
	}
}
