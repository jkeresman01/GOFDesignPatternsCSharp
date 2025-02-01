# GOFDesignPatterns

Gang of four - Design patterns in C#

### Abstract Factory
- Provide an interface for creating families of related dependant objects without specifying their concrete classes.

### Adapter
- Convert the interface of a class into another interface clients expect.
- Adapter lets classes work together that couldn't otherwise beacuse of incompatible interfaces

### Bridge
- Decouple an abstraction from its implementation  so that two can wary independandtly

### Builder
- Separate the construction of a complex object from its representation so that the same construction process can create different representations

### Chain of responsability
- Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
- Chain the receiving objects and passs the request along the chain until an object handles it.

### Command 
- Encapsulates a request as an object, thereby letting your parameterize clients with different requests, queue or log requests, and support undoable operations

### Composite
- Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients trat individual objects and compositions of objects uniformly.

### Decorator
- Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionalty.

### Facade
- Provide unified interface to a set of intrefaces in subsystem. Facade defines a higher-level intreface that makes the subsysteam easier to use.

### Factory Method
- Define an inteface for creating an object, but let subclasses decide which class to instantiate. Factory method lets a class defer instantiation to subclasses.

### Fylweight
- Use sharing to support large numbers of fine-grained objects efficiently

### Interpreter
- Given a language, define a representation for its grammar along with interpreter that uses the representation to interpret sentences in the language.

### Iterator
- Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation

### Mediator
- Define an object that encapsulates how a set of obejcts interact. Mediator promotes loose coupling by keeping objects from refferring to each other explicitly and it lets you vary their interaction independently.

### Memento
- Without violating encapsulation, capture and externalize an object's internal state so that an object can be restored to its state.

### Observer
- Define a one-to-many depdendecy between objects so that when one object changes state, all its dependants are notified and updated automatically.

### Prototype
- Specify the kinds of objects to create using a prototypical instance, and crate new objects by copying this prototype

### Proxy
- Provide a surroagate or placeholder for another object to control access to it.

### Singelton
- Ensure a class only has one instance, and provide a global point of access to it.

### State
- Allow an object to alter its behaviour when its internal state changes. The object will appear to change its class.

### Starategy
- Define a family of algorithms, encapsulate each one, and make them interchangable. Strategy lets the algorithm vary independantly from clients that use it.

### Template Method
- Define the skeleton of an algorithm in an operation, deffering some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

### Visitor
- Represents an operatation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.
