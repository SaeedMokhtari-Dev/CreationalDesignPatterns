The static factory method is a variation of the factory method pattern. It is used to create objects without having to call the constructor yourself.

When to use the Static Factory Method

* if you want to give a meaningfull name to the method that generates your object.
* if you want to avoid overcomplex object creation.
* if you want to limit the number of objects created (caching).
* if you want to return an object of any subtype of their return type.

There are some disadvantages like

* Classes without a public or protected constructor cannot be initialized in the static factory method.
* Static factory methods are like normal static methods, so they are not distinguishable from other static methods (this may vary from IDE to IDE)