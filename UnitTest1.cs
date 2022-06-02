using Xunit;
using UnitTestingHandsOn;
using System;

namespace MyTestProject
{
    public class UnitTest1
    {
       
        [Fact]
        public void TestAdd()
        {
            MyOperation operation = new MyOperation();
            var a = 10;
            var b = 20;
            var c = MyOperation.Add(a, b);
            Assert.Equal(30, c);
        }

        [Fact]
        public void TestSub()
        {
            MyOperation operation = new MyOperation();
            var a = 30;
            var b = 20;
            var c = MyOperation.Sub(a, b);
            Assert.Equal(10, c);
        }
        [Fact]
        public void TestDivision()
        {
            MyOperation operation = new MyOperation();
            var a = 30;
            var b = 15;
            var c = MyOperation.Division(a, b);
            Assert.Equal(2, c);
        }
        [Fact]
        public void TestMul()
        {
            MyOperation operation = new MyOperation();
            var a = 10;
            var b = 5;
            var c = MyOperation.Mul(a, b);
            Assert.Equal(50, c);
        }
    }
}