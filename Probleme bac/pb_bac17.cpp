#include <iostream>
using namespace std;

void numar(int n, int c, int& m)
{
	int p = 1;
	bool ok = false;
	m = 0;
	
	while (n)
	{
		if (n % 10 != c)
		{
			ok = true;
			m = m + p * (n % 10);
			p = p * 10;
		}
		
		n = n / 10;
	}
	
	if (ok == false)
		m = -1;
}

int main()
{
	int n, c, m;
	cin >> n >> c;
	
	numar(n, c, m);
	
	cout << m;
	
	return 0;
}
