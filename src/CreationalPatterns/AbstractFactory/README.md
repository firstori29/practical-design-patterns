## Abstract Factory Design Pattern

**How to Implement**

1. Map out a matrix of distinct product types versus variants of these products.
   <br/><br/>
2. Declare abstract product interfaces for all product types. Then make all concrete product classes implement these
   interfaces.
   <br/><br/>
3. Declare the abstract factory interface with a set of creation methods for all abstract products.
   <br/><br/>
4. Implement a set of concrete factory classes, one for each product variant.
   <br/><br/>
5. Create factory initialization code somewhere in the app. It should instantiate one of the concrete factory classes,
   depending on the application configuration or the current environment. Pass this factory object to all classes that
   construct products.
   <br/><br/>
6. Scan through the code and find all direct calls to product constructors. Replace them with calls to the appropriate
   creation method on the factory object.

*Reference:  Dive Into Design Patterns - Alexander Shvets.*