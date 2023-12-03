#include <iostream>
using namespace std;

int identice(int n);
int main()
{
	int n;
	cin >> n;
	cout << identice(n);
	
	return 0;
}

int identice(int n)
{
	int u = n % 10;
	n = n / 10;
	
	while (n)
	{
		if (n % 10 != u)
			return 0;
		n = n / 10;
	}
	
	return 1;
}
