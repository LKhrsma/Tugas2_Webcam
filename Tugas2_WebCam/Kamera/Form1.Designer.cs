namespace Kamera
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			comboBoxWebcamlist = new ComboBox();
			buttonstart = new Button();
			buttoncapture = new Button();
			buttonsaveimage = new Button();
			buttonexit = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			prBox1 = new PictureBox();
			prBox2 = new PictureBox();
			textBox1 = new TextBox();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)prBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)prBox2).BeginInit();
			SuspendLayout();
			// 
			// comboBoxWebcamlist
			// 
			comboBoxWebcamlist.BackColor = SystemColors.ActiveCaption;
			comboBoxWebcamlist.FormattingEnabled = true;
			comboBoxWebcamlist.Location = new Point(12, 97);
			comboBoxWebcamlist.Margin = new Padding(2);
			comboBoxWebcamlist.Name = "comboBoxWebcamlist";
			comboBoxWebcamlist.Size = new Size(234, 33);
			comboBoxWebcamlist.TabIndex = 0;
			// 
			// buttonstart
			// 
			buttonstart.BackColor = SystemColors.ActiveCaption;
			buttonstart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			buttonstart.Location = new Point(1216, 266);
			buttonstart.Margin = new Padding(2);
			buttonstart.Name = "buttonstart";
			buttonstart.Size = new Size(91, 49);
			buttonstart.TabIndex = 1;
			buttonstart.Text = "Start";
			buttonstart.UseVisualStyleBackColor = false;
			buttonstart.Click += buttonstart_Click;
			// 
			// buttoncapture
			// 
			buttoncapture.BackColor = SystemColors.ActiveCaption;
			buttoncapture.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			buttoncapture.Location = new Point(1216, 334);
			buttoncapture.Margin = new Padding(2);
			buttoncapture.Name = "buttoncapture";
			buttoncapture.Size = new Size(91, 52);
			buttoncapture.TabIndex = 2;
			buttoncapture.Text = "Capture";
			buttoncapture.UseVisualStyleBackColor = false;
			buttoncapture.Click += button2_Click;
			// 
			// buttonsaveimage
			// 
			buttonsaveimage.BackColor = SystemColors.ActiveCaption;
			buttonsaveimage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			buttonsaveimage.Location = new Point(1216, 403);
			buttonsaveimage.Margin = new Padding(2);
			buttonsaveimage.Name = "buttonsaveimage";
			buttonsaveimage.Size = new Size(91, 53);
			buttonsaveimage.TabIndex = 3;
			buttonsaveimage.Text = "Save";
			buttonsaveimage.UseVisualStyleBackColor = false;
			buttonsaveimage.Click += buttonsaveimage_Click;
			// 
			// buttonexit
			// 
			buttonexit.BackColor = Color.Red;
			buttonexit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			buttonexit.Location = new Point(1237, 11);
			buttonexit.Margin = new Padding(2);
			buttonexit.Name = "buttonexit";
			buttonexit.Size = new Size(70, 32);
			buttonexit.TabIndex = 4;
			buttonexit.Text = "X";
			buttonexit.UseVisualStyleBackColor = false;
			buttonexit.Click += button1_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.95802F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.04198F));
			tableLayoutPanel1.Controls.Add(prBox1, 0, 0);
			tableLayoutPanel1.Controls.Add(prBox2, 1, 0);
			tableLayoutPanel1.Location = new Point(12, 134);
			tableLayoutPanel1.Margin = new Padding(2);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(1191, 468);
			tableLayoutPanel1.TabIndex = 5;
			// 
			// prBox1
			// 
			prBox1.BackColor = SystemColors.ActiveCaption;
			prBox1.Dock = DockStyle.Fill;
			prBox1.Location = new Point(2, 2);
			prBox1.Margin = new Padding(2);
			prBox1.Name = "prBox1";
			prBox1.Size = new Size(591, 464);
			prBox1.SizeMode = PictureBoxSizeMode.Zoom;
			prBox1.TabIndex = 0;
			prBox1.TabStop = false;
			prBox1.Click += prBox1_Click;
			// 
			// prBox2
			// 
			prBox2.BackColor = SystemColors.ActiveCaption;
			prBox2.Dock = DockStyle.Fill;
			prBox2.Location = new Point(597, 2);
			prBox2.Margin = new Padding(2);
			prBox2.Name = "prBox2";
			prBox2.Size = new Size(592, 464);
			prBox2.SizeMode = PictureBoxSizeMode.Zoom;
			prBox2.TabIndex = 1;
			prBox2.TabStop = false;
			prBox2.Click += prBox2_Click;
			// 
			// textBox1
			// 
			textBox1.BackColor = SystemColors.ActiveCaption;
			textBox1.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
			textBox1.ForeColor = SystemColors.InactiveCaptionText;
			textBox1.Location = new Point(410, 22);
			textBox1.Margin = new Padding(2);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(450, 42);
			textBox1.TabIndex = 6;
			textBox1.Text = "WebCam Capture";
			textBox1.TextAlign = HorizontalAlignment.Center;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(1318, 625);
			Controls.Add(textBox1);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(buttonexit);
			Controls.Add(buttonsaveimage);
			Controls.Add(buttoncapture);
			Controls.Add(buttonstart);
			Controls.Add(comboBoxWebcamlist);
			Margin = new Padding(2);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)prBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)prBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox comboBoxWebcamlist;
		private Button buttonstart;
		private Button buttoncapture;
		private Button buttonsaveimage;
		private Button buttonexit;
		private TableLayoutPanel tableLayoutPanel1;
		private PictureBox prBox1;
		private PictureBox prBox2;
		private TextBox textBox1;
	}
}