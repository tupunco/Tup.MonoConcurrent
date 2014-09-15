//
// System.OperationCanceledException.cs
//
// Authors:
//   Zoltan Varga  <vargaz@freemail.hu>
//   Jérémie Laval <jeremie.laval@gmail.com>
//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using System.Threading;

namespace System
{
    [Serializable]
    [ComVisible(true)]
    public class OperationCanceledException2 : OperationCanceledException
    {
        // 摘要: 
        //     使用系统提供的错误信息初始化 System.OperationCanceledException 类的新实例。
        public OperationCanceledException2() : base() { }
        //
        // 摘要: 
        //     用指定的错误信息初始化 System.OperationCanceledException 类的新实例。
        //
        // 参数: 
        //   message:
        //     描述该错误的 System.String。
        public OperationCanceledException2(string message) : base(message) { }
        //
        // 摘要: 
        //     用序列化数据初始化 System.OperationCanceledException 类的新实例。
        //
        // 参数: 
        //   info:
        //     保存序列化对象数据的对象。
        //
        //   context:
        //     有关源或目标的上下文信息。
        protected OperationCanceledException2(SerializationInfo info, StreamingContext context) : base(info, context) { }
        //
        // 摘要: 
        //     使用指定错误信息和对作为此异常原因的内部异常的引用来初始化 System.OperationCanceledException 类的新实例。
        //
        // 参数: 
        //   message:
        //     解释异常原因的错误信息。
        //
        //   innerException:
        //     导致当前异常的异常。如果 innerException 参数不为null，则当前异常在处理内部异常的 catch 块中引发。
        public OperationCanceledException2(string message, Exception innerException) : base(message, innerException) { }


#if NET_4_0
        CancellationToken? token;
#endif


#if NET_4_0
        public OperationCanceledException2(CancellationToken token)
            : base()
        {
            this.token = token;
        }

        public CancellationToken CancellationToken
        {
            get
            {
                if (token == null)
                    return CancellationToken.None;
                return token.Value;
            }
        }
#endif
    }
}
