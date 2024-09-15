#include <fstream>
#include <cmath>
using namespace std;

typedef unsigned long long ULL;

ifstream fin("memory008.in");
ofstream fout("memory008.out");

int frecvn[63];
int frecvf[63];
int n;
ULL x;
int k;

int main()
{
	fin >> n;
	while (fin >> x)
	{
		float log2x = log2(x);
		if (abs(log2x - (int)log2x) > 0)
			
	}
}