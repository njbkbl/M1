Blockchain SOAT Clean Code
==========================

This repository contains sample code used to explain the Clean Code Principles

Used in 
* [the MeetUp - SOAT - Clean Code](https://www.meetup.com/TechLabs-by-SOAT/events/248763538/)

Goal - Build A Simple BlockChain
--------------------------------

The repository contains source code of different programming languages that implements a very simple BlockChain.


BlockChain :
* is a chain of blocks.
* each block in the chain point to a single parent block


Block : 
* Belongs to a BlockChain 
* Has a hash 
* Refers exactly one parent block that must exist in the BlockChain
* Has some data


Adding a new block into the blockchain can be done if and only if:
* The parent of the block belongs to the blockchain
* The parent is young enough (it has no more than 6 descendents)


A blockchain cannot have two parallel branches with a length of 6 or more. The shortest should be removed.

 

Step 0 : Init
-------------

Clone your project 
Compile (Java or C#)
Run the Tests


Step 1 : Remove Technical Debt
------------------------------

* Use the linter to identify all defaults 
* fix them !
* commit and push the fixes into your fork


Step 2 : Code BlockChain.checkHashValidity
------------------------

* This functions checks that the block points to a parent that is in the blokchain


Step 3 : Code BlockChain.getLastBlock
--------------------------------------------------------

* This function returns the last added block


Step 4 : Code BlockChain.cleanBlockChain
--------------------------------------------------------

* This function remove dead branches : a branch is dead when it has a fork with more than 6 block in it.



