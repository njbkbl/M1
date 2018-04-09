package fr.cleancode;

import static org.assertj.core.api.Assertions.assertThat;
import static org.assertj.core.api.Assertions.fail;

import org.junit.Before;
import org.junit.Test;

public class BlockChainTest {
    private BlockChain blockchain;

    private Block add(String parentHash, String data) {
        final Block block = new Block(parentHash, data);
        blockchain.addBlock(block);
        return block;
    }

    @Before
    public void createBlockChain() {
        blockchain = new BlockChain();
    }

    @Test
    public void testInitialBlock() {
        assertThat(blockchain.blocks.keySet())
                .contains("733ad20af52ec1902f51e97b99444754df7db2bf91bb26e076723c5e9fc12bc1");
    }

    @Test
    public void testAddRootBlock() {
        Block rootBlock = new Block(null, "2nd root block");
        boolean added = blockchain.addBlock(rootBlock);

        assertThat(added).isFalse();
    }

    @Test
    public void testAddBlock() {
        // nominal case for addBlock
        //TODO
        fail("TODO");
    }

    @Test
    public void testAddBlockWrongParent() {
        // adding a block with a parent not in the block chain
        //TODO
        fail("TODO");
    }

    @Test
    public void testGetLastBlock() {
        Block root = blockchain.blocks.get("733ad20af52ec1902f51e97b99444754df7db2bf91bb26e076723c5e9fc12bc1");
        Block last = blockchain.getLastBlock();

        assertThat(last).isSameAs(root);
    }

    /*
     * Given this block chain:
     * a--b--c--d--e--f--g
     *     \-h--i
     * After adding a new block 'j' we should get:
     * a--b--c--d--e--f--g--j
     */
    @Test
    public void testCleanBlockChain() {
        Block last = blockchain.getLastBlock();
        Block a = add(last.hash, "a");
        Block b = add(a.hash, "b");
        Block c = add(b.hash, "c");
        Block d = add(c.hash, "d");
        Block e = add(d.hash, "e");
        Block f = add(e.hash, "f");
        Block g = add(f.hash, "g");
        Block h = add(b.hash, "h");
        Block i = add(h.hash, "i");

        Block j = add(g.hash, "j");

        assertThat(blockchain.blocks.keySet()).doesNotContain(h.hash);
        assertThat(blockchain.blocks.keySet()).doesNotContain(i.hash);
        assertThat(blockchain.blocks.keySet()).contains(j.hash);
    }

}
