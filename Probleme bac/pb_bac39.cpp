#include <iostream>
using namespace std;

int ProdusDivImp(int x)
{
	int p = 1;
	for (int i = 1; i <= x; ++i)
		if (x % i == 0 && i % 2 == 1)
			p = p * i;
			
	return p;
}

int MaxImp(int a, int b)
{
	int vmax = 0;
	for (int i = a; i <= b; ++i)
		if (vmax < i && ProdusDivImp(i) > i)
			vmax = i;
			
	return vmax;
}

int main()
{
	int a, b;
	cin >> a >> b;
	
	cout << MaxImp(a, b);
	
	return 0;
}
