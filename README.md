# Uninitialized Property Access in C# Class Method

This repository demonstrates a potential bug in C# where a property of a class is accessed before it's been initialized within a method of the same class. This can lead to unexpected behavior or exceptions if the property's default value is not suitable for the operation.

The `bug.cs` file showcases the erroneous code.  The `bugSolution.cs` file shows the corrected version.  This subtle bug can be difficult to find, especially in larger projects.