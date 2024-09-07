/*      
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/7/2024
 * Time: 1:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
 
namespace creatorTextBox
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		public creatorTB c = new creatorTB();
		
		void Button1Click(object sender, EventArgs e)
		{
			c.createTextBoxOnformX(this,100,100,"TextBox Sample:",ref tl, ref tlb);
			c.createTextBoxOnformX(this,200,100,"TextBox Sample2:",ref tl, ref tlb);
			c.createTextBoxOnformX(this,300,100,"TextBox Sample3:",ref tl, ref tlb);
			c.createTextBoxOnformX(this,400,100,"TextBox Sample4:",ref tl, ref tlb);
			c.createTextBoxOnformX(this,500,100,"TextBox Sample5:",ref tl, ref tlb);
			c.createTextBoxOnformX(this,600,100,"TextBox Sample6:",ref tl, ref tlb);
			c.createTextBoxOnformX(this,700,100,"TextBox Sample7:",ref tl, ref tlb);
			c.createTextBoxOnformX(this,800,100,"TextBox Sample8:",ref tl, ref tlb);
			c.createTextBoxOnformX(this,900,100,"TextBoxSample9:",ref tl, ref tlb);
			c.createTextBoxOnformX(this,1000,100,"TextBoxSample10:",ref tl, ref tlb);
			c.createTextBoxOnformX(this,1100,100,"TextBoxSample11:",ref tl, ref tlb);
		}
		public List<TextBox> tl = new List<TextBox>();
		public List<Label> tlb = new List<Label>();
		public class creatorTB
		{
			
			public void createTextBoxOnformX(MainForm mf, int x, int y, string text,ref List<TextBox> tlx, ref List<Label> tlbx)
			{
				////////////////////////////////////////////////////
				//count controls on form 
				int c = 0 ;
				try{
				c = mf.Controls.Count;
				}
				catch{};
				
				////////////////////////////////////////////////////
				//add new textbox to list of tb
				tlx.Add(new TextBox());
				//count textboxes on list tb
				int ct = 0;
				try{
					ct = tlx.Count;
				}
				catch{};
				
				//add values to list tb [x]
				tlx[ct-1].Left = x;
				tlx[ct-1].Top = y;
				
				////////////////////////////////////////////////////
				//add label to list
				tlbx.Add(new Label());
				//count tables in list lb
				int ctlb = 0;
				try{
					ctlb = tlbx.Count;
				}
				catch{};
				
				
				//add values to list label
				tlbx[ctlb-1].Left = x;
				tlbx[ctlb-1].Top = y-25;
				tlbx[ctlb-1].Text = text;
				
				////////////////////////////////////////////////////
				//add controls to form mf 
				mf.Controls.Add(tlx[ct-1]);
				mf.Controls.Add(tlbx[ctlb-1]);
				
			}
		}
	}
}
