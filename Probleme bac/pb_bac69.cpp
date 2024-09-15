#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");

int main()
{
	int x;
	int s = 0, smax = 0;

	fin >> x;
	s = smax = x;

	while (fin >> x)
	{
		if (s > 0)
			s += x;
		else
			s = x;

		if (smax < s)
			smax = s;
	}

	cout << smax;

	return 0;
}