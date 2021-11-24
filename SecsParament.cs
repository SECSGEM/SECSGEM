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
    public partial class CSecsParament : Form
    {
        public CSecsEquip m_pSecs = null;


        public CSecsParament()
        {
            InitializeComponent();
            InitData();
        }

        // 初始化
        void InitData()
        {            
            textBoxMDLN.Text = "JNG";
            textBoxDeviceID.Text = "0";

            textBoxIP.Text = "127.0.0.1";
            textBoxPort.Text = "5555";
            checkBoxPassive.Checked = true;
            checkBoxEnableLog.Checked = false;
          
            
            textBoxT1.Text = "10000";
            textBoxT2.Text = "10000";
            textBoxT3.Text = "45000";
            textBoxT4.Text = "10000";
            textBoxT5.Text = "10000";
            textBoxT6.Text = "5000";
            textBoxT7.Text = "10000";
        }


        private void buttonSet_Click(object sender, EventArgs e)
        {
            
            m_pSecs.SetIP(textBoxIP.Text);

            int nTmp = StringToNum.atoi(textBoxPort.Text.ToString());
            m_pSecs.SetPort(nTmp);

            m_pSecs.SetMDLN(textBoxMDLN.Text);

            nTmp = StringToNum.atoi(textBoxDeviceID.Text.ToString());
            m_pSecs.SetDeviceID(nTmp);

            m_pSecs.SetPassive(checkBoxPassive.Checked);
                        
            nTmp = StringToNum.atoi(textBoxT1.Text.ToString());
            m_pSecs.SetT1(nTmp);

            nTmp = StringToNum.atoi(textBoxT2.Text.ToString());
            m_pSecs.SetT2(nTmp);

            nTmp = StringToNum.atoi(textBoxT3.Text.ToString());
            m_pSecs.SetT3(nTmp);

            nTmp = StringToNum.atoi(textBoxT4.Text.ToString());
            m_pSecs.SetT4(nTmp);

            nTmp = StringToNum.atoi(textBoxT5.Text.ToString());
            m_pSecs.SetT5(nTmp);

            nTmp = StringToNum.atoi(textBoxT6.Text.ToString());
            m_pSecs.SetT6(nTmp);

            nTmp = StringToNum.atoi(textBoxT7.Text.ToString());
            m_pSecs.SetT7(nTmp);


            // checkBoxComunication, comboBoxControl 这俩个开软件时候设置
        }
    }
}
