#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");

int main()
{
	int x;
	int l = 0;
	int lmax = 0;
	int nr = 0;
	
	int k; fin >> k;
	
	while (fin >> x)
	{
		if (x % k != 0)
		{
			if (l > lmax)
			{
				nr = 1;
				lmax = l;
			}
			
			else if (l == lmax && l != 0)
				nr++;
				
			l = 0;
		}
		else
		{
			l++;
			
			if (l > lmax)
				nr = 1;
			
			else if (l == lmax && l != 0)
				nr++;
		}
	}
	
	cout << lmax << ' ' << nr;
	
	return 0;
}
