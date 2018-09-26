# NetCSS StyleSheet Parser for .NET

## Overview

NetCSS is a continuation of the [ExCSS](https://github.com/TylerBrinks/ExCSS) CSS parser project. The orignal project appears to no longer take pull requests, and so this project was created to pick up where ExCSS version 3.0 left off. NetCSS is a .NET implementation of a CSS 2.1 and CSS 3 lexer and parser intended to provide an easy-to-use CSS object model.
 
## Installation

TODO: Get this on NuGet

## A basic example: 

**TODO: Update this to a working model of the ExCSS 3.0 syntax**
	var parser = new StylesheetParser();
	var stylesheet = parser.Parse(".someClass{color: red; background-image: url('/images/logo.png')");
	
	var rule = stylesheet.Rules.First()
	var selector = rule.SelectorText; // Yields .someClass
        var color = rule.Style.Color;
	var image = rule.Style.BackgroundImage; // url('/images/logo.png')
