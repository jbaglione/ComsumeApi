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
            Assert.IsTrue(sm.ConfirmOrder(new Order()));
        }

        [TestMethod]
        public void CompleteOrder()
        {
            Assert.IsTrue(sm.CompleteOrder(new CompleteOrder()));
        }

        [TestMethod]
        public void OrderMobileAssigned()
        {
            Assert.IsTrue(sm.OrderMobileAssigned(new OrderMobileAssigned()));
        }

        [TestMethod]
        public void PushText()
        {
            Assert.IsTrue(sm.ConfirmOrder(new Order()));
        }

    }
}
