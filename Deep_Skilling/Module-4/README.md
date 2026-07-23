# Module 4 - NUnit and Moq

## What this demonstrates
- Unit testing an ASP.NET Core controller (`ProductsController` from Module 6) in isolation
- Mocking the `IProductRepository` dependency with Moq so no real database is needed
- Testing success paths (Ok, CreatedAtAction, NoContent) and failure paths (NotFound)
- Verifying interactions (`_mockRepo.Verify(...)`) — interaction-based testing

`AdditionalConceptsTests.cs` also covers:
- Parameterized tests (`[TestCase]`)
- Testing collections and string manipulation
- Testing methods that throw exceptions (`Assert.Throws`)
- Dependency Injection via constructor, property, and method parameters (each mocked separately)
- Ignoring a test with `[Ignore]`
- A note on generating code coverage reports

## To run
1. Create a separate test project: `dotnet new nunit -n DeepSkilling.Tests`
2. Add package references: `NUnit`, `NUnit3TestAdapter`, `Microsoft.NET.Test.Sdk`, `Moq`,
   `coverlet.collector` (for code coverage)
3. Reference the Web API project (Module 6) so `ProductsController`, `Product`, and
   `IProductRepository` are visible.
4. Copy both `ProductsControllerTests.cs` and `AdditionalConceptsTests.cs` into the test project.
5. Run: `dotnet test`
6. For code coverage: `dotnet test --collect:"XPlat Code Coverage"`
