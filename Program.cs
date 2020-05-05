using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LOLFlashRecorder
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitProgram();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void InitProgram()
        {
            //检查dm.dll是否存在，如果不存在就添加
            if (!IsRegeditItemExist())
            {
                Process p = new Process();
                p.StartInfo.FileName = "Regsvr32.exe";
                p.StartInfo.Arguments = @"/s dm.dll";
                p.Start();
                if (!IsRegeditItemExist())
                {
                    DialogResult dr = MessageBox.Show("程序安装dm.dll出错，请检查是否存在此文件！\n是否重新尝试？", "警告", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Retry)
                    {
                        InitProgram();
                    }
                    else
                    {
                        Environment.Exit(-1);
                    }
                }
            }
        }

        private static bool IsRegeditItemExist()
        {
            string[] subkeyNames;
            RegistryKey key = Registry.ClassesRoot;
            RegistryKey software = key.OpenSubKey("WOW6432Node").OpenSubKey("CLSID");
            subkeyNames = software.GetSubKeyNames();
            foreach (string keyName in subkeyNames)
            {
                if (keyName == @"{26037A0E-7CBD-4FFF-9C63-56F2D0770214}")
                {
                    key.Close();
                    return true;
                }
            }
            key.Close();
            return false;
        }
    }
}
