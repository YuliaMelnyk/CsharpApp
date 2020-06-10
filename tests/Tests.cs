using NUnit.Framework;

namespace csharp.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CanBeCancelledByTest()
        {
            //Given
            var user = new User { isAdmin = true };

            //Then
            var subscribe = new Subscribe();
            var canBeCancelled = subscribe.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(canBeCancelled);
        }
    }
}