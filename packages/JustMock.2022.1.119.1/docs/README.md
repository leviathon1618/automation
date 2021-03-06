JustMock Lite
===

**JustMock Lite** is the most powerful free mocking framework available for .NET developers who practice unit testing and want to deliver exceptional software. It cuts your development time and helps you create better unit tests. It also enables you to perform fast and controlled tests that are independent of external dependencies like databases, web services or proprietary code. For more information, refer to the [git repository](https://github.com/telerik/JustMockLite) or our [JustMock Lite website](http://www.telerik.com/justmock/free-mocking).

### JustMock Lite Key Features
- **AAA pattern** – JustMockLite uses the Arrange Act Assert (AAA) pattern.
- **Error-Free Mocking** - Thanks to its strongly typed framework API, JustMock detects errors in your mock definitions and highlights them in Visual Studio. The JustMock Lite API fully leverages Visual Studio IntelliSense to make it easy to start mocking.
- **Mock interfaces** - Allows you to test public interfaces.
- **Mock classes** - Allows you to test public classes.
- **Mock properties** - Allows you to test the property getter and setter.
- **Mock and rise events** - Allows you to test events.
- **Control mock behavior** - Allows you to control the default behavior of a mock whether be to do nothing, call the original code or throw an exception.
- **Assert call occurrences** - Allows you to determine how many times a call has occurred.
- **Recursive mocking** - Еnable you to mock members that are obtained as a result of "chained" calls on a mock.
- **Sequential mocking** - Allows you to return different values on the same or different consecutive calls to one and the same type.
- **Support for out/ref** - Mock methods accepting our and ref parameters.
- **Support for Generics** - Mock generic classes and methods.
- **Fluent mocking** - Allows you setup your test arrangements and expectations from your mock object.
- **Being able to seamlessly upgrade to JustMock** - No rework of test is required. Simply install JustMock and make sure your project is referencing the correct assemblies.
- And many more.

JustMock
===

**JustMock Lite** is backed by a commercial version **[JustMock](https://www.telerik.com/products/mocking.aspx)** which is more advanced mocking framework based on JustMock Lite. JustMock is for developers who doesn't want to have any restrictions and be able to mock literally everything. For more information visit our [JustMock website](https://www.telerik.com/products/mocking.aspx).

### JustMock Key Features
- **All key features from JustMock Lite**
- **Mock non-public members and types** - Allows you to mock non-public members or types.
- **Mock non-virtual methods** - Allows you to mock non-virtual methods.
- **Mock extension method** - Allows you to mock extension methods.
- **Mock static classes, methods, and properties** - Allows you to mock static constructors, methods and properties getters and setters, set expectations and verify results.
- **Mock sealed classes** - Allows you to mock sealed classes and calls to their methods/properties
- **Mock partial mocking** - Allows you keep your original object and mock only the required methods.
- **Mock LINQ queries** - Allows you to mock LINQ queries with custom select.
- **Mock DLL imports** - Allows you to mock imported functions (decorated with the [DLLImport()] attribute)
- **Mock Ref return values and ref locals** - Allows you to arrange and verify Ref return and Ref locals
- **Mock Local functions** - Allows you mock Local functions.
- **Mock MsCorLib members** - Allows you to mock types and methods from .NET Framework/.NET Core, i.e. from MsCorLib.
- **Mock Microsoft SharePoint** - Allows you to mock types and method from SharePoint.
- **Mock Microsoft EntityFramework** - Allows you to easily create in-memory mocks of the DbSet and DbContext types.
- And many more

### Examples

```csharp
[TestMethod]
public void TestBookService()
{
    // Arrange - initialize objects and prepare data.
    var repository = Mock.Create<IBookRepository>();
    var expectedBook = new Book { Title = "Adventures" };
    var service = new BookService(repository);
    
    // prepare an expectation of what the GetWhere method should do when called with the specified parameters
    // and how many times the call is supposed to occur.
    Mock.Arrange(() => repository.GetWhere(book => book.Id == 1)).Returns(expectedBook).OccursOnce();

    // Act - execute the tested logic.
    Book actualBook = service.GetSingleBook(1);

    // Assert - verify that the actual result is equal to the expected.
    Assert.AreEqual(expectedBook.Title, actualBook.Title);
}
```

### Supported Frameworks
- .Net Framework 4.5+ and later.
- .NET 5, .NET 6
- .Net Core 2.0 and later.

### Documentation
JustMock Lite and JustMock are coming with extensive [Documentation](http://docs.telerik.com/devtools/justmock/introduction.html) and examples that will help you quickly get started with the framework.

### Feedback
JustMock Lite is constantly improved through customer interaction and feedback. If you want to suggest a new feature, bug report or vote for a popular one, please visit our [Feedback Portal](https://feedback.telerik.com/Project/105).


### Happy mocking!
