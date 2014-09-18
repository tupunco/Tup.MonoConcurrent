
namespace System
{
    /// <summary>
    /// MonoTODO Attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class MonoTODOAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MonoTODOAttribute() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public MonoTODOAttribute(string msg)
        {
            this.Message = msg;
        }
    }
}
