#include <iostream>
#include <string>
#include <cmath>

using namespace std;

bool check_triangle(double a, double b, double c){
    /*
    As soon as all three fields have valid data in them, it needs to run the calculations to generate the triangle information.
    We’ll need to know whether the given values produce a valid triangle A simple calculation for this is to know that no two 
    sides added up can be less than the other side 
    
    (EG 3+4 > 5, so the above triangle is valid)
  */
  if(((a + b) > c) && ((a + c) > b) && ((b + c) > a)){  
    //cout << "This is a Valid Triangle" << endl;
    return true;
  }
  else{
    cout << "This is not a Valid Triangle" << endl;
    return false;
  }
}

void triangle_type(double a, double b, double c){
   if(a == b && b == c)
   {
       cout << "This is an Equalateral Triangle and it is valid" << endl;
   }
   else if(a == b || a == c || b == c)
   {
       cout << "This is an Isosceles Triangle and it is valid" << endl;
   }
   else if(((pow(a,2) + pow(b,2) == pow(c,2))) || ((pow(a,2) + pow(c,2) == pow(b,2))) || ((pow(b,2) + pow(c,2) == pow(a,2)))){
       cout << "This is a Right Triangle and it is valid" << endl;
   }
   else{
       cout << "This is a Triangle and it is valid" << endl;
   }
}

int check_input(double input){
    /*
    The application needs to validate user input and not allow for non-numbers to be entered.
    */
    while(cin.fail() || input <= 0) {
        cout << "Error, That is not a Valid Length" << endl;
        cout << "Please Enter a Valid Length" << endl;
        cin >> input;
    }
    return input;
}

int main()
{
  double a;
  double b;
  double c;
  
  /* Input Lengths */
  cout << "Enter The Length of Side A" << endl;
  cin >> a;
  a = check_input(a);
  cout << "Enter The Length of Side B" << endl;
  cin >> b;
  b = check_input(b);
  cout << "Enter The Length of Side C" << endl;
  cin >> c;
  c = check_input(c);
    
  cout << a << " " << b << " " << c << endl;
  
  /* Check To See If Triangle is Valid */
  if(check_triangle(a,b,c) == false)
  {
    system("PAUSE");
    return 0;
  }
  
  /* Check To See The Triangle Type */
  triangle_type(a,b,c);
  
  system("PAUSE");
  return 0;
}



