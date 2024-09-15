#include <iostream>
using namespace std;

void suma(int n, int& s)
{
	s = 0;
	int f[10] {0};
	
	while (n)
	{
		f[n % 10]++;
		if ((n % 10) % 2 == 1 && f[n % 10] == 1)
			s += n % 10;
			
		n /= 10;
	}
}

int main()
{
	int n, s;
	
	cin >> n;
	
	suma(n, s);
	
	cout << s;
	
	return 0;
}
