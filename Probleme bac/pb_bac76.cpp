#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");

int main()
{
	int x;
	int sm = 1000; // suma minima
	int sc = 0; // suma curenta

	fin >> x;
	sm = sc = x;

	while (fin >> x)
	{
		if (sc < 0)
			sc += x;
		else
			sc = x;

		if (sm > sc)
			sm = sc;
	}

	cout << sm;

	return 0;
}