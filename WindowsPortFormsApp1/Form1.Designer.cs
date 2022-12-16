
namespace WindowsPortFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbRTS = new System.Windows.Forms.CheckBox();
            this.ckbDTR = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxParityBits = new System.Windows.Forms.ComboBox();
            this.CBoxStopBits = new System.Windows.Forms.ComboBox();
            this.CBoxDataBits = new System.Windows.Forms.ComboBox();
            this.CBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.CBoxComPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ComPortStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckbWrite = new System.Windows.Forms.CheckBox();
            this.ckbWriteLine = new System.Windows.Forms.CheckBox();
            this.ckbUseReturn = new System.Windows.Forms.CheckBox();
            this.ckbSendData = new System.Windows.Forms.CheckBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DataOutLength = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DataInLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxDataIn = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ckbContinue = new System.Windows.Forms.CheckBox();
            this.ckbAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.btnClearOutData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbRTS);
            this.groupBox1.Controls.Add(this.ckbDTR);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBoxParityBits);
            this.groupBox1.Controls.Add(this.CBoxStopBits);
            this.groupBox1.Controls.Add(this.CBoxDataBits);
            this.groupBox1.Controls.Add(this.CBoxBaudRate);
            this.groupBox1.Controls.Add(this.CBoxComPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // ckbRTS
            // 
            this.ckbRTS.AutoSize = true;
            this.ckbRTS.Location = new System.Drawing.Point(123, 151);
            this.ckbRTS.Name = "ckbRTS";
            this.ckbRTS.Size = new System.Drawing.Size(80, 16);
            this.ckbRTS.TabIndex = 10;
            this.ckbRTS.Text = "RTS Enable";
            this.ckbRTS.UseVisualStyleBackColor = true;
            this.ckbRTS.CheckedChanged += new System.EventHandler(this.ckbRTS_CheckedChanged);
            // 
            // ckbDTR
            // 
            this.ckbDTR.AutoSize = true;
            this.ckbDTR.Location = new System.Drawing.Point(25, 151);
            this.ckbDTR.Name = "ckbDTR";
            this.ckbDTR.Size = new System.Drawing.Size(82, 16);
            this.ckbDTR.TabIndex = 6;
            this.ckbDTR.Text = "DTR Enable";
            this.ckbDTR.UseVisualStyleBackColor = true;
            this.ckbDTR.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "ParityBits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "StopBits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "DataBits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "BaudRate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "ComPort";
            // 
            // CBoxParityBits
            // 
            this.CBoxParityBits.FormattingEnabled = true;
            this.CBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.CBoxParityBits.Location = new System.Drawing.Point(86, 125);
            this.CBoxParityBits.Name = "CBoxParityBits";
            this.CBoxParityBits.Size = new System.Drawing.Size(121, 20);
            this.CBoxParityBits.TabIndex = 4;
            this.CBoxParityBits.Text = "None";
            // 
            // CBoxStopBits
            // 
            this.CBoxStopBits.FormattingEnabled = true;
            this.CBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.CBoxStopBits.Location = new System.Drawing.Point(86, 99);
            this.CBoxStopBits.Name = "CBoxStopBits";
            this.CBoxStopBits.Size = new System.Drawing.Size(121, 20);
            this.CBoxStopBits.TabIndex = 3;
            this.CBoxStopBits.Text = "One";
            // 
            // CBoxDataBits
            // 
            this.CBoxDataBits.FormattingEnabled = true;
            this.CBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.CBoxDataBits.Location = new System.Drawing.Point(86, 73);
            this.CBoxDataBits.Name = "CBoxDataBits";
            this.CBoxDataBits.Size = new System.Drawing.Size(121, 20);
            this.CBoxDataBits.TabIndex = 2;
            this.CBoxDataBits.Text = "8";
            // 
            // CBoxBaudRate
            // 
            this.CBoxBaudRate.FormattingEnabled = true;
            this.CBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.CBoxBaudRate.Location = new System.Drawing.Point(86, 47);
            this.CBoxBaudRate.Name = "CBoxBaudRate";
            this.CBoxBaudRate.Size = new System.Drawing.Size(121, 20);
            this.CBoxBaudRate.TabIndex = 1;
            this.CBoxBaudRate.Text = "9600";
            // 
            // CBoxComPort
            // 
            this.CBoxComPort.FormattingEnabled = true;
            this.CBoxComPort.Location = new System.Drawing.Point(86, 21);
            this.CBoxComPort.Name = "CBoxComPort";
            this.CBoxComPort.Size = new System.Drawing.Size(121, 20);
            this.CBoxComPort.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(14, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ComPortStatus);
            this.groupBox4.Location = new System.Drawing.Point(95, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 65);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Com Port Status";
            // 
            // ComPortStatus
            // 
            this.ComPortStatus.AutoSize = true;
            this.ComPortStatus.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ComPortStatus.Location = new System.Drawing.Point(33, 27);
            this.ComPortStatus.Name = "ComPortStatus";
            this.ComPortStatus.Size = new System.Drawing.Size(45, 19);
            this.ComPortStatus.TabIndex = 0;
            this.ComPortStatus.Text = "OFF";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 88);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(210, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(8, 50);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(8, 21);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(6, 21);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(86, 23);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(6, 21);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(266, 159);
            this.tBoxDataOut.TabIndex = 2;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tBoxDataOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxData_KeyDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckbWrite);
            this.groupBox3.Controls.Add(this.ckbWriteLine);
            this.groupBox3.Controls.Add(this.ckbUseReturn);
            this.groupBox3.Controls.Add(this.ckbSendData);
            this.groupBox3.Controls.Add(this.btnClearData);
            this.groupBox3.Controls.Add(this.btnSendData);
            this.groupBox3.Location = new System.Drawing.Point(6, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 82);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // ckbWrite
            // 
            this.ckbWrite.AutoSize = true;
            this.ckbWrite.Enabled = false;
            this.ckbWrite.Location = new System.Drawing.Point(186, 55);
            this.ckbWrite.Name = "ckbWrite";
            this.ckbWrite.Size = new System.Drawing.Size(50, 16);
            this.ckbWrite.TabIndex = 8;
            this.ckbWrite.Text = "Write";
            this.ckbWrite.UseVisualStyleBackColor = true;
            // 
            // ckbWriteLine
            // 
            this.ckbWriteLine.AutoSize = true;
            this.ckbWriteLine.Enabled = false;
            this.ckbWriteLine.Location = new System.Drawing.Point(186, 25);
            this.ckbWriteLine.Name = "ckbWriteLine";
            this.ckbWriteLine.Size = new System.Drawing.Size(71, 16);
            this.ckbWriteLine.TabIndex = 7;
            this.ckbWriteLine.Text = "WriteLine";
            this.ckbWriteLine.UseVisualStyleBackColor = true;
            // 
            // ckbUseReturn
            // 
            this.ckbUseReturn.AutoSize = true;
            this.ckbUseReturn.Location = new System.Drawing.Point(98, 54);
            this.ckbUseReturn.Name = "ckbUseReturn";
            this.ckbUseReturn.Size = new System.Drawing.Size(76, 16);
            this.ckbUseReturn.TabIndex = 6;
            this.ckbUseReturn.Text = "Use Return";
            this.ckbUseReturn.UseVisualStyleBackColor = true;
            // 
            // ckbSendData
            // 
            this.ckbSendData.AutoSize = true;
            this.ckbSendData.Location = new System.Drawing.Point(98, 25);
            this.ckbSendData.Name = "ckbSendData";
            this.ckbSendData.Size = new System.Drawing.Size(82, 16);
            this.ckbSendData.TabIndex = 5;
            this.ckbSendData.Text = "Send Enable";
            this.ckbSendData.UseVisualStyleBackColor = true;
            this.ckbSendData.CheckedChanged += new System.EventHandler(this.ckbSendData_CheckedChanged);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(7, 50);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(85, 24);
            this.btnClearData.TabIndex = 4;
            this.btnClearData.Text = "Clear Out Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DataOutLength);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.tBoxDataOut);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Location = new System.Drawing.Point(250, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 303);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Transmitter Control";
            // 
            // DataOutLength
            // 
            this.DataOutLength.AutoSize = true;
            this.DataOutLength.Location = new System.Drawing.Point(144, 279);
            this.DataOutLength.Name = "DataOutLength";
            this.DataOutLength.Size = new System.Drawing.Size(11, 12);
            this.DataOutLength.TabIndex = 7;
            this.DataOutLength.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data Out Length:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DataInLength);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.tBoxDataIn);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(534, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(278, 303);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Reciever Control";
            // 
            // DataInLength
            // 
            this.DataInLength.AutoSize = true;
            this.DataInLength.Location = new System.Drawing.Point(144, 279);
            this.DataInLength.Name = "DataInLength";
            this.DataInLength.Size = new System.Drawing.Size(11, 12);
            this.DataInLength.TabIndex = 7;
            this.DataInLength.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "Data In Length:";
            // 
            // tBoxDataIn
            // 
            this.tBoxDataIn.Location = new System.Drawing.Point(6, 21);
            this.tBoxDataIn.Multiline = true;
            this.tBoxDataIn.Name = "tBoxDataIn";
            this.tBoxDataIn.Size = new System.Drawing.Size(266, 159);
            this.tBoxDataIn.TabIndex = 2;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ckbContinue);
            this.groupBox7.Controls.Add(this.ckbAlwaysUpdate);
            this.groupBox7.Controls.Add(this.btnClearOutData);
            this.groupBox7.Location = new System.Drawing.Point(6, 186);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(266, 82);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            // 
            // ckbContinue
            // 
            this.ckbContinue.AutoSize = true;
            this.ckbContinue.Location = new System.Drawing.Point(140, 54);
            this.ckbContinue.Name = "ckbContinue";
            this.ckbContinue.Size = new System.Drawing.Size(91, 16);
            this.ckbContinue.TabIndex = 6;
            this.ckbContinue.Text = "Continue Data";
            this.ckbContinue.UseVisualStyleBackColor = true;
            this.ckbContinue.CheckedChanged += new System.EventHandler(this.ckbContinue_CheckedChanged);
            // 
            // ckbAlwaysUpdate
            // 
            this.ckbAlwaysUpdate.AutoSize = true;
            this.ckbAlwaysUpdate.Checked = true;
            this.ckbAlwaysUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAlwaysUpdate.Location = new System.Drawing.Point(140, 25);
            this.ckbAlwaysUpdate.Name = "ckbAlwaysUpdate";
            this.ckbAlwaysUpdate.Size = new System.Drawing.Size(94, 16);
            this.ckbAlwaysUpdate.TabIndex = 5;
            this.ckbAlwaysUpdate.Text = "Always Update";
            this.ckbAlwaysUpdate.UseVisualStyleBackColor = true;
            this.ckbAlwaysUpdate.CheckedChanged += new System.EventHandler(this.ckbAlwaysUpdate_CheckedChanged);
            // 
            // btnClearOutData
            // 
            this.btnClearOutData.Location = new System.Drawing.Point(9, 21);
            this.btnClearOutData.Name = "btnClearOutData";
            this.btnClearOutData.Size = new System.Drawing.Size(85, 52);
            this.btnClearOutData.TabIndex = 4;
            this.btnClearOutData.Text = "Clear Out Data";
            this.btnClearOutData.UseVisualStyleBackColor = true;
            this.btnClearOutData.Click += new System.EventHandler(this.btnClearOutDataClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 327);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxParityBits;
        private System.Windows.Forms.ComboBox CBoxStopBits;
        private System.Windows.Forms.ComboBox CBoxDataBits;
        private System.Windows.Forms.ComboBox CBoxBaudRate;
        private System.Windows.Forms.ComboBox CBoxComPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ComPortStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label DataOutLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbWrite;
        private System.Windows.Forms.CheckBox ckbWriteLine;
        private System.Windows.Forms.CheckBox ckbUseReturn;
        private System.Windows.Forms.CheckBox ckbSendData;
        private System.Windows.Forms.CheckBox ckbRTS;
        private System.Windows.Forms.CheckBox ckbDTR;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label DataInLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxDataIn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox ckbContinue;
        private System.Windows.Forms.CheckBox ckbAlwaysUpdate;
        private System.Windows.Forms.Button btnClearOutData;
    }
}

