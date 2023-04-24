﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public Car()
        {

        } 

        public Car(string makeInput, string modelInput, int year)
        {
            Make = makeInput;
            Model = modelInput;
            Year = year;
        }


        // fields
        // properties
        // Methods

        //Create a Make property of type string that is public 
        public string Make {  get; set; } //get= read set = write
        public string Model { get; set; } 
        public int Year { get; set; }   
    }
}
