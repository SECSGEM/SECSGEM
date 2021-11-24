using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SecsEquip;
using SecsBase;

namespace EquipViewAppNet
{
    public partial class SecsAppView : Form
    {
        public CSecsEquip m_pSecs = new CSecsEquip();

        OnRemoteCommandEventHandler m_remote = null;
        OnCommStateEventHandler m_commState = null;
        OnControlStateEventHandler m_controlState = null;
        CSecsParament m_pSecsParamView = null;
                        

        public SecsAppView()
        {
            InitializeComponent();

            m_remote = OnRemoteCommandEventShow;
            m_commState = OnCommStateEventShow;
            m_controlState = OnControlStateEventShow;
          
            InitView();            

            // SECS
            InitSecs("127.0.0.1", 5555, true, 0);
            
        }

        void InitView()
        {
            listViewParam.Columns.Add("名称", 100);
            listViewParam.Columns.Add("值", 100);
            listViewParam.View = View.Details;
            listViewParam.GridLines = true;

            labelCommState.Text = CSecsAssist.GetCommunicationText(COMM_STATE.eCOMM_ENABLED_NOT_COMMUNICATING);
            labelControlState.Text = CSecsAssist.GetControlText(CONTROL_STATE.eCONTROL_OFFLINE_EQUIPMENT);
        }


        // SECS
        void InitSecs(string IP, long nPort, bool bPassive, int nDeviceID)
        {
            RcResult rc = m_pSecs.start();
            if (rc.rc != 0)
            {
                MessageBox.Show("连接SECS错误:" + rc.ToString());
            }

            m_pSecs.SetIP(IP);
            m_pSecs.SetPort((int)nPort);
            m_pSecs.SetPassive(bPassive);
            m_pSecs.SetDeviceID(nDeviceID);
            m_pSecs.LoadDataByCsvFile();
                        
            m_pSecs.SetControlMode(CONTROL_MODE.eCONTROL_MODE_OFFLINE);
            
            // 回调、委托
            m_pSecs.m_pOnCommState = OnCommStateEventHandler;
            m_pSecs.m_pOnControlState = OnControlStateEventHandler;
            m_pSecs.m_pOnRemoteCommand = OnRemoteCommandEventHandler;          
           // m_pSecs.m_pOnClock 该函数已经内置设置

            m_pSecs.SetControlModeForce(CONTROL_MODE.eCONTROL_MODE_ONLINE_REMOTE);
            m_pSecs.CommEnable();

        }
         
        // 启用/禁用通讯
        private void checkBoxEnableComm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnableComm.Checked)
            {
                m_pSecs.CommEnable();
            }
            else
            {
                m_pSecs.CommDisable();
            }
        }

        // 在线模式控制
        private void radioButtonControl_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOffline.Checked)
            {
                m_pSecs.SetControlMode(CONTROL_MODE.eCONTROL_MODE_OFFLINE);
            }
            else if (radioButtonLocal.Checked)
            {
                m_pSecs.SetControlMode(CONTROL_MODE.eCONTROL_MODE_ONLINE_LOCAL);
            }
            else if (radioButtonRemote.Checked)
            {
                m_pSecs.SetControlMode(CONTROL_MODE.eCONTROL_MODE_ONLINE_REMOTE);
            }
        }

        // 设置值
        void buttonVarSet_Click(object sender, EventArgs e)
        {
            int nID = StringToNum.atoi(textBoxVarName.Text.ToString());
            string pValue = textBoxVarValue.Text;

            m_pSecs.VariableSet(nID, pValue);
        }

        // 事件发送
        void buttonEventSend_Click(object sender, EventArgs e)
        {
            int nID = StringToNum.atoi(textBoxEventID.Text.ToString());
       
            m_pSecs.EventPos(nID);
        }

        // 警报set
        void buttonAlarmSet_Click(object sender, EventArgs e)
        {
            int nID = StringToNum.atoi(textBoxAlarmID.Text.ToString());
            
            RcResult rc = m_pSecs.AlarmSet(nID, true);
        }

        // 警报clear
        void buttonAlarmClear_Click(object sender, EventArgs e)
        {
            int nID = StringToNum.atoi(textBoxAlarmID.Text.ToString());

            m_pSecs.AlarmSet(nID, false);
        }

          // 远程控制
        REMOTE_REPLY OnRemoteCommandEventHandler(object sender, RemoteCommandHandlerEventArgs e)
        {
            switch (e.pCMD)
            {
                case "START":
                    // 调用开始作业命令
                    // RunStart();
                    break;
                    
                case "PP-SELECT":
                    return HandlePPSelectExample(e);

                case "其他命令处理":
                    break;

                    // 命令不存在
                default:
                    return REMOTE_REPLY.eCOMMAND_NOT_EXIST;                      
            }
            
            RemoteCommandEventShow(sender, e);
            return REMOTE_REPLY.eCOMMAND_PERFORMED;                 
        }

        // PP-SLECT例子
        REMOTE_REPLY HandlePPSelectExample(RemoteCommandHandlerEventArgs e)
        {
            try
            {
                string pRecipeName = e.mapParament["Recipe"];   // 提取名称
                // 调用切换Recipe()函数
            }
            catch (System.Exception)
            {
                // 不存在Recipe存在，Host没有发送过来
                return REMOTE_REPLY.eCOMMAND_PARAMETER_IS_INVALID;
            }            

            return REMOTE_REPLY.eCOMMAND_PERFORMED;    
        }

        // 远程控制命令显示到软件，用于观察demo
        void RemoteCommandEventShow(object sender, RemoteCommandHandlerEventArgs e)
        {
            if (this.IsHandleCreated)
            {
                BeginInvoke(m_remote, sender, e);               
            }
        }

        // 远程控制命令显示
        REMOTE_REPLY OnRemoteCommandEventShow(object sender, RemoteCommandHandlerEventArgs e)
        {            
            textBoxRemoteCmd.Text = e.pCMD;         

            listViewParam.Items.Clear();
            foreach(string key in e.mapParament.Keys)            
            {
                try
                {
                    listViewParam.BeginUpdate();

                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = key.ToString();
                    lvi.SubItems.Add(e.mapParament[key]);
                    listViewParam.Items.Add(lvi);

                    listViewParam.EndUpdate();
                }
                catch 
                {
                	
                }                
            }
            return REMOTE_REPLY.eCOMMAND_REJECTED;
        }

    

        // 状态
        [Description("控制状态改变")]
        void OnCommStateEventHandler(object sender, CommStateEventArgs e)
        {
            BeginInvoke(m_commState, sender, e);
        }
        void OnCommStateEventShow(object sender, CommStateEventArgs e)
        {
            labelCommState.Text = CSecsAssist.GetCommunicationText(e.nState);
        }

        [Description("通讯状态改变")]
        void OnControlStateEventHandler(object sender, ControlStateEventArgs e)
        {
            BeginInvoke(m_controlState, sender, e);
        }
        void OnControlStateEventShow(object sender, ControlStateEventArgs e)
        {
            labelControlState.Text = CSecsAssist.GetControlText(e.nState);
        }

      
        // 参数界面
        private void button2_Click(object sender, EventArgs e)
        {            
            m_pSecsParamView = new CSecsParament();
            m_pSecsParamView.m_pSecs = m_pSecs;
            m_pSecsParamView.Show();
        }
               
              
      

        // 软件关闭，退出SECS
        private void SecsAppView_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_pSecs.Abort();
        }


    }
}
