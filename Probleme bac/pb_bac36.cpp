#include <iostream>
using namespace std;

void Impare(int& n)
{
	int p = 1;
	int m = n;
	
	while (m)
	{
		if ((m % 10) % 2 == 1)
			n = n - p;
			
		p = p * 10;
		m = m / 10;
	}
}

int main()
{
	int n;
	cin >> n;
	
	Impare(n);
	
	cout << n;
	
	return 0;
}
