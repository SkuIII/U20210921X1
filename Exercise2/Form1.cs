﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        List<Car> Cars;
        public Form1()
        {
            InitializeComponent();

            // Instantiating list
            Cars = new List<Car>();

            #region carsAdded
            // Adding all cars
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
            #endregion

            #region carlist
            // Order all cars alphabetically by Make, Model and Year
            foreach (Car c in Cars.OrderBy(x => x.Make).ThenBy(x => x.Model).ThenBy(x => x.Year))
            {
                listBoxCars.Items.Add(c);
            }

            // Add new event, click or select index in listBox
            listBoxCars.SelectedIndexChanged += new EventHandler(ListClickHandler);

            #endregion

            #region combobox
            // Find each distinct color in Cars and print
            foreach (var uniqueColor in Cars.Select(x => x.Color).Distinct())
            {
                comboBoxColor.Items.Add(uniqueColor);
            }

            // Event for clicking on the colors on combobox
            comboBoxColor.SelectedIndexChanged += new EventHandler(
                    (sender, e) =>
                    {
                        // Clear listBox after each car
                        listBoxModels.Items.Clear();
                        
                        // Find all occurrences of SelectedItem (color) 
                        var colorList = Cars.FindAll(x => x.Color == (sender as ComboBox).SelectedItem as String);

                        // Print each car with the selected color
                        foreach (Car c in colorList)
                        {
                            listBoxModels.Items.Add(c);
                        }
                    }
                );

            listBoxModels.SelectedIndexChanged += new EventHandler(ListClickHandler);
            #endregion

            #region editcar
            // Event for clicking on the edit button
            btnEdit.Click += new EventHandler(
                (sender, e) =>
                    {
                        // Find the selected car based of ID
                        var selectedCarEdit = Cars.Find(x => x.Id == int.Parse(textBoxId.Text));

                        textBoxPrice.Text = selectedCarEdit.Price.ToString();
                        textBoxKm.Text = selectedCarEdit.Km.ToString(); 
                    }
                );

            // Event for clicking on the save button
            btnSave.Click += new EventHandler(
                    (sender, e) =>
                    {
                        // Find the selected car based of ID
                        var selectedCarEdit = Cars.Find(x => x.Id == int.Parse(textBoxId.Text));

                        // Replace price and km based of input
                        selectedCarEdit.Price = int.Parse(textBoxPrice.Text);
                        selectedCarEdit.Km = int.Parse(textBoxKm.Text);

                        // Clear all boxes 
                        textBoxId.Clear();
                        textBoxPrice.Clear();
                        textBoxKm.Clear();

                        listBoxInfo.Items.Clear();

                        listBoxInfo.Items.Add($"Id: {selectedCarEdit.Id}");
                        listBoxInfo.Items.Add($"Make: {selectedCarEdit.Make}");
                        listBoxInfo.Items.Add($"Model: {selectedCarEdit.Model}");
                        listBoxInfo.Items.Add($"Color: {selectedCarEdit.Color}");
                        listBoxInfo.Items.Add($"Km: {selectedCarEdit.Km}");
                        listBoxInfo.Items.Add($"Price: {selectedCarEdit.Price:C}");
                        listBoxInfo.Items.Add($"Year: {selectedCarEdit.Year}");
                    }
                );
            #endregion

            #region deleteCar
            // Event for clicking on the delete button
            btnDelete.Click += new EventHandler(
                (sender, e) =>
                {
                    // Find the index in the list where input lays
                    var selectedCarEdit = Cars.FindIndex(x => x.Id == int.Parse(textBoxDelId.Text));

                    // Remove Car object at index 
                    Cars.RemoveAt(selectedCarEdit);

                    RefreshListBox();
                }
            );
            #endregion

            #region addCar
            // Event for clicking on the Add button
            btnAdd.Click += new EventHandler(
                (sender, e) =>
                {
                    // Add new car object based on user input
                    Cars.Add(new Car()
                    {
                        Id = int.Parse(textBoxIdAdd.Text),
                        Make = textBoxMake.Text,
                        Model = textBoxModel.Text,
                        Color = textBoxColor.Text,
                        Km = int.Parse(textBoxKmAdd.Text),
                        Price = int.Parse(textBoxPriceAdd.Text),
                        Year = int.Parse(textBoxYear.Text)
                    });

                    RefreshListBox();
                }
            );
            #endregion
        }

        private void ListClickHandler(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();

            // sender is a ListBox
            Car mySelectedCar = (sender as ListBox).SelectedItem as Car;

            // Printing all the info in info box, need a better solution with line break
            listBoxInfo.Items.Add($"Id: {mySelectedCar.Id}");
            listBoxInfo.Items.Add($"Make: {mySelectedCar.Make}");
            listBoxInfo.Items.Add($"Model: {mySelectedCar.Model}");
            listBoxInfo.Items.Add($"Color: {mySelectedCar.Color}");
            listBoxInfo.Items.Add($"Km: {mySelectedCar.Km}");
            listBoxInfo.Items.Add($"Price: {mySelectedCar.Price:C}");
            listBoxInfo.Items.Add($"Year: {mySelectedCar.Year}");
        }
        private void RefreshListBox()
        {
            listBoxCars.Items.Clear();

            foreach (Car c in Cars.OrderBy(x => x.Make).ThenBy(x => x.Model).ThenBy(x => x.Year))
            {
                listBoxCars.Items.Add(c);
            }
        }
    }
}