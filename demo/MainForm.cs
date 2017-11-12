/*
 * Created by SharpDevelop.
 * User: Obrien
 * Date: 2017/11/8
 * Time: 23:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.IO;

namespace demo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		 bool rec_isHex = false;		//十六进制显示标志位
		 bool send_isHex = false;		//十六进制发送标志位
		 bool send_isHuiche = false;	//发送+回车换行
		 int cnt_rec = 0; 				//接收的字节数
		 int cnt_send = 0; 				//发送的字节数
		 private bool Listening = false;
        //是否没有执行完invoke相关操作   
         private bool Closing = false;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			System.Diagnostics.Debug.WriteLine("hello world");
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			get_com_num();
			pictureBox1.Image = imageList1.Images[0];
				
		}
		/*
		 * 打开串口
		 */
		void btn_openClick(object sender, EventArgs e)
		{
			if (serialPort1.IsOpen) {
				try {
					 Closing = true;   
					 while (Listening) 
					 	Application.DoEvents();
					serialPort1.Close();
					btn_open.Text = "打开串口";
					pictureBox1.Image = imageList1.Images[0];
				}
				catch (Exception ex){
					MessageBox.Show(ex.Message, "关闭串口出现错误");
					return;
				}
			}
			else {
				if(comboBox_com.SelectedItem == null) {
					MessageBox.Show("COM口不能为空！", "错误提示");
					return;
				} 
				try {
						serialPort1.PortName = comboBox_com.Text;
						serialPort1.BaudRate = int.Parse(comboBox_baudrate.Text);
						serialPort1.DataBits = int.Parse(comboBox_databits.Text);
						switch (comboBox_stopbits.Text)
						{
							case "1": serialPort1.StopBits = StopBits.One;break;
							case "1.5":serialPort1.StopBits = StopBits.OnePointFive;break;
							case "2":serialPort1.StopBits = StopBits.Two;break;
						}
						switch (comboBox_parity.Text) 
						{
							case "None":serialPort1.Parity = Parity.None;  break;
							case "Odd":serialPort1.Parity = Parity.Odd; break;
							case "Even":serialPort1.Parity = Parity.Odd; break;
							case "Mark":serialPort1.Parity = Parity.Even;break;
							case "Space":serialPort1.Parity = Parity.Space;break;	
						}
					    Closing = false;
						serialPort1.DataReceived +=  serialPort1_DataReceived;
						serialPort1.Open();
						btn_open.Text = "关闭串口";
						pictureBox1.Image = imageList1.Images[1];
				}
				catch (Exception ex){
					MessageBox.Show(ex.Message, "打开串口出现错误");
					return;
				}

			}
		}
		/*
		 * 串口接收函数
		 */
		private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{			
			if (Closing)
            {  
                return; 
            }
		   Listening = true;
		   try {
			   	// this.Invoke就是跨线程访问ui的方法
				this.Invoke((EventHandler)(delegate
				{
					if(rec_isHex == false)
					{
						Byte[] ReceivedData = new Byte[serialPort1.BytesToRead];
						serialPort1.Read(ReceivedData,0,ReceivedData.Length);
						String RecvDataText = null;
						RecvDataText = System.Text.Encoding.Default.GetString ( ReceivedData );
						textBox_rec.Text += RecvDataText;
						cnt_rec += ReceivedData.Length;
						label_cnt_rec.Text = "rec："+cnt_rec.ToString();
					}
				else
				{
					Byte[] ReceivedData = new Byte[serialPort1.BytesToRead];
					serialPort1.Read(ReceivedData,0,ReceivedData.Length);
					String RecvDataText = null;
					for(int i=0;i<ReceivedData.Length-1;i++)
					{
						RecvDataText+=(ReceivedData[i].ToString("X2")+" ");
					}
					textBox_rec.Text += RecvDataText;
					cnt_rec += ReceivedData.Length;
					label_cnt_rec.Text = "rec："+cnt_rec.ToString();
				}
					serialPort1.DiscardInBuffer();//丢弃接收缓冲区数据
				}));
		   }
		   catch (Exception ex){
					MessageBox.Show(ex.Message, "数据接收错误");
					return;
		   }
			finally  {   
                Listening = false;//我用完了，ui可以关闭串口了。   
            }   
		}

		/*
		 * 读取COM口
		 */
		void get_com_num()
		{
			string[] portList = System.IO.Ports.SerialPort.GetPortNames();
			 comboBox_com.Items.Clear();
            for (int i = 0; i < portList.Length; ++i)
            {
                string name = portList[i];
                comboBox_com.Items.Add(name);
            }
		}
		/*
		 * 刷新COM口
		 */
		void btn_refreshClick(object sender, EventArgs e)
		{
			get_com_num();
		}

 		/*
		 * 检查是否发送数据
		 */
		private bool CheckSendData()
		{
			if (textBox_send.Text.Trim() == "")
				return false;
			return true;
		}
		/*
		 * 手动发送
		 */
		void Btn_hande_sendClick(object sender, EventArgs e)
		{
			if (serialPort1.IsOpen)//写串口数据
			{
				try
				{
					/* 16进制发送 */
					if (send_isHex) {
						char[] HexData = textBox_send.Text.ToCharArray();
						int length = StrHexToHex(textBox_send.Text, HexData);
//						for(int i = 0; i < length; i++) {
//							System.Diagnostics.Debug.WriteLine("data[{0}] = {1}", i,HexData[i]);
//						}
						cnt_send += length;
						serialPort1.Write(HexData, 0 , length);
					} /* 字符发送 */ 
					else {
						cnt_send += textBox_send.Text.Length;
						char[] CharData = textBox_send.Text.ToCharArray();
						serialPort1.Write(CharData, 0, CharData.Length);
					}
					if(send_isHuiche) {
						byte[] end = new byte[2];
						end[0] = 0x0D;
						end[1] = 0x0A;
						serialPort1.Write(end, 0, 2);
						cnt_send += 2;
					}
					label_cnt_send.Text = "rec："+cnt_send.ToString();
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message, "发送数据时发生错误"); 
					return;
				}
			}
			else
			{
				MessageBox.Show("串口未打开！", "错误提示");
				return;
			}
			
			if (!CheckSendData())//检测要发送的数据
			{
				MessageBox.Show("请输入要发送的数据！", "错误提示"); 
				return;
			}
		}
		/*
		 * 接收区自动滚动
		 */
		void TextBox_recTextChanged(object sender, EventArgs e)
		{
			this.textBox_rec.SelectionStart = textBox_rec.Text.Length;
			this.textBox_rec.ScrollToCaret();
		}
		/*
		 * 发送区自动滚动
		 */
		void TextBox_sendTextChanged(object sender, EventArgs e)
		{
			this.textBox_send.SelectionStart = textBox_send.Text.Length;
			this.textBox_send.ScrollToCaret();
		}
		/*
		 * 清空接收区
		 */
		void Btn_cls_recClick(object sender, EventArgs e)
		{
			this.textBox_rec.Text = "";
			cnt_rec = 0;
			label_cnt_rec.Text = "rec："+cnt_rec.ToString();
		}
		/*
		 * 清空发送区
		 */
		void Btn_cls_sendClick(object sender, EventArgs e)
		{
			this.textBox_send.Text = "";
			cnt_send = 0;
			label_cnt_send.Text = "send："+cnt_send.ToString();
		}
		/*
		 * char 接收复选框被点击
		 */
		void CheckBox_rec_charCheckedChanged(object sender, EventArgs e)
		{
			if(checkBox_rec_hex.Checked) {
				if (checkBox_rec_char.Checked) {
					MessageBox.Show("请先取消 HEX 显示","错误");
					this.checkBox_rec_char.Checked = false;
				}
			}
			if (this.checkBox_rec_char.Checked) {
				this.checkBox_rec_hex.Checked = false;
				rec_isHex = false;
			} else {
				rec_isHex = true;
				this.checkBox_rec_hex.Checked = true;
			}
		}
		/*
		 * hex 接收复选框被点击
		 */
		void CheckBox_rec_hexCheckedChanged(object sender, EventArgs e)
		{
			if(checkBox_rec_char.Checked) {
				if (checkBox_rec_hex.Checked) {
					MessageBox.Show("请先取消 Char 显示","错误");
					this.checkBox_rec_hex.Checked = false;
				} 
			}
			if (this.checkBox_rec_hex.Checked) {
				rec_isHex = true;
			} else {
				rec_isHex = false;
				this.checkBox_rec_char.Checked = true;
			}
		}
		/*
		 * hex 发送复选框被点击
		 */
		void CheckBox_send_hexCheckedChanged(object sender, EventArgs e)
		{
			if(checkBox_send_char.Checked) {
				if (checkBox_send_hex.Checked) {
					MessageBox.Show("请先取消 Char 显示","错误");
					this.checkBox_send_hex.Checked = false;
				} 
			}
			if (this.checkBox_send_hex.Checked) {
				send_isHex = true;
				MessageBox.Show("例如发送0x00、0x01和0x23三个数据时，则输入00 01 23，需用空格隔开，数据不足2位时，请前面用0补齐，否则提示输入数据格式有误！","使用说明");
			} else {
				send_isHex = false;
				this.checkBox_send_char.Checked = true;
			}
		}
		/*
		 * char 发送复选框被点击
		 */
		void CheckBox_send_charCheckedChanged(object sender, EventArgs e)
		{
			if(checkBox_send_hex.Checked) {
				if (checkBox_send_char.Checked) {
					MessageBox.Show("请先取消 HEX 显示","错误");
					this.checkBox_send_char.Checked = false;
				}
			}
			if (this.checkBox_send_char.Checked) {
				this.checkBox_send_hex.Checked = false;
				send_isHex = false;
			} else {
				send_isHex = true;
				this.checkBox_send_hex.Checked = true;
			}
		}
		/*
		 * 回车换行 发送复选框被点击
		 */
		void CheckBox_huichehuanhangCheckedChanged(object sender, EventArgs e)
		{
			if(checkBox_huichehuanhang.Checked) {
				send_isHuiche = true;
			} else {
				send_isHuiche =false;
			}
		}
		/*
		 * 定时 发送复选框被点击
		 */
		void CheckBox_auto_sendCheckedChanged(object sender, EventArgs e)
		{
			if(checkBox_auto_send.Checked) {
				if(serialPort1.IsOpen == false) {
					MessageBox.Show("请先打开串口！","错误提示");
					checkBox_auto_send.Checked = false;
					return;
				}
				if (textBox_send_time.Text.Trim() == "") {
					MessageBox.Show("定时发送的时间不能为空","错误提示");
					checkBox_auto_send.Checked = false;
					return;
				} else if (textBox_send.Text.Trim() == ""){
					MessageBox.Show("发送的数据不能为空","错误提示");
					checkBox_auto_send.Checked = false;
					return;
				}else {
					timer_auto_send.Interval =  int.Parse(textBox_send_time.Text);
					timer_auto_send.Start();
				}
			} else {
				timer_auto_send.Stop();
			}
		}
		/*
		 * 定时 发送
		 */
		void Timer_auto_sendTick(object sender, EventArgs e)
		{
			try
			{
				/* 16进制发送 */
				if (send_isHex) {
					char[] HexData = new char[textBox_send.Text.Length / 2];
					int length = StrHexToHex(textBox_send.Text, HexData);
					cnt_send += length;
					serialPort1.Write(HexData, 0 , length);
				} /* 字符发送 */ 
				else {
					cnt_send += textBox_send.Text.Length;
					char[] CharData = textBox_send.Text.ToCharArray();
					serialPort1.Write(CharData, 0, CharData.Length);
				}
				if(send_isHuiche) {
					byte[] end = new byte[2];
					end[0] = 0x0D;
					end[1] = 0x0A;
					serialPort1.Write(end, 0, 2);
					cnt_send += 2;
				}
				label_cnt_send.Text = "rec："+cnt_send.ToString();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, "发送数据时发生错误"); 
				return;
			}
		}
		/*
		 * 保存为文件
		 */
		void Btn_save_fileClick(object sender, EventArgs e)
		{
            string localFilePath = "";
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型 
            sfd.Filter = "日志文件（*.log）|*.log";
            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;
            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString(); //获得文件路径 
//                string fileNameExt =localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径
//                System.Diagnostics.Debug.WriteLine(fileNameExt);
                string aFirstName = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1, (localFilePath.LastIndexOf(".") - localFilePath.LastIndexOf("\\") - 1));  //文件名
