using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SecsEquip;

namespace EquipViewAppNet
{
    public partial class Terminal : Form
    {
        public CSecsEquip m_pSecs = null;


        public Terminal()
        {
            InitializeComponent();
        }


        public void ShowText(string pText)
        {
            labelText.Text = pText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_pSecs != null)
            {
                // 确认终端消息
                m_pSecs.EventPos(250); 
            }
            Close();
        }
    }
}
