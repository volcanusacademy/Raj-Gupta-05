//*2. Vehicle Inheritance:

//Implement a base class Vehicle with attributes like make, model, and year. Create subclasses (e.g., Car, Bicycle, Motorcycle) that inherit from Vehicle and add properties or methods specific to each type of vehicle.


#include <iostream>
using namespace std;

class Vehicle
{
public:
  string model;
  int year;
  string make;
};

class car:public Vehicle
{
public:
  car (string m, int y, string mk)
  {

    model = m;
    year = y;
    make = mk;
  }

  void display ()
  {
    cout << model;
    cout << year;
    cout << make;

  }
};

class Bike:public car
{
public:
  Bike (string m, int y, string mk)
  {

    model = m;
    year = y;
    make = mk;
  }

  void display1 ()
  {
    cout << model;
    cout << year;
    cout << make;

  }
};

class Bicycle:public Bike
{
public:
  Bicycle (string m, int y, string mk)
  {

    model = m;
    year = y;
    make = mk;
  }

  void display2 ()
  {
    cout << model;
    cout << year;
    cout << make;

  }
};

int
main ()
{
  car obj ("Sedan", 2023, "Hyundai");
  
  obj.display ();
  
  Bicycle ("Ranger",2023,"BMW");
  
  b.display2();
  
  
  bike B("Sports", 2020, "kawasakii");
  
  B.display1();
  
  


}
