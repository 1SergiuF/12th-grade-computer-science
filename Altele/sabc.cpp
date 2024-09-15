#include <iostream>
using namespace std;

int SumaInterval(int a, int b);

int main()
{
	int a, b, c;
	cin >> a >> b >> c;

	cout << SumaInterval(a, b) << ' '
		 << SumaInterval(b, c) << ' '
		 << SumaInterval(a, c);

	return 0;
}

int SumaInterval(int a, int b)
{
	int sgb = (b * (b + 1)) / 2;
	int sga = ((a - 1) * a) / 2;

	return sgb - sga;
}