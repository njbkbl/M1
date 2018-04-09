using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fr.soat.cleancode.tests
{
    [TestClass]
    public class BlockChainTest
    {

        private BlockChain blockChain;

        private Block Add(string parentHash, string data)
        {
            var block = new Block(parentHash, data);
            blockChain.AddBlock(block);
            return block;
        }

        [TestInitialize]
        public void CreateBlockChain()
        {
            blockChain = new BlockChain();

        }

        [TestMethod]
        public void TestInitialBlock()
        {
            CollectionAssert.Contains(blockChain.blocks.Keys, "733ad20af52ec1902f51e97b99444754df7db2bf91bb26e076723c5e9fc12bc1");
        }


        [TestMethod]
        public void TestAddRootBlock()
        {
            var rootBlock = new Block(null, "2nd root block");
            var added = blockChain.AddBlock(rootBlock);

            Assert.IsFalse(added);
        }



        [TestMethod]
        public void TestAddBlock()
        {
            // nominal case for addBlock
            //TODO
            Assert.Fail();
        }


        [TestMethod]
        public void TestAddBlockWrongParent()
        {
            // adding a block with a parent not in the block chain
            //TODO
            Assert.Fail();
        }


        [TestMethod]
        public void TestGetLastBlock()
        {
            var rootBlock = blockChain.blocks["733ad20af52ec1902f51e97b99444754df7db2bf91bb26e076723c5e9fc12bc1"];
            var lastBlock = blockChain.GetLastBlock();

            Assert.AreSame(lastBlock, rootBlock); 
        }
        

        // Given this block chain:
        // a--b--c--d--e--f--g
        //     \-h--i
        // After adding a new block 'j' we should get:
        // a--b--c--d--e--f--g--j
        [TestMethod]
        public void TestCleanBlockChain()
        {
            var last = blockChain.GetLastBlock();
            var a = Add(last.hash, "a");
            var b = Add(a.hash, "b");
            var c = Add(b.hash, "c");
            var d = Add(c.hash, "d");
            var e = Add(d.hash, "e");
            var f = Add(e.hash, "f");
            var g = Add(f.hash, "g");
            var h = Add(b.hash, "h");
            var i = Add(h.hash, "i");

            var j = Add(g.hash, "j");

            CollectionAssert.DoesNotContain(blockChain.blocks.Keys, h.hash);
            CollectionAssert.DoesNotContain(blockChain.blocks.Keys, i.hash);
            CollectionAssert.Contains(blockChain.blocks.Keys, j.hash);
        }
    }
}
