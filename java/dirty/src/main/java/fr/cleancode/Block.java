package fr.cleancode;

import org.apache.commons.codec.digest.DigestUtils;

class Block {
    public String hash;
    public String data;
    public String parentHash;

    //This constructor create a block with a parentHash and some data
    Block(String parentHash, String data) {
        this.data = data;
        this.hash = parentHash == null ? DigestUtils.sha256Hex(data) : DigestUtils.sha256Hex(parentHash + data);
        this.parentHash = parentHash == null ? hash : parentHash;
    }
}
