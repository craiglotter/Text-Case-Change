using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Diagnostics;
using System.Globalization;

namespace Text_Case_Change
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	/// 


	public class Main_Screen : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label progressbar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox inputtext;
		private System.Windows.Forms.RichTextBox outputtext;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;



		public Main_Screen()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
	
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Main_Screen));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.progressbar = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.inputtext = new System.Windows.Forms.RichTextBox();
			this.outputtext = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton5);
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(416, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(136, 144);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Case Option";
			// 
			// radioButton5
			// 
			this.radioButton5.Location = new System.Drawing.Point(16, 112);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.TabIndex = 4;
			this.radioButton5.Text = "tOGGLE cASE";
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(16, 88);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.TabIndex = 3;
			this.radioButton4.Text = "Title Case";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(16, 64);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "UPPER CASE";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(16, 40);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "lowercase";
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(16, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 16);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Sentence case";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SteelBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(440, 288);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 20);
			this.button1.TabIndex = 3;
			this.button1.Text = "PROCESS";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// progressbar
			// 
			this.progressbar.BackColor = System.Drawing.Color.Red;
			this.progressbar.Location = new System.Drawing.Point(432, 376);
			this.progressbar.Name = "progressbar";
			this.progressbar.Size = new System.Drawing.Size(0, 12);
			this.progressbar.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(416, 352);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "0/0";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// inputtext
			// 
			this.inputtext.BackColor = System.Drawing.Color.White;
			this.inputtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputtext.ForeColor = System.Drawing.Color.Black;
			this.inputtext.Location = new System.Drawing.Point(16, 32);
			this.inputtext.Name = "inputtext";
			this.inputtext.Size = new System.Drawing.Size(376, 168);
			this.inputtext.TabIndex = 8;
			this.inputtext.Text = "";
			// 
			// outputtext
			// 
			this.outputtext.BackColor = System.Drawing.Color.White;
			this.outputtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.outputtext.ForeColor = System.Drawing.Color.Black;
			this.outputtext.Location = new System.Drawing.Point(16, 224);
			this.outputtext.Name = "outputtext";
			this.outputtext.Size = new System.Drawing.Size(376, 168);
			this.outputtext.TabIndex = 9;
			this.outputtext.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(431, 375);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 14);
			this.label4.TabIndex = 7;
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(480, 352);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "lines edited";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(416, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 72);
			this.label1.TabIndex = 12;
			this.label1.Text = "SIMPLY ENTER TEXT WHOSE CASE YOU WANT TO CHANGE INTO THE INPUT TEXTBOX ABOVE, SEL" +
				"ECT THE CASE OPTION YOU WISH TO APPLY AND CLICK ON THE ‘PROCESS’ BUTTON TO BEGIN" +
				" THE OPERATION.";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "Input Text:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 208);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 14;
			this.label6.Text = "Output Text:";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Location = new System.Drawing.Point(15, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(378, 170);
			this.label7.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.Location = new System.Drawing.Point(15, 223);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(378, 170);
			this.label8.TabIndex = 16;
			// 
			// Main_Screen
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(570, 408);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.outputtext);
			this.Controls.Add(this.inputtext);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.progressbar);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(576, 440);
			this.MinimumSize = new System.Drawing.Size(576, 440);
			this.Name = "Main_Screen";
			this.Text = "Text Case Change 20050804.3";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Main_Screen());
		}

		private void increment_progressbar(int progresswidth, int currentcount, int totalcount)
		{
			label3.Text = currentcount + "/" + totalcount;
			label3.Refresh();
			progressbar.Width = progresswidth;
			progressbar.Refresh();			
		}

		private void Error_Handler(System.Exception except)
		{
			MessageBox.Show("Error Encountered:\n" + except.ToString(),"Error Encountered",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			progressbar.Hide();
			progressbar.Refresh();
		}

		private void process_text()
		{
			label4.BackColor = Color.Transparent;
			label4.Text = "";
			label4.Refresh();

			increment_progressbar(0,0,inputtext.Lines.Length);
			progressbar.Show();
			progressbar.Refresh();
			//progressbar.Width = 0;
			//progressbar.Refresh();
			outputtext.ResetText();
			outputtext.Refresh();
			//label2.Text = "Begin.";
			try
			{
				int caseaction;
				caseaction = 0;
				if (radioButton1.Checked == true)
					caseaction = 1;
				if (radioButton2.Checked == true)
					caseaction = 2;
				if (radioButton3.Checked == true)
					caseaction = 3;
				if (radioButton4.Checked == true)
					caseaction = 4;
				if (radioButton5.Checked == true)
					caseaction = 5;
				for (int counter = 0; counter<inputtext.Lines.Length; counter++)
				{
					//label2.Text = counter.ToString();
					//label2.Text = caseaction.ToString();
					//label2.Refresh();
		
				
					Worker work1 = new Worker();
					Thread workerthread = new Thread(new ThreadStart(work1.process_text));
					work1.inputtext = inputtext.Lines[counter];
					work1.caseaction = caseaction;
					workerthread.Start();
					while(!workerthread.IsAlive);
					Thread.Sleep(1);
					workerthread.Join();
					if (outputtext.Text == "")
						outputtext.AppendText(work1.outputtext);
					else
						outputtext.AppendText("\n" + work1.outputtext);
					
					

					float d =  (float) System.Math.Round((((float)(counter + 1)) / ((float) inputtext.Lines.Length)) * 100,0);
					//label3.Text = counter + "+1 \\ " + inputtext.Lines.Length + " = " + d.ToString();
					//label3.Refresh();
					increment_progressbar((int) d,(counter + 1),inputtext.Lines.Length);
				}
				//label2.Text = "Done.";
				progressbar.Hide();
				label4.BackColor = Color.Red;
				label4.Text = "COMPLETE  ";
				label4.Refresh();
			}
			catch(System.Exception except)
			{
				Error_Handler(except);
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
		process_text();
		}

		
	}

	public class Worker
	{
		public string inputtext;
		public string outputtext;
		public int caseaction;

		private void Error_Handler(System.Exception except)
		{
			MessageBox.Show("Error Encountered:\n" + except.ToString(),"Error Encountered",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			//progressbar.Hide();
			//progressbar.Refresh();
		}

		public void process_text()
		{
		try
		{
			switch(caseaction)
			{
				case 1:
					outputtext = sentencecase(inputtext);
					break;
				case 2:
					outputtext = inputtext.ToLower();
					break;
				case 3:
					outputtext = inputtext.ToUpper();
					break;
				case 4:
					outputtext = titlecase(inputtext);
					break;
				case 5:
					outputtext = togglecase(inputtext);
					break;
				default:
					//dostuff;
					break;
			}
				
			}
			catch(System.Exception except)
			{
				Error_Handler(except);
			}
		}

		private string sentencecase(string input)
		{
			string output = "";
			output = Paragraph.ToSentenceCase(input);
			return output;
		}

		private string titlecase(string input)
		{
			string output = "";
			CultureInfo cinfo = new CultureInfo("en-US");
			output = cinfo.TextInfo.ToTitleCase(input.ToLower());
			return output;
		}

		private string togglecase(string input)
		{
			string output = "";
			output = input;
			string loutput = output.ToLower();
			string uoutput = output.ToUpper();
			char[] lo = loutput.ToCharArray();
			char[] uo = uoutput.ToCharArray();
			char[] o = output.ToCharArray();
			output = "";
			for (int counter = 0; counter<o.Length; counter++)
			{
				if (o[counter].Equals(uo[counter]) == true)
					o[counter] = lo[counter];
				else
					o[counter] = uo[counter];
			output = output + o[counter].ToString();
			}
			
			return output;
		}

	}

	/// <summary>
	/// Represents a paragraph in English
	/// </summary>
	public abstract class Paragraph
	{
		/// <summary>
		/// Convert a string in arbitrary case to English sentence capitalisation.
		/// </summary>
		/// <param name="text">The text to convert</param>
		/// <returns>The paragraph of text</returns>
		public static string ToSentenceCase(string text)
		{
			string temporary = text.ToLower();
			string result = "";
			while (temporary.Length>0)
			{
				string[] splitTemporary = splitAtFirstSentence(temporary);
				temporary = splitTemporary[1];
				if (splitTemporary[0].Length>0)
				{
					result += capitaliseSentence(splitTemporary[0]);
				} 
				else
				{
					result += capitaliseSentence(splitTemporary[1]);
					temporary = "";
				}
			}
			return result; 
		}

		private static string capitaliseSentence(string sentence)
		{
			string result = "";
			if (sentence.Length > 0) 
			{
				while (sentence[0]==' ')
				{
					sentence = sentence.Remove(0,1);
					result+=" ";
				}
				if (sentence.Length>0)
				{
					result += sentence.TrimStart().Substring(0, 1).ToUpper();
					result += sentence.TrimStart().Substring(1, sentence.TrimStart().Length-1);
				}
			}
			return result;
		}

		private static string[] splitAtFirstSentence(string text)
		{
			//these are the characters to start a new sentence after
			int lastChar = text.IndexOfAny(new char[] {'.', ':', '\n', '\r', '!', '?'})+1;
			if (lastChar==1)
			{
				lastChar = 0;
			}
			return new string[] { text.Substring(0, lastChar), text.Substring(lastChar, text.Length-lastChar) };
		}
	}

}
