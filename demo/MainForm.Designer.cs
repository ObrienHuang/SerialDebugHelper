/*
 * Created by SharpDevelop.
 * User: Obrien
 * Date: 2017/11/8
 * Time: 23:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace demo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox comboBox_com;
		private System.Windows.Forms.Button btn_open;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.ComboBox comboBox_baudrate;
		private System.Windows.Forms.ComboBox comboBox_databits;
		private System.Windows.Forms.ComboBox comboBox_stopbits;
		private System.Windows.Forms.ComboBox comboBox_parity;
		private System.Windows.Forms.ComboBox comboBox_flow;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox_rec;
		private System.Windows.Forms.TextBox textBox_send;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox checkBox_rec_hex;
		private System.Windows.Forms.CheckBox checkBox_rec_char;
		private System.Windows.Forms.Label label_cnt_rec;
		private System.Windows.Forms.Label label_cnt_send;
		private System.Windows.Forms.CheckBox checkBox_send_hex;
		private System.Windows.Forms.CheckBox checkBox_send_char;
		private System.Windows.Forms.Button btn_cls_rec;
		private System.Windows.Forms.Button btn_cls_send;
		private System.Windows.Forms.TextBox textBox_send_time;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox checkBox_auto_send;
		private System.Windows.Forms.Button btn_hande_send;
		private System.Windows.Forms.CheckBox checkBox_huichehuanhang;
		private System.Windows.Forms.Button btn_save_file;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_refresh;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Timer timer_auto_send;
		private System.Windows.Forms.PictureBox pictureBox2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.comboBox_com = new System.Windows.Forms.ComboBox();
			this.btn_open = new System.Windows.Forms.Button();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
			this.comboBox_databits = new System.Windows.Forms.ComboBox();
			this.comboBox_stopbits = new System.Windows.Forms.ComboBox();
			this.comboBox_parity = new System.Windows.Forms.ComboBox();
			this.comboBox_flow = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox_rec = new System.Windows.Forms.TextBox();
			this.textBox_send = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.checkBox_rec_hex = new System.Windows.Forms.CheckBox();
			this.checkBox_rec_char = new System.Windows.Forms.CheckBox();
			this.label_cnt_rec = new System.Windows.Forms.Label();
			this.label_cnt_send = new System.Windows.Forms.Label();
			this.checkBox_send_hex = new System.Windows.Forms.CheckBox();
			this.checkBox_send_char = new System.Windows.Forms.CheckBox();
			this.btn_cls_rec = new System.Windows.Forms.Button();
			this.btn_cls_send = new System.Windows.Forms.Button();
			this.textBox_send_time = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.checkBox_auto_send = new System.Windows.Forms.CheckBox();
			this.btn_hande_send = new System.Windows.Forms.Button();
			this.checkBox_huichehuanhang = new System.Windows.Forms.CheckBox();
			this.btn_save_file = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_refresh = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.timer_auto_send = new System.Windows.Forms.Timer(this.components);
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox_com
			// 
			this.comboBox_com.FormattingEnabled = true;
			this.comboBox_com.Location = new System.Drawing.Point(61, 27);
			this.comboBox_com.Name = "comboBox_com";
			this.comboBox_com.Size = new System.Drawing.Size(121, 20);
			this.comboBox_com.TabIndex = 0;
			// 
			// btn_open
			// 
			this.btn_open.Location = new System.Drawing.Point(49, 243);
			this.btn_open.Name = "btn_open";
			this.btn_open.Size = new System.Drawing.Size(75, 23);
			this.btn_open.TabIndex = 1;
			this.btn_open.Text = "打开串口";
			this.btn_open.UseVisualStyleBackColor = true;
			this.btn_open.Click += new System.EventHandler(this.btn_openClick);
			// 
			// comboBox_baudrate
			// 
			this.comboBox_baudrate.FormattingEnabled = true;
			this.comboBox_baudrate.Items.AddRange(new object[] {
			"1200",
			"2400",
			"4800",
			"9600",
			"19200",
			"38400",
			"43000",
			"56000",
			"57600",
			"115200"});
			this.comboBox_baudrate.Location = new System.Drawing.Point(61, 62);
			this.comboBox_baudrate.Name = "comboBox_baudrate";
			this.comboBox_baudrate.Size = new System.Drawing.Size(121, 20);
			this.comboBox_baudrate.TabIndex = 2;
			this.comboBox_baudrate.Text = "9600";
			// 
			// comboBox_databits
			// 
			this.comboBox_databits.FormattingEnabled = true;
			this.comboBox_databits.Items.AddRange(new object[] {
			"5",
			"6",
			"7",
			"8"});
			this.comboBox_databits.Location = new System.Drawing.Point(61, 99);
			this.comboBox_databits.Name = "comboBox_databits";
			this.comboBox_databits.Size = new System.Drawing.Size(121, 20);
			this.comboBox_databits.TabIndex = 3;
			this.comboBox_databits.Text = "8";
			// 
			// comboBox_stopbits
			// 
			this.comboBox_stopbits.FormattingEnabled = true;
			this.comboBox_stopbits.Items.AddRange(new object[] {
			"1",
			"1.5",
			"2"});
			this.comboBox_stopbits.Location = new System.Drawing.Point(61, 136);
			this.comboBox_stopbits.Name = "comboBox_stopbits";
			this.comboBox_stopbits.Size = new System.Drawing.Size(121, 20);
			this.comboBox_stopbits.TabIndex = 4;
			this.comboBox_stopbits.Text = "1";
			// 
			// comboBox_parity
			// 
			this.comboBox_parity.FormattingEnabled = true;
			this.comboBox_parity.Items.AddRange(new object[] {
			"None",
			"Odd",
			"Even",
			"Mark",
			"Space"});
			this.comboBox_parity.Location = new System.Drawing.Point(61, 173);
			this.comboBox_parity.Name = "comboBox_parity";
			this.comboBox_parity.Size = new System.Drawing.Size(121, 20);
			this.comboBox_parity.TabIndex = 5;
			this.comboBox_parity.Text = "None";
			// 
			// comboBox_flow
			// 
			this.comboBox_flow.Enabled = false;
			this.comboBox_flow.FormattingEnabled = true;
			this.comboBox_flow.Items.AddRange(new object[] {
			"Hardware",
			"Software",
			"None",
			"Custom"});
			this.comboBox_flow.Location = new System.Drawing.Point(62, 209);
			this.comboBox_flow.Name = "comboBox_flow";
			this.comboBox_flow.Size = new System.Drawing.Size(121, 20);
			this.comboBox_flow.TabIndex = 6;
			this.comboBox_flow.Text = "None";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(5, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "串口号";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(2, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "波特率";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(2, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "数据位";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(2, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "停止位";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(2, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "校验位";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(3, 207);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "流  控";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox_rec
			// 
			this.textBox_rec.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox_rec.Location = new System.Drawing.Point(214, 25);
			this.textBox_rec.Multiline = true;
			this.textBox_rec.Name = "textBox_rec";
			this.textBox_rec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_rec.Size = new System.Drawing.Size(517, 241);
			this.textBox_rec.TabIndex = 13;
			this.textBox_rec.TextChanged += new System.EventHandler(this.TextBox_recTextChanged);
			// 
			// textBox_send
			// 
			this.textBox_send.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox_send.Location = new System.Drawing.Point(214, 288);
			this.textBox_send.Multiline = true;
			this.textBox_send.Name = "textBox_send";
			this.textBox_send.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_send.Size = new System.Drawing.Size(517, 120);
			this.textBox_send.TabIndex = 14;
			this.textBox_send.TextChanged += new System.EventHandler(this.TextBox_sendTextChanged);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(214, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 20);
			this.label7.TabIndex = 15;
			this.label7.Text = "接收区：";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(214, 268);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 20);
			this.label8.TabIndex = 16;
			this.label8.Text = "发送区：";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox_rec_hex
			// 
			this.checkBox_rec_hex.Location = new System.Drawing.Point(737, 27);
			this.checkBox_rec_hex.Name = "checkBox_rec_hex";
			this.checkBox_rec_hex.Size = new System.Drawing.Size(55, 24);
			this.checkBox_rec_hex.TabIndex = 17;
			this.checkBox_rec_hex.Text = "HEX";
			this.checkBox_rec_hex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox_rec_hex.UseVisualStyleBackColor = true;
			this.checkBox_rec_hex.CheckedChanged += new System.EventHandler(this.CheckBox_rec_hexCheckedChanged);
			// 
			// checkBox_rec_char
			// 
			this.checkBox_rec_char.Checked = true;
			this.checkBox_rec_char.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_rec_char.Location = new System.Drawing.Point(737, 57);
			this.checkBox_rec_char.Name = "checkBox_rec_char";
			this.checkBox_rec_char.Size = new System.Drawing.Size(55, 24);
			this.checkBox_rec_char.TabIndex = 18;
			this.checkBox_rec_char.Text = "Char";
			this.checkBox_rec_char.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox_rec_char.UseVisualStyleBackColor = true;
			this.checkBox_rec_char.CheckedChanged += new System.EventHandler(this.CheckBox_rec_charCheckedChanged);
			// 
			// label_cnt_rec
			// 
			this.label_cnt_rec.Location = new System.Drawing.Point(628, 5);
			this.label_cnt_rec.Name = "label_cnt_rec";
			this.label_cnt_rec.Size = new System.Drawing.Size(100, 18);
			this.label_cnt_rec.TabIndex = 19;
			this.label_cnt_rec.Text = "rec：0";
			this.label_cnt_rec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label_cnt_send
			// 
			this.label_cnt_send.Location = new System.Drawing.Point(628, 267);
			this.label_cnt_send.Name = "label_cnt_send";
			this.label_cnt_send.Size = new System.Drawing.Size(100, 18);
			this.label_cnt_send.TabIndex = 20;
			this.label_cnt_send.Text = "send：0";
			this.label_cnt_send.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBox_send_hex
			// 
			this.checkBox_send_hex.Location = new System.Drawing.Point(737, 297);
			this.checkBox_send_hex.Name = "checkBox_send_hex";
			this.checkBox_send_hex.Size = new System.Drawing.Size(55, 24);
			this.checkBox_send_hex.TabIndex = 21;
			this.checkBox_send_hex.Text = "HEX";
			this.checkBox_send_hex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox_send_hex.UseVisualStyleBackColor = true;
			this.checkBox_send_hex.CheckedChanged += new System.EventHandler(this.CheckBox_send_hexCheckedChanged);
			// 
			// checkBox_send_char
			// 
			this.checkBox_send_char.Checked = true;
			this.checkBox_send_char.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_send_char.Location = new System.Drawing.Point(737, 327);
			this.checkBox_send_char.Name = "checkBox_send_char";
			this.checkBox_send_char.Size = new System.Drawing.Size(55, 24);
			this.checkBox_send_char.TabIndex = 22;
			this.checkBox_send_char.Text = "Char";
			this.checkBox_send_char.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox_send_char.UseVisualStyleBackColor = true;
			this.checkBox_send_char.CheckedChanged += new System.EventHandler(this.CheckBox_send_charCheckedChanged);
			// 
			// btn_cls_rec
			// 
			this.btn_cls_rec.Location = new System.Drawing.Point(737, 243);
			this.btn_cls_rec.Name = "btn_cls_rec";
			this.btn_cls_rec.Size = new System.Drawing.Size(55, 23);
			this.btn_cls_rec.TabIndex = 23;
			this.btn_cls_rec.Text = "清空";
			this.btn_cls_rec.UseVisualStyleBackColor = true;
			this.btn_cls_rec.Click += new System.EventHandler(this.Btn_cls_recClick);
			// 
			// btn_cls_send
			// 
			this.btn_cls_send.Location = new System.Drawing.Point(737, 385);
			this.btn_cls_send.Name = "btn_cls_send";
			this.btn_cls_send.Size = new System.Drawing.Size(55, 23);
			this.btn_cls_send.TabIndex = 24;
			this.btn_cls_send.Text = "清空";
			this.btn_cls_send.UseVisualStyleBackColor = true;
			this.btn_cls_send.Click += new System.EventHandler(this.Btn_cls_sendClick);
			// 
			// textBox_send_time
			// 
			this.textBox_send_time.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox_send_time.Location = new System.Drawing.Point(546, 413);
			this.textBox_send_time.Name = "textBox_send_time";
			this.textBox_send_time.Size = new System.Drawing.Size(57, 23);
			this.textBox_send_time.TabIndex = 25;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label11.Location = new System.Drawing.Point(609, 416);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(41, 18);
			this.label11.TabIndex = 26;
			this.label11.Text = "ms/次";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBox_auto_send
			// 
			this.checkBox_auto_send.Location = new System.Drawing.Point(473, 413);
			this.checkBox_auto_send.Name = "checkBox_auto_send";
			this.checkBox_auto_send.Size = new System.Drawing.Size(72, 24);
			this.checkBox_auto_send.TabIndex = 27;
			this.checkBox_auto_send.Text = "定时发送";
			this.checkBox_auto_send.UseVisualStyleBackColor = true;
			this.checkBox_auto_send.CheckedChanged += new System.EventHandler(this.CheckBox_auto_sendCheckedChanged);
			// 
			// btn_hande_send
			// 
			this.btn_hande_send.Location = new System.Drawing.Point(656, 413);
			this.btn_hande_send.Name = "btn_hande_send";
			this.btn_hande_send.Size = new System.Drawing.Size(75, 23);
			this.btn_hande_send.TabIndex = 28;
			this.btn_hande_send.Text = "手动发送";
			this.btn_hande_send.UseVisualStyleBackColor = true;
			this.btn_hande_send.Click += new System.EventHandler(this.Btn_hande_sendClick);
			// 
			// checkBox_huichehuanhang
			// 
			this.checkBox_huichehuanhang.Location = new System.Drawing.Point(737, 355);
			this.checkBox_huichehuanhang.Name = "checkBox_huichehuanhang";
			this.checkBox_huichehuanhang.Size = new System.Drawing.Size(72, 24);
			this.checkBox_huichehuanhang.TabIndex = 29;
			this.checkBox_huichehuanhang.Text = "回车换行";
			this.checkBox_huichehuanhang.UseVisualStyleBackColor = true;
			this.checkBox_huichehuanhang.CheckedChanged += new System.EventHandler(this.CheckBox_huichehuanhangCheckedChanged);
			// 
			// btn_save_file
			// 
			this.btn_save_file.Location = new System.Drawing.Point(738, 214);
			this.btn_save_file.Name = "btn_save_file";
			this.btn_save_file.Size = new System.Drawing.Size(54, 23);
			this.btn_save_file.TabIndex = 30;
			this.btn_save_file.Text = "保存至";
			this.btn_save_file.UseVisualStyleBackColor = true;
			this.btn_save_file.Click += new System.EventHandler(this.Btn_save_fileClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(12, 244);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(20, 20);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 31;
			this.pictureBox1.TabStop = false;
			// 
			// btn_refresh
			// 
			this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
			this.btn_refresh.Location = new System.Drawing.Point(138, 243);
			this.btn_refresh.Name = "btn_refresh";
			this.btn_refresh.Size = new System.Drawing.Size(24, 24);
			this.btn_refresh.TabIndex = 32;
			this.btn_refresh.UseVisualStyleBackColor = true;
			this.btn_refresh.Click += new System.EventHandler(this.btn_refreshClick);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "red.png");
			this.imageList1.Images.SetKeyName(1, "green.png");
			// 
			// timer_auto_send
			// 
			this.timer_auto_send.Tick += new System.EventHandler(this.Timer_auto_sendTick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(15, 297);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(147, 130);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 33;
			this.pictureBox2.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(807, 443);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btn_refresh);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_save_file);
			this.Controls.Add(this.checkBox_huichehuanhang);
			this.Controls.Add(this.btn_hande_send);
			this.Controls.Add(this.checkBox_auto_send);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textBox_send_time);
			this.Controls.Add(this.btn_cls_send);
			this.Controls.Add(this.btn_cls_rec);
			this.Controls.Add(this.checkBox_send_char);
			this.Controls.Add(this.checkBox_send_hex);
			this.Controls.Add(this.label_cnt_send);
			this.Controls.Add(this.label_cnt_rec);
			this.Controls.Add(this.checkBox_rec_char);
			this.Controls.Add(this.checkBox_rec_hex);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox_send);
			this.Controls.Add(this.textBox_rec);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox_flow);
			this.Controls.Add(this.comboBox_parity);
			this.Controls.Add(this.comboBox_stopbits);
			this.Controls.Add(this.comboBox_databits);
			this.Controls.Add(this.comboBox_baudrate);
			this.Controls.Add(this.btn_open);
			this.Controls.Add(this.comboBox_com);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "串口调试助手-v1.0  by：http://www.cucxj.cn";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
	
}
