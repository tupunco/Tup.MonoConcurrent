#if NET_4_0
// ParallelConcurrentStackTests.cs
//
// Copyright (c) 2008 Jérémie "Garuma" Laval
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonoTests.System.Threading.Tasks;
using System.Collections.Concurrent;

namespace MonoTests.System.Collections.Concurrent
{

    [TestClass]
    public class ParallelConcurrentStackTests
    {
        ConcurrentStack<int> stack;

        [TestInitialize()]
        public void Setup()
        {
            stack = new ConcurrentStack<int>();
        }

        [TestMethod]
        public void CountTestCase()
        {
            const int numThread = 5;
            ParallelTestHelper.ParallelAdder(stack, numThread);
            Assert.AreEqual(10 * numThread, stack.Count, "#1");
            int value;
            stack.TryPeek(out value);
            ParallelTestHelper.ParallelRemover(stack, numThread, 3);
            Assert.AreEqual(10 * numThread - 3, stack.Count, "#2");
            stack.Clear();
            Assert.AreEqual(0, stack.Count, "#3");
            Assert.IsTrue(stack.IsEmpty, "#4");
        }
    }
}
#endif
