#include <fstream>
using namespace std;

ifstream fin("file.in");
ofstream fout("file.out");

int n, m;

int main()
{
	fin >> n >> m;
	int* a = new int[n + 1];
	int x;
	int i = 1;

	for (i = 1; i <= n; ++i)
		fin >> a[i];
	i = 1;
	int j = 1;
	fin >> x;
	while (i <= n && j <= m)
		if (a[i] < x)
			fout << a[i++] << ' ';
		else
		{
			fout << x << ' ';
			fin >> x;
			++j;
		}

	while (i <= n)
		fout << a[i++] << ' ';

	while (j <= m)
	{
		fout << x << ' ';
		fin >> x;
		++j;
	}

	delete a;

	return 0;
}