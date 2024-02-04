#include <fstream>
using namespace std;

ifstream fin("secventauniforma.in");
ofstream fout("secventauniforma.out");

int main()
{
	int x;
	int l = 1; // lungimea secventei
	int lmax = 0; // lungimea maxima

	int e = 0; // elementul din secventa
	int nr = 0;

	fin >> x;
	e = x;
	nr = x;

	while (fin >> x)
	{
		if (nr == x)
			++l;

		else
		{
			if (lmax <= l)
			{
				lmax = l;
				e = nr;
			}

			nr = x;
			l = 1;
		}
	}

	fout << lmax << '\n';
	while (lmax--)
		fout << e << ' ';

	return 0;
}