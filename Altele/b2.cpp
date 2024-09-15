#include <fstream>
#include <set>
#include <cmath>
using namespace std;

ifstream fin("b2.in");
ofstream fout("b2.out");

unsigned long long n;

int main()
{
	fin >> n;
	int log2n = log2(n);

	for (int i = 1; i <= log2n; ++i)
		for (int j = 0; j < i; ++j)
		{
			unsigned long long sp2 = (1ull << i) + (1ull << j);
			if (sp2 <= n)
				fout << sp2 << ' ';
		}

	return 0;
}