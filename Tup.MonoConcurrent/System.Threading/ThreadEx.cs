namespace System.Threading
{
    /// <summary>
    /// 
    /// </summary>
    public static class ThreadEx
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool Yield()
        {
            Thread.Sleep(0);
            return true;
        }
    }
}
