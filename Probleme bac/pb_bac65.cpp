#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");

int main()
{
	int n;
	fin >> n;

	if (n == 1)
	{
		cout << 1 << ' ' << 1;
		return 0;
	}

	int stive = 0;
	int cutii = 0;
	
	int k = n;
	while (k > 1)
	{
		if (k == n)
		{
			cutii = k + 2;
			stive = 3;
		}
		else
		{
			cutii += 2 * k + 2;
			stive += 4;
		}

		k--;
	}

	cout << stive << ' ' << cutii;

	return 0;
}