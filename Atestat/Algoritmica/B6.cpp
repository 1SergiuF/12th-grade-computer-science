#include <fstream>
using namespace std;

ifstream fin("atestat.in");
ofstream fout("atestat.out");

int Cmmdc(int a, int b)
{
	if (b == 0) return a;
	return Cmmdc(b, a % b);
}

int Cmmmc(int a, int b)
{
	return (a * b) / Cmmdc(a, b);
}

int main()
{
	int x;
	int n1, n2;

	fin >> n1 >> n2;
	int cmmdc = Cmmdc(n1, n2);
	int cmmmc = Cmmmc(n1, n2);

	while (fin >> x)
	{
		cmmdc = Cmmdc(cmmdc, x);
		cmmmc = Cmmmc(cmmmc, x);
	}

	fout << cmmdc << '\n' << cmmmc;

	return 0;
}