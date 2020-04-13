using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuickTimeEnter
{
    //底层I/O信号模拟器
    class SimulateIO
    {
        public static void Test(Label l)
        {
            Dm.dmsoft dm = new Dm.dmsoft();
            dm.KeyPressChar("a");
            dm.KeyPressChar("b");
            dm.KeyPressChar("b");
        }
    }
}
