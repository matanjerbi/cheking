using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cheking
{
    internal class Animal
    {
        public string? Name { get; set; }
        protected string? Species { get; set; }
        protected string GetSpecies { get; }



    }

    internal class Dog : Animal
    {
        public string Speed { get; set; }
        public void SetSpecies(string? species)
        {
            Species = species;
        }





    }

    internal class Calculator
    {
        internal static int Add(int a, int b)
        {
            return a + b;

        }

    }
    internal class MathOperations
    {
        Calculator calc = new Calculator();

        public int Add(int a, int b)
        {
            return Calculator.Add(a, b);

        }
    }
    internal class LibraryItem
    {
        protected internal string? Title { get; }
        public string GetTitle()
        {
            return Title;
        }
    }
    internal class Book : LibraryItem
    {
        public void SetTitle(string title)
        {
            Title = title;
        }

    }

    internal class Account
    { 
    private protected int Balance { get; set; }
        public int GetBalance()
        {
            return Balance;
        }

        internal class SavingAccount : Account
        {
            public void SetBalance(int balance)
            {
                Balance = balance;
            }

        }

    }
    internal class Vehicle
    {
        protected string model { get; set; }
        private string engineCapacity { get; set; }


    }
    internal class Car : Vehicle
    {
    public string? numberOfDoors {  get; set; } 
    public void SetModel(string number, string model)
        {
            numberOfDoors = number;
            this.model = model;
        }
    public void GetDetailes()
        {
            Console.WriteLine(model, numberOfDoors);
        }    
    }
}
