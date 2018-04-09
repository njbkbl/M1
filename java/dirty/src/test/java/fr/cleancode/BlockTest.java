package fr.cleancode;

import static org.assertj.core.api.Assertions.assertThat;
import org.junit.Test;

public class BlockTest {

    @Test
    public void testInitialBlock() {
        Block block = new Block(null, "Le 09 Avril, cet exercice a été donné à Paris au meetup SOAT");
        assertThat(block.hash).isEqualTo(block.parentHash);
    }

    @Test
    public void testConstructorHash() {
        Block block = new Block("e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855", "some data");
        assertThat(block.hash).isEqualTo("0ef8fab0033cad2de4433e608c4d5d133c176757999044b89a7c9c0e3a298ec9");
    }

}
