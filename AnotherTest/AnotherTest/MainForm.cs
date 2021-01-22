/*
 * Created by SharpDevelop.
 * User: User
 * Date: 11/2/2020
 * Time: 7:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AnotherTest
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			InitializeComponent();
			
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
				frm2.Show();
				Form3 frm3 = new Form3();
				frm3.Show();
					Form4 frm4 = new Form4();
				frm4.Show();
				
		}
		
		void frm1_close(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			
			Form2 frm2 = new Form2();
				frm2.Show();
				Form3 frm3 = new Form3();
				frm3.Show();
				Form4 frm4 = new Form4();
				frm4.Show();
		}
		
		
	}
}
