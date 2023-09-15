////2. Animal Polymorphism:
//Create a simple hierarchy of animals (e.g., Dog, Cat, Bird) with a common method makeSound(). 
//Implement polymorphism by overriding this method in each animal class  void
//and demonstrate how you can make different animals produce their respective sounds using polymorphism.
#include <iostream>
using namespace std;
class Animal{     
  public:
  void makeSound(string a){   
    cout<<"\nmow mow"<<a;
  }

};

class Dog : public Animal{
  public:
  void makeSound1(string a){  /////function overriding
    cout<<"\nbhou-bhou"<<a;
  }
};

class Bird : public Dog{
  public:
  void makeSound2(string a){  
    cout<<"\nchii-chii"<<a;
  }
};  
int main()
{
  Bird b;
  b.makeSound2("bird");
  Dog d;
  d.makeSound1("dog");
  Animal c;
  c.makeSound("Cat");
    return 0;
}