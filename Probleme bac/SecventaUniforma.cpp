#include <fstream>
using namespace std;

ifstream fin("secventauniforma.in");
ofstream fout("secventauniforma.out");

int main()
{
	int x;
	int y;
	int l = 1; // lungimea secventei
	int lmax = 0; // lungimea maxima

	int e = 0;
	int nr = 0;

	fin >> x >> y;

	if (x == y)
	{
		++l;
		if (lmax <= l)
			lmax = l;
	}

	while (fin >> e)
	{
		if (e == y)
		{
			++l;
			x = y;
			y = e;

			if (lmax <= l)
			{
				lmax = l;
				nr = x;
			}
		}

		else
		{
			l = 1;
			x = y;
			y = e;
		}
	}

	fout << lmax << '\n';
	while (lmax--)
		fout << nr << ' ';

	return 0;
}