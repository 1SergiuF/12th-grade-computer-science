#include <iostream>
#include <fstream>
using namespace std;

ofstream fout("bac.out");

int main()
{
	int x, y;
	cin >> x >> y;
	
	int n = y - x; // aflam n-ul
	
	while (y != 1)
	{
		fout << y << ' ';	// afisam in ordine inversa
		y = y - n;
		n = n - 2;
	}
	
	fout << 1;	// afisam ultimul termen din sir
	
	return 0;
}
