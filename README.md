# C#AdvDay1

# Complex Number Class in C#

## Overview

This project contains a C# implementation of a `Complex` number class that supports arithmetic and comparison operations using **operator overloading**.

## Features

✅ Constructor overloading  
✅ Operator overloading for:
- `+` (addition of complex-complex and complex-int)
- `-` (subtraction)
- `*` (multiplication)
- `/` (division)
- `%` (modulo using complex division logic)
- `==` and `!=` (equality check)
- `<`, `>`, `<=`, `>=` (based on magnitude)
- `++` and `--` (increment/decrement real part)

✅ Getter/Setter properties for `Real` and `Img`  
✅ `Print()` method for displaying the complex number

## Code Structure

- **Class `Complex`**:  
  Core class that holds the logic and overloads operators for complex number operations.

## Example Usage

```csharp
Complex c1 = new Complex(3, 4);
Complex c2 = new Complex(1, 2);

Complex sum = c1 + c2;
sum.Print(); // Output: 4 + 6i

Complex multiplied = c1 * c2;
multiplied.Print(); // Output: -5 + 10i

bool isEqual = c1 == c2; // false
