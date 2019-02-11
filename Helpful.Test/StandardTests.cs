using NUnit.Framework;

namespace Helpful.Test
{
    [TestFixture]
    public class StandardTests
    {

        [Test]
        public void StraightDiagonalWin()
        {
            var arr = new string[3,3]{
                { "x"," "," " },
                { " ","x"," "},
                { " "," ","x"}
            };

            Assert.IsTrue(Standart.Win(arr, "x"));
        }

        [Test]
        public void OppositeDiagonalWin()
        {
            var arr = new string[3, 3]{
                { " "," ","x" },
                { " ","x"," "},
                { "x"," "," "}
            };

            Assert.IsTrue(Standart.Win(arr, "x"));
        }

        [Test]
        public void HorizontalWin()
        {
            var arr = new string[3, 3]{
                { "x","x","x" },
                { " "," "," "},
                { " "," ",""}
            };

            Assert.IsTrue(Standart.Win(arr, "x"));
        }


        [Test]
        public void VerticalWin()
        {
            var arr = new string[3, 3]{
                { "x"," "," " },
                { "x"," "," "},
                { "x"," "," "}
            };

            Assert.IsTrue(Standart.Win(arr, "x"));
        }

        [Test]
        public void WithoutWin()
        {
            var arr = new string[3, 3]{
                { "x","0","0" },
                { "0","0","x"},
                { "x"," ","x"}
            };

            Assert.IsFalse(Standart.Win(arr, "x"));
        }

        [Test]
        public void WithoutWinAndFull()
        {
            var arr = new string[3, 3]{
                { "x","0","0" },
                { "0","0","x"},
                { "x","x","0"}
            };

            Assert.IsFalse(Standart.Win(arr, "x"));
        }


        [Test]
        public void EmptyNotWin()
        {
            var arr = new string[3, 3]{
                { " "," "," " },
                { " "," "," "},
                { " "," "," "}
            };

            Assert.IsFalse(Standart.Win(arr, "x"));
        }
    }
}
