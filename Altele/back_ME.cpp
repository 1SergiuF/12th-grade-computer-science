#include <iostream>
using namespace std;

bool gasit;
int n, m;
char x[30];

void GenereazaCuv(int k, int cnt_M, int cnt_E);

int main()
{
	cin >> n >> m;

	GenereazaCuv(1, 0, 0);

	if (!gasit)
		cout << "IMPOSIBIL";

	return 0;
}

void GenereazaCuv(int k, int cnt_M, int cnt_E)
{
	if (cnt_M + cnt_E == n + m)
	{
		gasit = true;
		cout << x + 1 << '\n';
		return;
	}

	if (cnt_E < n && (k <= 2 || (x[k - 1] != 'E' || x[k - 2] != 'E')))
		x[k] = 'E', GenereazaCuv(k + 1, cnt_M, cnt_E + 1);
	if (cnt_M < m && (k <= 2 || (x[k - 1] != 'M' || x[k - 2] != 'M')))
		x[k] = 'M', GenereazaCuv(k + 1, cnt_M + 1, cnt_E);
}