#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
int i = 1;
int j = 2;
int* ptr;
ptr = &i;       
*ptr = 3;      
ptr = &j;       
*ptr = 4;      
cout << i << " " << j << endl;
}