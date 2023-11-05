#include <iostream>
using namespace std;

int f(int n)
{
	int c;
	if (n == 0) return 9;
	c = f(n / 10);
	if (n % 10 < c) return n % 10;
	return c;
}

int main()
{
	cout << f(38627);
	
	return 0;
}
