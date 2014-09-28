
namespace System
{
    /// <summary>
    /// EnvironmentEx
    /// </summary>
    public static class EnvironmentEx
    {
        /// <summary>
        /// 
        /// </summary>
        public static bool Is64BitProcess
        {
            get { return IntPtr.Size == 8; }
        }
    }
}
