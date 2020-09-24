using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using CSRegexStringLayer;
using CSProcessLayer;

namespace Editor
{
    public partial class Start : Form
    {
        StringBuilder szDevice;

        public Start(ref StringBuilder szDeviceTmp)
        {
            szDevice = szDeviceTmp;
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            timer.Start();
            lab_Tip.Text = "正在检查NFC库文件 ...";
            lab_Ret.Text = "";
        }

        int TimerCount = 0;
        bool bOk = true;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!bOk)
            {
                timer.Dispose();
                Thread.Sleep(3000);
                System.Environment.Exit(0);
            }

            string szRet = "";

            TimerCount++;
            switch (TimerCount)
            {
                case 1:
                    timer.Stop();
                    bOk = Set_LabelRet(Chk_Component(ref szRet), szRet);
                    timer.Start();
                    break;
                case 2:
                    lab_Tip.Text = "检查 RFID 设备...";
                     lab_Ret.Text = "";
                    break;
                case 3:
                    timer.Stop();
                    bOk = Set_LabelRet(Chk_Device(ref szRet), szRet);
                    timer.Start();
                    break;
                
                case 4:
                    break;
                case 5:
                    timer.Dispose();
                    this.Close();
                    break;
            }
        }

        private bool Set_LabelRet(bool bStatus, string szRet)
        {
            if (bStatus)
            {
                lab_Ret.ForeColor = Color.Green;
                lab_Ret.Text = szRet;

            }
            else
            {
                lab_Ret.ForeColor = Color.Red;
                lab_Ret.Text = szRet;
            }
            return bStatus;
        }

        private bool Chk_Component(ref string szRet)
        {
            string[] szFileList = new string[]
            {
                "nfc/libnfc.dll",
                "nfc/libusb0.dll",
                "nfc/nfc-list.exe",
                "nfc/nfc-mfsetuid.exe",
                "nfc/nfc-mfclassic.exe",
                "nfc/mfoc.exe",
            }; 

            foreach (string szFileItem in szFileList)
            {
                if (!File.Exists(szFileItem))
                {
                    szRet = "错误！文件：" + szFileItem + " 不存在";
                    return false;
                }
            }
            szRet = "OK!";
            return true;
        }

        private bool Chk_Device(ref string szRet)
        {
            ProcessLayer pl = new ProcessLayer();
            bool bSuccess = pl.SyncStart("nfc/nfc-list.exe", null);

            if (!bSuccess)
            {
                szRet = "错误！无法连接到设备";
                return false;
            }
            string[] RegexRet = RegexStringLayer.GetSubString(pl.m_RetOutputMsg.ToString(), "NFC device:\\s*(.+)\\s*/");

            bool bRet;
            if (string.IsNullOrWhiteSpace(RegexRet[0]))
            {
                bRet = false;
                szRet = "错误！无法连接到设备";
            }
            else
            {
                bRet = true;
                szRet = RegexRet[0];
                szDevice.Append(RegexRet[0]);
            }

            return bRet;
        }
    }
}
