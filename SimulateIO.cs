using System;
using System.Runtime.InteropServices;


namespace QuickTimeEnter
{
    //底层I/O信号模拟器
    class SimulateIO
    {
        public const int KBC_KEY_CMD = 0x64;
        public const int KBC_KEY_DATA = 0x60;

        [DllImport("winio.dll")]
        public static extern bool InitializeWinIo();

        [DllImport("winio.dll")]
        public static extern bool GetPortVal(IntPtr wPortAddr, out int pdwPortVal, byte bSize);

        [DllImport("winio.dll")]
        public static extern bool SetPortVal(uint wPortAddr, IntPtr dwPortVal, byte bSize);

        [DllImport("winio.dll")]
        public static extern byte MapPhysToLin(byte pbPhysAddr, uint dwPhysSize, IntPtr PhysicalMemoryHandle);

        [DllImport("winio.dll")]
        public static extern bool UnmapPhysicalMemory(IntPtr PhysicalMemoryHandle, byte pbLinAddr);

        [DllImport("winio.dll")]
        public static extern bool GetPhysLong(IntPtr pbPhysAddr, byte pdwPhysVal);

        [DllImport("winio.dll")]
        public static extern bool SetPhysLong(IntPtr pbPhysAddr, byte dwPhysVal);

        [DllImport("winio.dll")]
        public static extern void ShutdownWinIo();

        [DllImport("user32.dll")]
        public static extern int MapVirtualKey(uint Ucode, uint uMapType);

        public static void sendwinio()
        {
            if (InitializeWinIo())
            {
                KBCWait4IBE();
            }
        }

        ///Wait for Buffer gets empty
        private static void KBCWait4IBE()
        {
            int dwVal = 0;
            do
            {
                bool flag = GetPortVal((IntPtr)0x64, out dwVal, 1);
            }
            while ((dwVal & 0x2) > 0);
        }

        /// key down
        public static void MykeyDown(int vKeyCoad)
        {
            int btScancode = 0;
            btScancode = MapVirtualKey((byte)vKeyCoad, 0);
            KBCWait4IBE();
            SetPortVal(KBC_KEY_CMD, (IntPtr)0xD2, 1);
            KBCWait4IBE();
            SetPortVal(KBC_KEY_DATA, (IntPtr)0xe2, 1);
            KBCWait4IBE();
            SetPortVal(KBC_KEY_CMD, (IntPtr)0xD2, 1);
            KBCWait4IBE();
            SetPortVal(KBC_KEY_DATA, (IntPtr)btScancode, 1);
        }

        /// Key up
        public static void MykeyUp(int vKeyCoad)
        {
            int btScancode = 0;
            btScancode = MapVirtualKey((byte)vKeyCoad, 0);
            KBCWait4IBE();
            SetPortVal(KBC_KEY_CMD, (IntPtr)0xD2, 1);
            KBCWait4IBE();
            SetPortVal(KBC_KEY_DATA, (IntPtr)0xe0, 1);
            KBCWait4IBE();
            SetPortVal(KBC_KEY_CMD, (IntPtr)0xD2, 1);
            KBCWait4IBE();
            SetPortVal(KBC_KEY_DATA, (IntPtr)btScancode, 1);
        }

        /// Simulate mouse down
        public static void MyMouseDown(int vKeyCoad)
        {
            int btScancode = 0;
            btScancode = MapVirtualKey((byte)vKeyCoad, 0);
            KBCWait4IBE(); // 'wait for buffer gets empty
            SetPortVal(KBC_KEY_CMD, (IntPtr)0xD3, 1);// 'send write command
            KBCWait4IBE();
            SetPortVal(KBC_KEY_DATA, (IntPtr)(btScancode | 0x80), 1);// 'write in io
        }

        /// Simulate mouse up
        public static void MyMouseUp(int vKeyCoad)
        {
            int btScancode = 0;
            btScancode = MapVirtualKey((byte)vKeyCoad, 0);
            KBCWait4IBE(); // 'wait for buffer gets empty
            SetPortVal(KBC_KEY_CMD, (IntPtr)0xD3, 1); //'send write command
            KBCWait4IBE();
            SetPortVal(KBC_KEY_DATA, (IntPtr)(btScancode | 0x80), 1);// 'write in io
        }
    }
}