//                System.Diagnostics.Debug.WriteLine(aFirstName);
                string aLastName = localFilePath.Substring(localFilePath.LastIndexOf(".") + 1, (localFilePath.Length - localFilePath.LastIndexOf(".") - 1));   //扩展名
//                System.Diagnostics.Debug.WriteLine(aLastName);
                //获取文件路径，不带文件名 
                string FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\")); 
                //给文件名前加上时间 
				string newFileName = aFirstName + "[" + DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss") + "]" + "."  + aLastName; 
                sfd.FileName = FilePath + "\\" + newFileName;
				try {
	                System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();//输出文件 
	                //将字符串转成byte数组
	                byte[] byteFile = Encoding.UTF8.GetBytes(textBox_rec.Text);
	                fs.Write(byteFile, 0, byteFile.Length);
	                fs.Close();
	                MessageBox.Show("保存成功:" + sfd.FileName);
				}
                catch (Exception ex) {
					MessageBox.Show(ex.Message, "保存文件时发生错误"); 
					return;
				}
            }
		}
		/*
		 * 16进制字符串转16进制
		 */
		int StrHexToHex(string s_buf, char[] val)
		{
			string[] hexValuesSplit = s_buf.Split(' ');
			int i = 0;
			foreach (String hex in hexValuesSplit)
			{
				// Convert the number expressed in base-16 to an integer.
				int value = Convert.ToInt32(hex, 16);
				val[i++] = (char)value;
//				System.Diagnostics.Debug.WriteLine("hexadecimal value = {0}, int value = {1}",hex, value);
			} 
			return i;
		}
	}
}
