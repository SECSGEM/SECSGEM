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
    public partial class SecsApp : Form
    {
        static public CSecsEquip m_pSecs = new CSecsEquip();

        public SecsApp()
        {
            InitializeComponent();

            InitSecs("127.0.0.1", 5555, true, 0);
        }


        // SECS
        void InitSecs(string IP, long nPort, bool bPassive, int nDeviceID)
        {
            RcResult rc = m_pSecs.start();
            MessageBox.Show("开始连接：错误" + rc.ToString());

            m_pSecs.SetIP(IP);
            m_pSecs.SetPort((int)nPort);
            m_pSecs.SetPassive(bPassive);
            m_pSecs.SetDeviceID(nDeviceID);
            m_pSecs.LoadDataByCsvFile();
                        
            m_pSecs.SetControlMode(CONTROL_MODE.eCONTROL_MODE_OFFLINE);           
        }

    }
}
