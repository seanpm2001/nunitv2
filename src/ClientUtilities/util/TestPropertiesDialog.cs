using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using NUnit.Core;
using NUnit.Util;

namespace NUnit.UiKit
{
	/// <summary>
	/// Summary description for TestPropertiesDialog.
	/// </summary>
	public class TestPropertiesDialog : System.Windows.Forms.Form
	{
		private TestSuiteTreeNode node;
		private UITestNode test;
		private TestResult result;

		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label testCaseCount;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private NUnit.UiKit.ExpandingLabel ignoreReason;
		private System.Windows.Forms.Label shouldRun;
		private System.Windows.Forms.Label label2;
		private NUnit.UiKit.ExpandingLabel fullName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label leakage;
		private NUnit.UiKit.ExpandingLabel stackTrace;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label elapsedTime;
		private NUnit.UiKit.ExpandingLabel message;
		private System.Windows.Forms.TabPage resultsTab;
		private System.Windows.Forms.TabPage testTab;
		private System.Windows.Forms.Label testResult;
		private System.Windows.Forms.Label label3;
		private System.ComponentModel.IContainer components;

		public TestPropertiesDialog( TestSuiteTreeNode node )
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.node = node;
			this.test = node.Test;
			this.result = node.Result;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.closeButton = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.testTab = new System.Windows.Forms.TabPage();
			this.testCaseCount = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ignoreReason = new NUnit.UiKit.ExpandingLabel();
			this.shouldRun = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.fullName = new NUnit.UiKit.ExpandingLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.resultsTab = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.testResult = new System.Windows.Forms.Label();
			this.leakage = new System.Windows.Forms.Label();
			this.stackTrace = new NUnit.UiKit.ExpandingLabel();
			this.label12 = new System.Windows.Forms.Label();
			this.elapsedTime = new System.Windows.Forms.Label();
			this.message = new NUnit.UiKit.ExpandingLabel();
			this.tabControl1.SuspendLayout();
			this.testTab.SuspendLayout();
			this.resultsTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// closeButton
			// 
			this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.Location = new System.Drawing.Point(184, 160);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(67, 23);
			this.closeButton.TabIndex = 0;
			this.closeButton.Text = "Close";
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.testTab,
																					  this.resultsTab});
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(416, 144);
			this.tabControl1.TabIndex = 13;
			// 
			// testTab
			// 
			this.testTab.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.testCaseCount,
																				  this.label5,
																				  this.label4,
																				  this.ignoreReason,
																				  this.shouldRun,
																				  this.label2,
																				  this.fullName,
																				  this.label1});
			this.testTab.Location = new System.Drawing.Point(4, 25);
			this.testTab.Name = "testTab";
			this.testTab.Size = new System.Drawing.Size(408, 115);
			this.testTab.TabIndex = 0;
			this.testTab.Text = "Test";
			// 
			// testCaseCount
			// 
			this.testCaseCount.Location = new System.Drawing.Point(104, 48);
			this.testCaseCount.Name = "testCaseCount";
			this.testCaseCount.Size = new System.Drawing.Size(48, 16);
			this.testCaseCount.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 16);
			this.label5.TabIndex = 26;
			this.label5.Text = "Reason:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 25;
			this.label4.Text = "Test Count:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ignoreReason
			// 
			this.ignoreReason.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.ignoreReason.Location = new System.Drawing.Point(104, 80);
			this.ignoreReason.Name = "ignoreReason";
			this.ignoreReason.Size = new System.Drawing.Size(296, 16);
			this.ignoreReason.TabIndex = 24;
			// 
			// shouldRun
			// 
			this.shouldRun.Location = new System.Drawing.Point(328, 48);
			this.shouldRun.Name = "shouldRun";
			this.shouldRun.Size = new System.Drawing.Size(32, 16);
			this.shouldRun.TabIndex = 23;
			this.shouldRun.Text = "Yes";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(200, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 16);
			this.label2.TabIndex = 22;
			this.label2.Text = "Runnable?";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// fullName
			// 
			this.fullName.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.fullName.Location = new System.Drawing.Point(104, 16);
			this.fullName.Name = "fullName";
			this.fullName.Size = new System.Drawing.Size(296, 16);
			this.fullName.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 20;
			this.label1.Text = "Full Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// resultsTab
			// 
			this.resultsTab.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.label3,
																					 this.testResult,
																					 this.leakage,
																					 this.stackTrace,
																					 this.label12,
																					 this.elapsedTime,
																					 this.message});
			this.resultsTab.Location = new System.Drawing.Point(4, 25);
			this.resultsTab.Name = "resultsTab";
			this.resultsTab.Size = new System.Drawing.Size(408, 115);
			this.resultsTab.TabIndex = 1;
			this.resultsTab.Text = "Result";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 36;
			this.label3.Text = "Message:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// testResult
			// 
			this.testResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.testResult.Location = new System.Drawing.Point(24, 16);
			this.testResult.Name = "testResult";
			this.testResult.Size = new System.Drawing.Size(72, 16);
			this.testResult.TabIndex = 35;
			this.testResult.Text = "Failure";
			// 
			// leakage
			// 
			this.leakage.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.leakage.Location = new System.Drawing.Point(232, 16);
			this.leakage.Name = "leakage";
			this.leakage.Size = new System.Drawing.Size(168, 16);
			this.leakage.TabIndex = 30;
			this.leakage.Text = "Leakage:";
			// 
			// stackTrace
			// 
			this.stackTrace.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.stackTrace.Expansion = NUnit.UiKit.ExpandingLabel.ExpansionStyle.Both;
			this.stackTrace.Location = new System.Drawing.Point(104, 80);
			this.stackTrace.Name = "stackTrace";
			this.stackTrace.Overlay = false;
			this.stackTrace.Size = new System.Drawing.Size(296, 16);
			this.stackTrace.TabIndex = 29;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(16, 80);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 16);
			this.label12.TabIndex = 28;
			this.label12.Text = "Stack:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// elapsedTime
			// 
			this.elapsedTime.Location = new System.Drawing.Point(104, 16);
			this.elapsedTime.Name = "elapsedTime";
			this.elapsedTime.Size = new System.Drawing.Size(104, 16);
			this.elapsedTime.TabIndex = 27;
			this.elapsedTime.Text = "Time:";
			// 
			// message
			// 
			this.message.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.message.Expansion = NUnit.UiKit.ExpandingLabel.ExpansionStyle.Vertical;
			this.message.Location = new System.Drawing.Point(104, 48);
			this.message.Name = "message";
			this.message.Size = new System.Drawing.Size(288, 16);
			this.message.TabIndex = 25;
			// 
			// TestPropertiesDialog
			// 
			this.AcceptButton = this.closeButton;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(434, 186);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabControl1,
																		  this.closeButton});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TestPropertiesDialog";
			this.Text = "Test Properties";
			this.Load += new System.EventHandler(this.TestPropertiesDialog_Load);
			this.tabControl1.ResumeLayout(false);
			this.testTab.ResumeLayout(false);
			this.resultsTab.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private void closeButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void SetTitleBarText()
		{
			string type;
			if ( test.IsTestCase )
				type = "Case";
			else if ( test.IsFixture )
				type = "Fixture";
			else
				type = "Suite";

			this.Text = string.Format( "Test {0} Properties - {1}", type, test.ShortName );
		}

		/// <summary>
		/// Set up all dialog fields when it loads
		/// </summary>
		private void TestPropertiesDialog_Load(object sender, System.EventArgs e)
		{
			SetTitleBarText();

			// Initialize Test Tab
			fullName.Text = test.FullName;
			shouldRun.Text = test.ShouldRun ? "Yes" : "No";
			ignoreReason.Text = test.IgnoreReason;
			testCaseCount.Text = test.CountTestCases.ToString();

			// Initialize Result Tab
			if ( result == null || !result.Executed )
				tabControl1.TabPages.Remove( resultsTab );
			else
			{
				testResult.Text = result.IsSuccess ? "Success" : "Failure";
				// message may have a leading blank line
				// ToDo: take care of this in label?
				message.Text = TrimLeadingBlankLines( result.Message );
				elapsedTime.Text = string.Format( "Time: {0}", result.Time );
				stackTrace.Text = result.StackTrace;
#if NUNIT_LEAKAGE_TEST
				leakage.Text = string.Format( "Leakage: {0} bytes", result.Leakage );
#endif
			}
		}

		private string TrimLeadingBlankLines( string s )
		{
			if ( s == null ) return s;

			int start = 0;
			for( int i = 0; i < s.Length; i++ )
			{
				switch( s[i] )
				{
					case ' ':
					case '\t':
						break;
					case '\r':
					case '\n':
						start = i + 1;
						break;

					default:
						goto getout;
				}
			}

			getout:
			return start == 0 ? s : s.Substring( start );
		}
	}
}
