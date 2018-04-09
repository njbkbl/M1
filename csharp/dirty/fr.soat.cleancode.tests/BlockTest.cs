using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fr.soat.cleancode.tests
{
    [TestClass]
    public class BlockTest
    
    {
        [TestMethod]
        public void TestInitialBlock()
        {
            Block block = new Block(null, "Le 09 Avril, cet exercice a été donné à Paris au meetup SOAT");
            Assert.AreEqual(block.parentHash, block.hash);
        }

        [TestMethod]
        public void TestConstructorHash()
        {
            Block block = new Block("e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855", "some data");
            Assert.AreEqual("0ef8fab0033cad2de4433e608c4d5d133c176757999044b89a7c9c0e3a298ec9", block.hash);
        }
    }
}
