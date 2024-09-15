#include <iostream>
using namespace std;

void ScrieCaSumaDePuteriRec(int n, int cnt);

int main()
{
	int n;
	cin >> n;

	ScrieCaSumaDePuteriRec(n, 0);

	return 0;
}

void ScrieCaSumaDePuteriRec(int n, int cnt)
{
	if (n == 0) return;

	if (n % 2 == 1)
		cout << (1 << cnt) << ' ';

	ScrieCaSumaDePuteriRec(n / 2, cnt + 1);
}