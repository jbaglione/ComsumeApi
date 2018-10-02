using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonRequest.Methods;

namespace JsonReques.Test
{
    [TestClass]
    public class UnitTest1
    {
        SendMethods sm = new SendMethods();
        [TestMethod]
        public void ConfirmOrder()
        {
            Assert.IsTrue(sm.ConfirmOrder());
        }

        [TestMethod]
        public void CompleteOrder()
        {
            Assert.IsTrue(sm.CompleteOrder());
        }

        [TestMethod]
        public void OrderMobileAssigned()
        {
            Assert.IsTrue(sm.OrderMobileAssigned());
        }

        [TestMethod]
        public void PushText()
        {
            Assert.IsTrue(sm.ConfirmOrder());
        }

    }
}
