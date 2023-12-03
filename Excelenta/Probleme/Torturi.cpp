// Complexitate O(n * log n)

#include <vector>
#include <cstdio>
#include <algorithm>

using VI = std::vector<int>;
using VB = std::vector<bool>;

int n, Lmax;
VB got;
VI a, b, v, q;

const int Lim = 100000;
const int Inf = 0x3f3f3f3f;
int p = Lim - 1;
char s[Lim];

void Get(int& x);
void Next();
inline int Bs(int x);
int LIS(VI const& b);

int main()
{
	freopen("torturi.in", "r", stdin);
	freopen("torturi.out", "w", stdout);

	Get(n);
	a = v = VI(n + 1);
	got = VB(n + 1);

	for (int i = 0, x = 0; i < n; ++i)
	{
		Get(x);
		a[i] = x;

		while (!q.empty() && a[q.back()] < x)
			q.pop_back();
		q.push_back(i);
	}

	for (int const& i : q)
		got[i] = true;

	for (int i = 0; i < n; ++i)
		if (!got[i])
			b.push_back(a[i]);

	printf("%d\n", LIS(b) + static_cast<int>(q.size()));
	return 0;
}

int LIS(VI const& b)
{
	int p = 0; v[0] = Inf;
	for (int const& x : b)
	{
		p = Bs(x);
		if (p > Lmax)
			++Lmax, p = Lmax;
		v[p] = x;
	}

	return Lmax;
}

inline int Bs(int x)
{
	if (v[Lmax] >= x) return Lmax + 1;

	int l = 1, r = Lmax, p = 0, m;

	while (l <= r)
	{
		m = (l + r) / 2;
		if (v[m] >= x)
			l = m + 1;
		else
			r = m - 1, p = m;
	}

	return p;
}

void Next()
{
	if (++p == Lim)
	{
		std::fread(s, 1, Lim, stdin);
		p = 0;
	}
}

void Get(int& x)
{
	for (; s[p] < '0' || s[p] > '9'; Next());

	for (x = 0; s[p] >= '0' || s[p] <= 9; Next())
		x = x * 10 + s[p] - '0';
}