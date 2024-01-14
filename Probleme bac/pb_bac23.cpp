#include <iostream>
using namespace std;

int NrFactPrimi(int x)
{
	int cnt = 0;
	int d = 2;
	int p;
	
	while (x > 1)
	{
		p = 0;
		while (x % d == 0)
		{
			++p;
			x /= d;
		}
		
		if (p)
			++cnt;
			
		++d;
		if (x > 1 && d * d > x)
			d = x;
	}
	
	return cnt;
}

void nrfp(int n, int& m)
{
	int nr_max = -1;
	for (int i = 2; i <= n; ++i)
	{
		if (NrFactPrimi(i) >= nr_max)
		{
			nr_max = NrFactPrimi(i);
			m = i;
		}
	}
}

int main()
{
	int n, m;
	cin >> n;
	
	nrfp(n, m);
	
	cout << m;
	
	return 0;
}
