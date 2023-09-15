/******************************************************************************
3. Employee Polymorphism:
Define an Employee class with a method calculateSalary(). Create subclasses for different types of employees
(e.g., Full_Time_Employee, Part_Time_Employee, Intern) 
and demonstrate how polymorphism can be used to calculate salaries differently for each type of employee.
*******************************************************************************/
#include <iostream>

using namespace std;

class employee{
  public:
  void calculateSalary(){
    cout<<"\ncalculateSalary Full_Time_Employee";
    cout<<"\ncalculateSalary Part_Time_Employee";
    cout<<"\ncalculateSalary Intern";
    
  }
};
class Full_Time_Employee : public employee{
  public:
  void calculateSalary(int f){
      int full = f*1500;
       cout<<"\nsalary of Full_Time_Employee is : "<<full;
  }
  
};
class Part_Time_Employee : public Full_Time_Employee{
  public:
  void calculateSalary1(int p){
      int part = p*500;
       cout<<"\nsalary of Part_Time_Employee is : "<<part;
  }
};
class Intern : public Part_Time_Employee {
  public:
  void calculateSalary2(int i){
      int intern = i*200;
       cout<<"\nsalary of Intern  is : "<<intern;
  }
};

int main(){
  employee e;
  e.calculateSalary();
  
  Intern I;
  I.calculateSalary2(28);
  Part_Time_Employee P;
  P.calculateSalary1(28);
  Full_Time_Employee F;
  F.calculateSalary(28);
  
  

    return 0;
}