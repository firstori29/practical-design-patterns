## Builder Design Pattern

**How to Implement**

1. Make sure that you can clearly define the common construction steps for building all available product
   representations. Otherwise, you won't be able to proceed with implementing the pattern.
   <br/><br/>
2. Declare these steps in the base builder interface.
   <br/><br/>
3. Create a concrete builder for each of the product representations and implement their construction steps.
   <br/><br/>
   Don't forget to implementing a method for fetching the result of the construction. The reason why this method can't
   be declared inside the builder interface is that various builders may construct products that don't have a common
   interface. Therefore, you don't know what would be the return type for such a method.
   <br/><br/>
4. Think about creating a director class. It may encapsulate various ways to construct a product using the same
   builder object.
   <br/><br/>
5. The client code creates both the builder and the director objects. Before construction starts, the client must pass a
   builder object to the director. Usually, the client does this only once, via parameters of the director's class
   constructor. The director uses the builder object in all further construction. There's an alternative approach, where
   the builder is passed to a specific product construction method of the director.
   <br/><br/>
6. The construction result can be obtained directly from the director only if all products follow the same interface.
   Otherwise, the client should fetch the result from the builder.

*Reference:  Dive Into Design Patterns - Alexander Shvets.*