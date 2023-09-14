
#include <iostream>

using namespace std;

class Shape {  //// base class 
  public:
 void calculateArea(){
    
  }
  
};

class Circle : public Shape{   //// drived class 
  public:
  void  calculateArea(float r) /// passing float value 
 {
   int area;
   area = 3.14*r*r;
   
   cout<<"\narea of circle is : "<<area;
 }
  
};

class Square : public Circle{
  public:
  void calculateArea(int a){
  int area;
   area = a*a;
   
   cout<<"\narea of square is : "<<area;
 }
  
};

class tringle : public Square{
  public :
  void calculateArea(int h, int b){
  int area2;
   area2 = 0.5*b*h;
   
   cout<<"\narea of square is : "<<area2;
 }
};
int main()
{
    tringle t;
    Square s;
    Circle c;
   s.calculateArea(15);
   c.calculateArea(50);  ////calling functions 
    t.calculateArea(14,10);
    

    return 0;
}