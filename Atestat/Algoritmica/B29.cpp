#include <fstream>
#include <iostream>
#include <iomanip>
#include <algorithm>
using namespace std;

ifstream fin("vanzari.in");

struct Vanzare {
	int c;
	double pret;
	double adaos;
	int index;
	
	bool operator < (Vanzare const& v) const noexcept
	{
		return c < v.c || (c == v.c && adaos < v.adaos);
	}
	
	friend istream& operator >> (istream& is, Vanzare& v)
	{
		return is >> v.c >> v.pret >> v.adaos;
	}
} v[101];

int main()
{
	int n;
	double sum = 0;
	fin >> n;
	
	for (int i = 1; i <= n; ++i)
	{
		fin >> v[i];
		v[i].index = i;
		double pv = v[i].c * (v[i].pret + v[i].pret * v[i].adaos / 100);
		sum += pv;
	}
	
	cout << fixed << setprecision(2) << sum << '\n';
	sort(v + 1, v + n + 1);
	
	cout << v[n].index;
	return 0;
}
