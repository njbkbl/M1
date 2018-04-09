const { expect } = require("chai");
const Block = require("../src/Block");


describe("Block", function() {
    describe("constructor", function() {
        it("should set itself as parent hash for initial block", function(done){
            const block = new Block(null, "Le 09 Avril, cet exercice a été donné à Paris au meetup SOAT" );
            expect(block.hash).equals(block.parentHash);
            done();
        });

        it("should set the correct hash", function(done) {
            const block = new Block(
                "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
                "some data"
            );

            expect(block).to.have.property(
                "hash",
                "0a52faa80f12c8ae75e0fe1fe5c5916618b8783d233f44a6259f44067a12244c"
            );
            done();
        });
    });
});
