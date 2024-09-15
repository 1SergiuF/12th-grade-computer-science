#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.in");

int main()
{
	int x;
	// cele trei maxime
	int max1 = 0;
	int max2 = 0;
	int max3 = 0;

	while (fin >> x)
	{
		if (x % 100 == 20)
		{
			if (max1 < x)
				max1 = x;
			else if (max1 >= x && max2 < x)
				max2 = x;
			else if (max2 >= x && max3 < x)
				max3 = x;
		}
	}

	cout << max3 << ' ' << max2 << ' ' << max1;

	return 0;
}