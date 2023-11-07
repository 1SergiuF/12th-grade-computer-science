#include <iostream>
using namespace std;

bool Prim(int x)
{
	if (x < 2) return false;
	if (x == 2) return true;
	if (x % 2 == 0) return false;
	
	for (int i = 3; i * i <= x; i += 2)
		if (x % i == 0)
			return false;
			
	return true;
}

int suma(int n)
{
	int s = 0;
	for (int i = 1; i <= n; ++i)
		if (n % i == 0 && !Prim(i))
			s += i;
			
	return s;
}

int main()
{
	int n;
	cin >> n;
	
	cout << suma(n);
	
	return 0;
}
