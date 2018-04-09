package fr.cleancode;

import java.util.HashMap;

class BlockChain {

    HashMap<String,Block> blocks = new HashMap<>();

    BlockChain() {
        Block initialBlock = new Block(null, "Le 09 Avril, cet exercice a été donné à Paris au meetup SOAT");
        blocks.put(initialBlock.hash, initialBlock);
    }


    boolean addBlock(Block newBlock) {
        if (!checkHashValidity(newBlock)) {
            return false;
        }
        blocks.put(newBlock.hash, newBlock);
        cleanBlockChain();
        return true;
    }

    boolean checkHashValidity(Block newBlock) {

        if (newBlock.hash.equals(newBlock.parentHash))
            return false;
            else {
                //TODO 1
            }
        return true;
    }

    Block getLastBlock() {
        //TODO 2
        return null;
    }

    void cleanBlockChain() {
        //TODO 3
    }

}
