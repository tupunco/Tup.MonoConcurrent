
namespace System
{
    static class Environment2
    {
        public static bool Is64BitProcess
        {
            get { return IntPtr.Size == 8; }
        }
    }
}
