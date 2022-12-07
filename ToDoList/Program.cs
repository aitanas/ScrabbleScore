using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList 
{
  public class Program
  {
    public static List<Item> toDoList = new List<Item> { };
    public static void Main()
    {
      Console.WriteLine("Welcome to your To Do List!");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string userSelection = Console.ReadLine();

      if (userSelection.ToLower() == "add") 
      {
        AddItem();
      }
      else if (userSelection.ToLower() == "view")
      {
        ViewList();
      }
      else 
      {
        Console.Write("Invalid response.");
        WhatNext();
      }
    }

    public static void AddItem()
    {
      Console.WriteLine("What task would you like to add?");
      string listItem = Console.ReadLine();
      Item newItem1 = new Item(listItem);
      toDoList.Add(newItem1);
      WhatNext();
    }

    public static void ViewList()
    {
      foreach (Item listItem in toDoList)
      {
        Console.WriteLine(listItem.Description);
      }
      WhatNext();
    }

    public static void WhatNext()
    {
      Console.WriteLine("Would you like to add another task? (Y/N)");
      string userSelection = Console.ReadLine();
      if (userSelection.ToUpper() == "Y")
      {
        AddItem();
      }
      else if (userSelection.ToUpper() == "N")
      {
        Console.WriteLine("Would you like to view your current To Do List? (Y/N)");
        string userSelection2 = Console.ReadLine();
        if (userSelection2.ToUpper() == "Y")
        {
          ViewList();
        }
        else if (userSelection2.ToUpper() == "N")
        {
          Console.WriteLine("Good-bye.");
        }
        else
        {
          Console.WriteLine("Invalid entry.");
        }
        }
      }
    }
  }