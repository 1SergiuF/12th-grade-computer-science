#include <fstream>
#include <vector>
using namespace std;

typedef vector<int> VI;
typedef vector<bool> VB;
typedef vector<VI> VVI;
typedef long long ll;
typedef vector<ll> VL;

ifstream fin("arbore.in");
ofstream fout("arbore.out");

int n;
const int MOD = 666013;
VVI G;
VI nr;
VL fact, imod, res;
VB v;

void ReadGraph();
inline ll Comb(int n, int k);
inline ll Pow(int x, int n);
void CalcFactImod();
inline void DfsPreCalcNr(int x);
inline void DfsRes(int x);

int main()
{
	ReadGraph();
	CalcFactImod();
	DfsPreCalcNr(1);
	v = VB(n + 1, false);
	DfsRes(1);

	fout << res[1];

	return 0;
}

inline void DfsRes(int x)
{
	int total = nr[x] - 1;

	res[x] = 1;
	v[x] = true;
	for (int const& y : G[x])
		if (!v[y])
		{
			DfsRes(y);
			res[x] = (res[x] * res[y]) % MOD * Comb(total, nr[y]) % MOD;
			total -= nr[y];
		}
}

inline void DfsPreCalcNr(int x)
{
	nr[x] = 1;
	v[x] = true;

	for (int const& y : G[x])
		if (!v[y])
		{
			DfsPreCalcNr(y);
			nr[x] += nr[y];
		}
}

inline ll Comb(int n, int k)
{
	return ((fact[n] * imod[k]) % MOD * imod[n - k]) % MOD;
}

inline ll Pow(int x, int n)
{
	ll r = 1, p = x;

	while (n)
	{
		if (n & 1)
			r = (r * p) % MOD;
		p = (p * p) % MOD;
		n >>= 1;
	}

	return r;
}

void CalcFactImod()
{
	fact[0] = imod[0] = 1;

	for (int i = 1; i <= n; ++i)
	{
		fact[i] = (fact[i - 1] * i) % MOD;
		imod[i] = Pow(fact[i], MOD - 2);
	}
}

void ReadGraph()
{
	fin >> n;
	int x, y;

	G = VVI(n + 1);
	nr = VI(n + 1);
	fact = imod = res = VL(n + 1);
	v = VB(n + 1, false);

	for (int i = 1; i < n; ++i)
	{
		fin >> x >> y;
		G[x].push_back(y);
		G[y].push_back(x);
	}
}