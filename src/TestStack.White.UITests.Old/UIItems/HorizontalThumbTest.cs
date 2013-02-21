using NUnit.Framework;
using White.Core.UIItems;
using White.Core.UITests.Testing;

namespace White.Core.UITests.UIItems
{
    [TestFixture, WPFCategory]
    public class HorizontalThumbTest : ControlsActionTest
    {
        protected override string CommandLineArguments
        {
            get { return HorizontalGridSplitter; }
        }

        [Test]
        public void Find()
        {
            var thumb = Window.Get<Thumb>("splitter");
            Assert.AreNotEqual(null, thumb);
        }

        [Test]
        public void Slide()
        {
            var thumb = Window.Get<Thumb>("splitter");
            double originalX = thumb.Location.X;
            thumb.SlideHorizontally(50);
            Assert.AreEqual(originalX + 50, thumb.Location.X);
        }
    }
}