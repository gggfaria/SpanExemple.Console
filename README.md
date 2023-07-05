# Using Span 

This project compares using Span to manipulate a string

# Class phone 

It has a phone number string that is going to be manipulated

## GetAreaCode Method

This method uses Substring to get the area code from the original string phone 

## GetAreaCodeSpan method

This method uses a ReadOnlySpan to get a string Slice and returns the string area code

# Benchmark

The use of Benchmark lib will show in release mode the difference between the two methods