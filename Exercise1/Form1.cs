﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        // Initialize list
        List<Car> Cars;
        public Form1()
        {
            InitializeComponent();

            // Instantiate list
            Cars = new List<Car>();
            CarList(); // Call Carlist

            // Sort list by letters based on "Make"
            var sortedList = Cars.OrderBy(x => x.Make);

            foreach (Car c in sortedList)
            {
                listBox1.Items.Add($"{c.Make} {c.Model} {c.Year}");
            }

            // Add event handler, shorthand syntax with lambda instead of normal function
            btnRedAmount.Click += new EventHandler(
                (sender, e) => // object sender, EventArgs e
                {
                    // Count all occurences of "Red" on every Color element
                    int i = Cars.Count(x => x.Color == "Red"); 
                    listBox2.Items.Add($"You have {i} red cars");
                }
            );

            btnOldCars.Click += new EventHandler(
                (sender, e) =>
                {
                    // Count all occurences of Year being before 2003
                    int i = Cars.Count(x => x.Year < 2003);
                    listBox2.Items.Add($"You have {i} cars made before 2003");
                }
            );

            btnGreyVolvo.Click += new EventHandler(
                (sender, e) =>
                {
                    // FindAll occurences of Volvo and count how many times "Grey" occur
                    int i = Cars.FindAll(x => x.Make == "Volvo").Count(y => y.Color == "Grey");
                    listBox2.Items.Add($"There are {i} gray Volvos");
                }
            );

            btnAverageBMW.Click += new EventHandler(
                (sender, e) =>
                {
                    // FindAll occurences of BMW and check the average km 
                    double j = Cars.FindAll(x => x.Make == "BMW").Average(y => y.Km);
                    listBox2.Items.Add($"Your BMW's have drove an average of {j}km");
                }
            );

            btnExpensive.Click += new EventHandler(
                (sender, e) =>
                {
                    // Order price in decending order and use the first result, ToList() to access the props
                    var sortedPrice = Cars.OrderByDescending(x => x.Price).ToList();
                    listBox2.Items.Add($"{sortedPrice[0].Make} {sortedPrice[0].Model} " +
                                       $"{sortedPrice[0].Year} is the most expensive car " +
                                       $"and it costs {sortedPrice[0].Price:C}");
                }
            );
        }
        public void CarList() // Just to get all the code out of the way, for readability and to prevent tumours
        {
            Cars.Add(new Car() { Id = 1, Make = "Volvo", Model = "V70", Color = "White", Km = 1292, Price = 3465, Year = 1998 });
            Cars.Add(new Car() { Id = 31, Make = "Skoda", Model = "Fabia", Color = "Red", Km = 1292, Price = 76556, Year = 2001 });
            Cars.Add(new Car() { Id = 14, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 432, Price = 32001, Year = 2003 });
            Cars.Add(new Car() { Id = 4, Make = "Volvo", Model = "V70", Color = "Red", Km = 1223492, Price = 24512, Year = 1998 });
            Cars.Add(new Car() { Id = 23, Make = "BMW", Model = "735", Color = "Black", Km = 435, Price = 234512, Year = 1999 });
            Cars.Add(new Car() { Id = 234, Make = "Audi", Model = "Q3", Color = "Blue", Km = 345, Price = 334552, Year = 2010 });
            Cars.Add(new Car() { Id = 451, Make = "Volvo", Model = "V40", Color = "Grey", Km = 235235, Price = 535512, Year = 2008 });
            Cars.Add(new Car() { Id = 651, Make = "Volvo", Model = "XC90", Color = "White", Km = 345345, Price = 34510, Year = 2011 });
            Cars.Add(new Car() { Id = 91, Make = "Volvo", Model = "V70", Color = "Red", Km = 345, Price = 4512, Year = 1997 });
            Cars.Add(new Car() { Id = 8001, Make = "Audi", Model = "A3", Color = "White", Km = 123492, Price = 87500, Year = 2001 });
            Cars.Add(new Car() { Id = 631, Make = "Audi", Model = "A8", Color = "Blue", Km = 55342, Price = 55400, Year = 2010 });
            Cars.Add(new Car() { Id = 51, Make = "Volvo", Model = "V40", Color = "Red", Km = 1692, Price = 3465, Year = 1999 });
            Cars.Add(new Car() { Id = 781, Make = "Skoda", Model = "Fabia", Color = "Blue", Km = 1792, Price = 56556, Year = 2000 });
            Cars.Add(new Car() { Id = 144, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 4382, Price = 25001, Year = 2004 });
            Cars.Add(new Car() { Id = 48, Make = "Volvo", Model = "V70", Color = "Red", Km = 12292, Price = 26512, Year = 1997 });
            Cars.Add(new Car() { Id = 912, Make = "BMW", Model = "735", Color = "Black", Km = 4395, Price = 134512, Year = 1960 });
            Cars.Add(new Car() { Id = 2344, Make = "Audi", Model = "Q3", Color = "Grey", Km = 3425, Price = 434552, Year = 2011 });
            Cars.Add(new Car() { Id = 4501, Make = "Volvo", Model = "V40", Color = "Grey", Km = 215235, Price = 435512, Year = 2007 });
            Cars.Add(new Car() { Id = 6051, Make = "Volvo", Model = "XC90", Color = "White", Km = 47345, Price = 134510, Year = 2012 });
            Cars.Add(new Car() { Id = 991, Make = "Volvo", Model = "V70", Color = "Red", Km = 3475, Price = 14512, Year = 1998 });
            Cars.Add(new Car() { Id = 801, Make = "Audi", Model = "A7", Color = "White", Km = 492, Price = 187500, Year = 2002 });
            Cars.Add(new Car() { Id = 6031, Make = "Audi", Model = "A6", Color = "Blue", Km = 553, Price = 55400, Year = 2011 });
        }
    }
}
