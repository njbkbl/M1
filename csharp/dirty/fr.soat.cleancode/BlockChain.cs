using System.Collections.Generic;

namespace fr.soat.cleancode
{
   public class BlockChain
    {
       public Dictionary<string, Block> blocks = new Dictionary<string, Block>();


       public BlockChain()
        {
            Block initialBlock = new Block(null, "Le 09 Avril, cet exercice a été donné à Paris au meetup SOAT");
            blocks.Add(initialBlock.hash, initialBlock);
        }

        public bool AddBlock(Block newBlock)
        {
            if (!CheckHashValidity(newBlock))
            {
                return false;
            }
            blocks.Add(newBlock.hash, newBlock);
            CleanBlockChain();
            return true;
        }

        public bool CheckHashValidity(Block newBlock)
        {
            if (newBlock.hash.Equals(newBlock.parentHash))
                return false;
                else
                {
                    //TODO 1
                }
            return true;
        }

        public Block GetLastBlock()
        {
            //TODO 2
            return null;
        }

        public void CleanBlockChain()
        {
            //TODO 3
        }

    }
}
