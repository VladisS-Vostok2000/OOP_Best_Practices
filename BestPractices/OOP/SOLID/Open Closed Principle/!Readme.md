# Open Closed Principle

## Principle Description

The principle declares a `Null Constraint` rule for the Object-Orientired Programming paradigm. It prohibits the modification of parent elements (base classes, classes with direct dependencies - such as a private `enum` property in C# - or entire assemblies) when extending functionality, i.e., when adding new program features only.

## Example Description

The provided example illustrates a violation of this rule in `Mistake` and demonstrates the severity of the problem in `Escalation`, which arises from a direct dependency on an `enum` within the `Monitor` class of the `MonitorAssembly`.\
A concrete solution is presented, which involves separating assemblies, introducing dependency injection, and employing the Strategy pattern in `Refactoring`. This approach resolves the issue without sacrificing any other advantages.\
The final result is in `Soliton`.

## Explore

`Initial`: [OpenClosedPrinciple_Initial -> Master](https://github.com/VladisS-Vostok2000/BestPractices/compare/master...OpenClosedPrinciple_Initial)

[Mistake]()

[Escalation]()

[Refactoring]()

[Solution]()
