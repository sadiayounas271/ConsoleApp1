﻿string name = string.Empty;
int age=0;
char gender = char.MinValue;

Console.WriteLine("enter your name");
name= Console.ReadLine();

Console.WriteLine("Enter Age");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Data {name}  {age}");

string hobbies= string.Empty;
