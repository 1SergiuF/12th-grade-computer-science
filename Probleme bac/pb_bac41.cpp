#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");
int f[1001]; // sir de frecventa

int main()
{
	int x;
	while (fin >> x)
	{
		f[x]++;
	}
	
	for (int i = 1; i <= 1001; i += 2)
	{
		if (f[i] == 1) cout << i << ' ';
		else
		{
			for (int k = 1; k <= f[i]; ++k)
				cout << i << ' ';
		}
	}
	
	for (int i = 0; i < 1001; i += 2)
	{
		if (f[i] == 1) cout << i << ' ';
		else
		{
			for (int k = 1; k <= f[i]; ++k)
				cout << i << ' ';
		}
	}
	
	return 0;
}
