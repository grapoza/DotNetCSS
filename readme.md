# DotNetCSS StyleSheet Parser for .NET

[![Build status](https://ci.appveyor.com/api/projects/status/potjcbo35c6jgjh2/branch/master?svg=true)](https://ci.appveyor.com/project/grapoza/dotnetcss/branch/master)

## Overview

DotNetCSS is a continuation of the [ExCSS](https://github.com/TylerBrinks/ExCSS) CSS parser project. The orignal project appears to no longer take pull requests, and so this project was created to pick up where ExCSS version 3.0 left off. DotNetCSS is a .NET implementation of a CSS 2.1 and CSS 3 lexer and parser intended to provide an easy-to-use CSS object model.
 
## Installation

TODO: Get this on NuGet

## A basic example
```c#
using DotNetCSS;
using System;
using System.Linq;

namespace SampleDotNetCSS
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new StylesheetParser();
            var stylesheet = parser.Parse(".someClass{color: red; background-image: url('/images/logo.png')");
            var rule = stylesheet.StyleRules.First();

            Console.WriteLine($"Selector is {rule.Selector.Text}"); // Selector is .someClass
            Console.WriteLine($"Color is {rule.Style.Color}"); // Color is rgb(255, 0, 0)
            Console.WriteLine($"BackgroundImage is {rule.Style.BackgroundImage}"); // BackgroundImage is url('/images/logo.png')

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
```
