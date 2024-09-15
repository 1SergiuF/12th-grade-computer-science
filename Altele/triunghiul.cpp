#include <fstream>
using namespace std;

ifstream fin("triunghiul.in");
ofstream fout("triunghiul.out");

const int N = 20;
int pascal[N][N];
int n;

int main()
{
	fin >> n;

	for (int i = 0; i <= n; ++i)
		for (int j = 0; j <= i; ++j)
			if (i == j || j == 0)
				pascal[i][j] = 1;
			else
				pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];

	for (int j = 0; j <= n; ++j)
		fout << pascal[n][j] << ' ';

	return 0;
}