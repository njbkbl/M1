const { expect } = require("chai");
const BlockChain = require("../src/BlockChain");
const Block = require("../src/Block");


describe("BlockChain", function() {
    let blockChain;

    function add(parentHash, data) {
        const block = new Block(parentHash, data);
        blockChain.addBlock(block);
        return block;
    }

    beforeEach("Create block chain", function(done) {
        blockChain = new BlockChain();
        done();
    });

    describe("constructor", function() {
        it("should create an initial block", function(done) {
            expect(blockChain)
                .to.have.property("blocks")
                .that.has.property(
                    "fd420aa028afe463619d97ac2316e693cef2bac5e1684cc46573ef3f894b1cb3"
                );
            done();
        });
    });

    describe("#addBlock", function() {
        it("should not add a root block", function(done) {
            let rootBlock = new Block(null, "2nd root block");
            let added = blockChain.addBlock(rootBlock);

            expect(added).to.be.false;
            done();
        });

        it("should add a new block", function(done) {
            //TODO
            expect.fail();
            done();
        });

        it("should not add a new block if the parent is not in the block chain", function(done) {
            //TODO
            expect.fail();
            done();
        });
    });

    
    describe("#getLastBlock", function() {
        it("should return the root block", function(done) {
            const last = blockChain.getLastBlock();
            const root = blockChain.blocks["fd420aa028afe463619d97ac2316e693cef2bac5e1684cc46573ef3f894b1cb3"];
            expect(last).equals(root);
            done();
        });
    });

    /*
     * Given this block chain:
     * a--b--c--d--e--f--g
     *     \-h--i
     * After adding a new block 'j' we should get:
     * a--b--c--d--e--f--g--j
     */
    describe("#clean", function() {
        it("should clean the blockchain", function(done) {
            const last = blockChain.getLastBlock();
            const a = add(last.hash, "a");
            const b = add(a.hash, "b");
            const c = add(b.hash, "c");
            const d = add(c.hash, "d");
            const e = add(d.hash, "e");
            const f = add(e.hash, "f");
            const g = add(f.hash, "g");
            const h = add(b.hash, "h");
            const i = add(h.hash, "i");

            const j = add(g.hash, "j");

            expect(blockChain.blocks[h.hash]).to.not.exist;
            expect(blockChain.blocks[i.hash]).to.not.exist;
            expect(blockChain.blocks[j.hash]).to.exist;
            done();
        });
    });
});
