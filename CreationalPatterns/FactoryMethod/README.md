## Factory Method Design Pattern

**How to Implement**

1. Make all products follow the same interface. This interface should declare methods that make sense in every product.
   <br/><br/>
2. Add an empty factory method inside creator class. The return type of the method should match the common product
   interface.
   <br/><br/>
3. In the creator's code find all references to product constructors. One by one, replace them with calls to the factory
   method, while extracting the product creation code into the factory method.
   <br/><br/>
   You might need to add a temporary parameter to the factory method to control the type of returned product.
   <br/><br/>
   At this point, the code of the factory method may look pretty ugly. It may have a large switch statement that picks
   which product to instantiate. But don't worry, we'll fix it soon enough.
   <br/><br/>
4. Now, create a set of creator subclasses for each type of product listed in the factory method. Override the factory
   method in the subclasses and extract the appropriate bits of construction code from the base method.
   <br/><br/>
5. If there are too many product types and if it doesn't make sense to create subclasses for all of them, you can reuse
   the control parameter from the base class in subclasses.
   <br/><br/>
   For instance, imagine that you have the following hierarchy of classes: the base `Mail` class with a couple of
   subclasses: `AirMail` and `GroundMail`; the `Transport` classes are `Plane`, `Truck` and `Train`. While the `AirMail`
   class only uses the `Plane` objects, `GroundMail` may work with both `Truck` and `Train`. You can create a new
   subclass (say `TrainMail`) to handle both cases, but there's another option. The client code can pass an argument to
   the factory method of the GroundMail class to control which product it wants to receive.

*Reference:  Dive Into Design Patterns - Alexander Shvets.*