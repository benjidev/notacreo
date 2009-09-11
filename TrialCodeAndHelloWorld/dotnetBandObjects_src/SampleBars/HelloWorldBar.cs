using System;
using System.ComponentModel;
using System.Windows.Forms;

using BandObjectLib;
using System.Runtime.InteropServices;

namespace SampleBars
{
	[Guid("AE07101B-46D4-4a98-AF68-0333EA26E113")]
	[BandObject("Hello World Bar", BandObjectStyle.Horizontal | BandObjectStyle.ExplorerToolbar | BandObjectStyle.TaskbarToolBar, HelpText = "Shows bar that says hello.")]
	public class HelloWorldBar : BandObject
	{
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.Container components = null;

		public HelloWorldBar()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		private void InitializeComponent()
		{
		    BandObject thisband = (BandObject) this;
            //this.Explorer.DocumentComplete +=new SHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(Explorer_DocumentComplete);
			
            this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button1.ForeColor = System.Drawing.SystemColors.Info;
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "Say Hello";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// HelloWorldBar
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1});
			this.MinSize = new System.Drawing.Size(150, 24);
			this.Name = "HelloWorldBar";
			this.Size = new System.Drawing.Size(150, 24);
			this.Title = "Hello Bar";
			this.ResumeLayout(false);


		}

	    private void Explorer_DocumentComplete(object pDisp, ref object URL)
        {
            MessageBox.Show(pDisp.ToString() + pDisp.GetType().ToString());
            MessageBox.Show(URL.ToString() + URL.GetType().ToString());
	    }

	    #endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("ZZZZZZ Hello, World!");
		}
	}
}
