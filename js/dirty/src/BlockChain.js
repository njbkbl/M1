const Block = require("./Block");

class BlockChain {
    constructor() {
        const head = new Block(null, "Le 09 Avril, cet exercice a été donné à Paris au meetup SOAT");
        this.blocks = {
            [head.hash]: head
        };
    }

    addBlock(block) {
        if (! this.checkHashValidity(block)) 
            return false;
            this.blocks[block.hash] = block;

        this.cleanBlockChain();

        return true;
    }

    checkHashValidity(block) {
        
        if (block.hash === block.parentHash) {
            return false;
        } else {
            //TODO 1
        }
        return false;
    }

    getLastBlock() {
        //TODO 2
        return null;
    }

    cleanBlockChain() {
        //TODO 3
    }

    
}

module.exports = BlockChain;
