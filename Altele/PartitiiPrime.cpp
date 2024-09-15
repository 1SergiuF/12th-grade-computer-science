#include <iostream>
using namespace std;

int x[101];
int n;

bool VerifPrim(int n);
void PartNr(int k, int s);
void ScrieSol(int k);
int UrmatorulPrim(int n);

int main()
{
	x[0] = 2;
	cin >> n;
	PartNr(1, 0);

	return 0;
}

void PartNr(int k, int s)
{
	if (s == n)
	{
		ScrieSol(k - 1);
		return;
	}

	for (int i = x[k - 1]; i + s <= n; i = UrmatorulPrim(i))
	{
		s += i;
		x[k] = i;
		PartNr(k + 1, s);
		s -= i;
	}
}

int UrmatorulPrim(int n)
{
	++n;
	while (!VerifPrim(n))
		++n;

	return n;
}

bool VerifPrim(int n)
{
	if (n < 2) return false;
	if (n == 2) return true;
	if (n % 2 == 0) return false;

	for (int i = 3; i * i <= n; i += 2)
		if (n % i == 0)
			return false;

	return true;
}

void ScrieSol(int k)
{
	for (int i = 1; i <= k; ++i)
		cout << x[i] << ' ';
	cout << '\n';
}