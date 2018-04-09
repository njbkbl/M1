const crypto = require("crypto");

class Block {
    //This constructor create a block with a parentHash and some data
    constructor(parentHash, data) {
        this.data = data;
        this.hash = Block.makePuzzle(
            this.parentHash,
            this.data
        );
        this.parentHash = parentHash === null ? this.hash : parentHash;
    }

    static makePuzzle(parentHash, data) {
        return crypto
            .createHash("sha256")
            .update(parentHash || "")
            .update(JSON.stringify(data) || "")
            .digest("hex");
    }
    
}

module.exports = Block;
