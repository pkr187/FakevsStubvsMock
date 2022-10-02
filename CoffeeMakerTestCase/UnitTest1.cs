using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeMaker;
using Moq;


namespace CoffeeMakerTestCase
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Using Fake
        /// </summary>
        [TestMethod]
        public void OrderACoffee_Should_Return_Received_Message()
        {
            StarbuckStore store = new StarbuckStore(new FakeStarbucksStore());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is Received.", result);
        }
        /// <summary>
        /// Using Fake
        /// </summary>
        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingStub()
        {
            StarbuckStore store = new StarbuckStore(new StubStarbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is Received.", result);
        }
        /// <summary>
        /// Using Mock
        /// </summary>
        [TestMethod]
        public void OrderACoffee_Should_Return_Received_MessageUsingMock()
        {
            var service = new Mock<IMakeCoffee>();
            service.Setup(x => x.CheckIngridentAvalability()).Returns(true);
            service.Setup(x => x.CoffeeMaking(It.IsAny<int>(), It.IsAny<int>())).Returns("Your Order is Received.");
            var store = new StarbuckStore(service.Object);
            var result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is Received.", result);
        }
    }
}