#include <iostream>

using namespace std;


class Bank{
  
  public:
  void interest(); /// abstract function // visible 
};

class Sbi:  public Bank{
  public:
  void interest(){
    cout<<"the interest of is : ";  /// implementatin //// hiden 
  }
};
int main()
{
    Sbi s;
    s.interest();

    return 0;
}