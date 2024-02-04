#include <iostream>
#include <fstream>
using namespace std;

ofstream fout("bac.txt");

int main()
{
	int x, y;
	cin >> x >> y;

	int z = 2; // precedentul lui x din sir
	fout << y << ' ' << x << ' ';

	while (z != 1)
	{
		z = 3 * x - y; // din formula de recurenta
		y = x;
		x = z;
		fout << z << ' ';
	}

	fout << 1; // mai ramane un 1

	return 0;
}