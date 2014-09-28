namespace System.Threading
{
    /// <summary>
    /// ThreadEx
    /// </summary>
    public static class ThreadEx
    {
        /// <summary>
        /// Yield
        /// </summary>
        /// <returns></returns>
        public static bool Yield()
        {
            Thread.Sleep(0);
            return true;
        }
    }
}
