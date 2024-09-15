#include <iostream>
#include <fstream>
#include <cstring>
#include <algorithm>
using namespace std;

ifstream fin("elevi.in");
ofstream fout("elevi.out");

struct Elev {
	char nume[101];
	char prenume[101];
	int nr_tot;
	int absm;
	int notapurt;
	
	bool operator < (Elev const& e) const noexcept
	{
		return notapurt > e.notapurt;
	}
	
	friend istream& operator >> (istream& is, Elev& e)
	{
		return is >> e.nume >> e.prenume >> e.nr_tot >> e.absm;
	}
	
	friend ostream& operator << (ostream& os, Elev const& e)
	{
		return os << e.nume << ' ' << e.prenume << ' ' << e.notapurt;
	}
	
} elevi[101];

int main()
{
	int n;
	fin >> n;
	
	for (int i = 1; i <= n; ++i)
	{
		fin >> elevi[i];
		
		int absnemot = elevi[i].nr_tot - elevi[i].absm;
		
		if (absnemot > 50)
			elevi[i].notapurt = 4;
		else
			elevi[i].notapurt = 10 - absnemot / 10;
	}
	
	sort(elevi + 1, elevi + n + 1);
	
	for (int i = 1; i <= n; ++i)
		fout << elevi[i] << '\n';
		
	return 0;
}
