using BlendAnimationsVisualStateBinding2;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MainViewModelTests
    {
        [TestCase(CardinalPoint.North)]
        [TestCase(CardinalPoint.East)]
        [TestCase(CardinalPoint.South)]
        [TestCase(CardinalPoint.West)]
        public void CardinalPointIsUpdatedWhenCommandIsInvokedWith(CardinalPoint cardinalPoint)
        {
            var viewModel = new MainViewModel();

            viewModel.SwitchCommand.Execute(cardinalPoint);

            Assert.That(viewModel.CardinalPoint, Is.EqualTo(cardinalPoint));
        }
    }
}
