namespace EquipViewAppNet
{
    partial class SecsAppView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCommState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControlState = new System.Windows.Forms.Label();
            this.checkBoxEnableComm = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonRemote = new System.Windows.Forms.RadioButton();
            this.radioButtonLocal = new System.Windows.Forms.RadioButton();
            this.radioButtonOffline = new System.Windows.Forms.RadioButton();
            this.变量 = new System.Windows.Forms.GroupBox();
            this.buttonVarSet = new System.Windows.Forms.Button();
            this.textBoxVarValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVarName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEventSend = new System.Windows.Forms.Button();
            this.textBoxEventID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonAlarmSet = new System.Windows.Forms.Button();
            this.buttonAlarmClear = new System.Windows.Forms.Button();
            this.textBoxAlarmID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listViewParam = new System.Windows.Forms.ListView();
            this.textBoxRemoteCmd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.变量.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelCommState);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelControlState);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1222, 73);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(109, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "通信状态";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommState
            // 
            this.labelCommState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCommState.Location = new System.Drawing.Point(242, 20);
            this.labelCommState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCommState.Name = "labelCommState";
            this.labelCommState.Size = new System.Drawing.Size(334, 41);
            this.labelCommState.TabIndex = 10;
            this.labelCommState.Text = "NOT COMMUNICATION";
            this.labelCommState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(669, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "控制状态";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelControlState
            // 
            this.labelControlState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelControlState.Location = new System.Drawing.Point(803, 20);
            this.labelControlState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelControlState.Name = "labelControlState";
            this.labelControlState.Size = new System.Drawing.Size(334, 41);
            this.labelControlState.TabIndex = 8;
            this.labelControlState.Text = "ON-LINE Local ";
            this.labelControlState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxEnableComm
            // 
            this.checkBoxEnableComm.AutoSize = true;
            this.checkBoxEnableComm.Checked = true;
            this.checkBoxEnableComm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableComm.Location = new System.Drawing.Point(109, 42);
            this.checkBoxEnableComm.Name = "checkBoxEnableComm";
            this.checkBoxEnableComm.Size = new System.Drawing.Size(187, 20);
            this.checkBoxEnableComm.TabIndex = 16;
            this.checkBoxEnableComm.Text = "Enable Communication";
            this.checkBoxEnableComm.UseVisualStyleBackColor = true;
            this.checkBoxEnableComm.CheckedChanged += new System.EventHandler(this.checkBoxEnableComm_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonRemote);
            this.groupBox3.Controls.Add(this.radioButtonLocal);
            this.groupBox3.Controls.Add(this.radioButtonOffline);
            this.groupBox3.Controls.Add(this.checkBoxEnableComm);
            this.groupBox3.Location = new System.Drawing.Point(5, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1222, 96);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "通讯控制";
            // 
            // radioButtonRemote
            // 
            this.radioButtonRemote.AutoSize = true;
            this.radioButtonRemote.Checked = true;
            this.radioButtonRemote.Location = new System.Drawing.Point(950, 41);
            this.radioButtonRemote.Name = "radioButtonRemote";
            this.radioButtonRemote.Size = new System.Drawing.Size(90, 20);
            this.radioButtonRemote.TabIndex = 19;
            this.radioButtonRemote.TabStop = true;
            this.radioButtonRemote.Text = "远程在线";
            this.radioButtonRemote.UseVisualStyleBackColor = true;
            this.radioButtonRemote.CheckedChanged += new System.EventHandler(this.radioButtonControl_CheckedChanged);
            // 
            // radioButtonLocal
            // 
            this.radioButtonLocal.AutoSize = true;
            this.radioButtonLocal.Location = new System.Drawing.Point(803, 41);
            this.radioButtonLocal.Name = "radioButtonLocal";
            this.radioButtonLocal.Size = new System.Drawing.Size(90, 20);
            this.radioButtonLocal.TabIndex = 18;
            this.radioButtonLocal.Text = "本地在线";
            this.radioButtonLocal.UseVisualStyleBackColor = true;
            this.radioButtonLocal.CheckedChanged += new System.EventHandler(this.radioButtonControl_CheckedChanged);
            // 
            // radioButtonOffline
            // 
            this.radioButtonOffline.AutoSize = true;
            this.radioButtonOffline.Location = new System.Drawing.Point(669, 41);
            this.radioButtonOffline.Name = "radioButtonOffline";
            this.radioButtonOffline.Size = new System.Drawing.Size(58, 20);
            this.radioButtonOffline.TabIndex = 17;
            this.radioButtonOffline.Text = "离线";
            this.radioButtonOffline.UseVisualStyleBackColor = true;
            this.radioButtonOffline.CheckedChanged += new System.EventHandler(this.radioButtonControl_CheckedChanged);
            // 
            // 变量
            // 
            this.变量.Controls.Add(this.buttonVarSet);
            this.变量.Controls.Add(this.textBoxVarValue);
            this.变量.Controls.Add(this.label4);
            this.变量.Controls.Add(this.textBoxVarName);
            this.变量.Controls.Add(this.label3);
            this.变量.Location = new System.Drawing.Point(5, 196);
            this.变量.Name = "变量";
            this.变量.Size = new System.Drawing.Size(331, 220);
            this.变量.TabIndex = 18;
            this.变量.TabStop = false;
            this.变量.Text = "变量";
            // 
            // buttonVarSet
            // 
            this.buttonVarSet.Location = new System.Drawing.Point(128, 124);
            this.buttonVarSet.Name = "buttonVarSet";
            this.buttonVarSet.Size = new System.Drawing.Size(115, 35);
            this.buttonVarSet.TabIndex = 23;
            this.buttonVarSet.Text = "设置";
            this.buttonVarSet.UseVisualStyleBackColor = true;
            this.buttonVarSet.Click += new System.EventHandler(this.buttonVarSet_Click);
            // 
            // textBoxVarValue
            // 
            this.textBoxVarValue.Location = new System.Drawing.Point(87, 72);
            this.textBoxVarValue.Name = "textBoxVarValue";
            this.textBoxVarValue.Size = new System.Drawing.Size(156, 26);
            this.textBoxVarValue.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "变量值";
            // 
            // textBoxVarName
            // 
            this.textBoxVarName.Location = new System.Drawing.Point(87, 40);
            this.textBoxVarName.Name = "textBoxVarName";
            this.textBoxVarName.Size = new System.Drawing.Size(156, 26);
            this.textBoxVarName.TabIndex = 19;
            this.textBoxVarName.Text = "10000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "变量ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEventSend);
            this.groupBox2.Controls.Add(this.textBoxEventID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(401, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 220);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "事件";
            // 
            // buttonEventSend
            // 
            this.buttonEventSend.Location = new System.Drawing.Point(128, 124);
            this.buttonEventSend.Name = "buttonEventSend";
            this.buttonEventSend.Size = new System.Drawing.Size(115, 35);
            this.buttonEventSend.TabIndex = 23;
            this.buttonEventSend.Text = "设置";
            this.buttonEventSend.UseVisualStyleBackColor = true;
            this.buttonEventSend.Click += new System.EventHandler(this.buttonEventSend_Click);
            // 
            // textBoxEventID
            // 
            this.textBoxEventID.Location = new System.Drawing.Point(87, 40);
            this.textBoxEventID.Name = "textBoxEventID";
            this.textBoxEventID.Size = new System.Drawing.Size(156, 26);
            this.textBoxEventID.TabIndex = 19;
            this.textBoxEventID.Text = "20000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "事件ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonAlarmSet);
            this.groupBox4.Controls.Add(this.buttonAlarmClear);
            this.groupBox4.Controls.Add(this.textBoxAlarmID);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(783, 196);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 220);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "警报";
            // 
            // buttonAlarmSet
            // 
            this.buttonAlarmSet.Location = new System.Drawing.Point(28, 124);
            this.buttonAlarmSet.Name = "buttonAlarmSet";
            this.buttonAlarmSet.Size = new System.Drawing.Size(115, 35);
            this.buttonAlarmSet.TabIndex = 24;
            this.buttonAlarmSet.Text = "设置";
            this.buttonAlarmSet.UseVisualStyleBackColor = true;
            this.buttonAlarmSet.Click += new System.EventHandler(this.buttonAlarmSet_Click);
            // 
            // buttonAlarmClear
            // 
            this.buttonAlarmClear.Location = new System.Drawing.Point(172, 124);
            this.buttonAlarmClear.Name = "buttonAlarmClear";
            this.buttonAlarmClear.Size = new System.Drawing.Size(115, 35);
            this.buttonAlarmClear.TabIndex = 23;
            this.buttonAlarmClear.Text = "清除";
            this.buttonAlarmClear.UseVisualStyleBackColor = true;
            this.buttonAlarmClear.Click += new System.EventHandler(this.buttonAlarmClear_Click);
            // 
            // textBoxAlarmID
            // 
            this.textBoxAlarmID.Location = new System.Drawing.Point(87, 40);
            this.textBoxAlarmID.Name = "textBoxAlarmID";
            this.textBoxAlarmID.Size = new System.Drawing.Size(156, 26);
            this.textBoxAlarmID.TabIndex = 19;
            this.textBoxAlarmID.Text = "30000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "警报ID";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listViewParam);
            this.groupBox5.Controls.Add(this.textBoxRemoteCmd);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(5, 435);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(331, 220);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "远程控制";
            // 
            // listViewParam
            // 
            this.listViewParam.GridLines = true;
            this.listViewParam.Location = new System.Drawing.Point(28, 83);
            this.listViewParam.Name = "listViewParam";
            this.listViewParam.Size = new System.Drawing.Size(267, 120);
            this.listViewParam.TabIndex = 21;
            this.listViewParam.UseCompatibleStateImageBehavior = false;
            this.listViewParam.View = System.Windows.Forms.View.Details;
            // 
            // textBoxRemoteCmd
            // 
            this.textBoxRemoteCmd.Location = new System.Drawing.Point(87, 40);
            this.textBoxRemoteCmd.Name = "textBoxRemoteCmd";
            this.textBoxRemoteCmd.Size = new System.Drawing.Size(156, 26);
            this.textBoxRemoteCmd.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "命令";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(977, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 35);
            this.button2.TabIndex = 26;
            this.button2.Text = "SECS参数界面";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SecsAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 688);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.变量);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SecsAppView";
            this.Text = "SecsAppView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecsAppView_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.变量.ResumeLayout(false);
            this.变量.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCommState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelControlState;
        private System.Windows.Forms.CheckBox checkBoxEnableComm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonOffline;
        private System.Windows.Forms.RadioButton radioButtonRemote;
        private System.Windows.Forms.RadioButton radioButtonLocal;
        private System.Windows.Forms.GroupBox 变量;
        private System.Windows.Forms.TextBox textBoxVarValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVarName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonVarSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEventSend;
        private System.Windows.Forms.TextBox textBoxEventID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonAlarmClear;
        private System.Windows.Forms.TextBox textBoxAlarmID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAlarmSet;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxRemoteCmd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewParam;
        private System.Windows.Forms.Button button2;
    }
}