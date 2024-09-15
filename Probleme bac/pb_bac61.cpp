#include <iostream>
using namespace std;

bool VerifPrim(int x)
{
	if (x < 2) return false;
	if (x == 2) return true;
	if (x % 2 == 0) return false;

	for (int i = 3; i * i <= x; i += 2)
		if (x % i == 0)
			return false;

	return true;
}

void divprim(int n, int& k, int v[])
{
	bool gasit = false;
	int div = 0;
	for (int i = 2; i <= n; ++i)
		if (n % i == 0 && VerifPrim(i))
		{
			div = i;
			break;
		}

	int succ_div = -1;
	for (int i = 1; i <= k; ++i)
	{
		if (v[i] == div)
		{
			gasit = true;
			break;
		}
		else
			if (v[i] > div)
			{
				succ_div = i;
				break;
			}
	}

	if (gasit == false)
	{
		if (succ_div < 0)
		{
			k++;
			v[k] = div;
		}
		else
		{
			int t = v[succ_div];
			k++;
			v[succ_div] = div;
			for (int i = succ_div + 1; i <= k; ++i)
			{
				int aux = v[i];
				v[i] = t;
				t = aux;
			}
		}
	}
}

int main()
{
	int n, k;
	int v[100];

	cin >> n >> k;
	for (int i = 1; i <= k; ++i)
		cin >> v[i];

	divprim(n, k, v);

	cout << k << '\n';
	for (int i = 1; i <= k; ++i)
		cout << v[i] << ' ';

	return 0;
}