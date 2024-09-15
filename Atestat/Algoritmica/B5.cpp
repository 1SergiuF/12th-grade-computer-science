#include <fstream>
using namespace std;

ifstream fin("date.in");
ofstream fout("date.out");

int CifrePare(int n)
{
	int p = 1;
	int m = 0;

	while (n)
	{
		int c = n % 10;
		if (c % 2 == 0)
		{
			m = c * p + m;
			p = p * 10;
		}

		n /= 10;
	}

	return m;
}

bool CifreCresc(int n)
{
	int uc = n % 10;
	while (n)
	{
		if (n % 10 > uc)
			return false;

		uc = n % 10;
		n /= 10;
	}

	return true;
}

int main()
{
	int x;
	int sum = 0;

	while (fin >> x)
	{
		int x_par = CifrePare(x);
		if (CifreCresc(x_par))
			sum += x_par;
	}

	fout << sum;

	return 0;
}