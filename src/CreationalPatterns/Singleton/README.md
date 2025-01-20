## Singleton Design Pattern

**How to Implement**

1. Add a private static field to the class for storing the singleton instance.
   <br></br>

2. Declare a public static creation method for getting the singleton instance.
   <br></br>

3. Implement "lazy initialization" inside the static method. It should create a new object on its first call and put it
   into the static field. The method should always return that instance on all subsequent calls.
   <br></br>

4. Make the constructor of the class private. The static method of the class will still be able to call the constructor,
   but not other objects.
   <br></br>

5. Go over the client code and replace all direct calls to the singleton's constructor with calls to its static creation
   method.

*Reference:  Dive Into Design Patterns - Alexander Shvets.*