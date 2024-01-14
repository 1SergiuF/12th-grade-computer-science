#include <fstream>
#include <algorithm>
using namespace std;

ifstream fin("fotbal.in");
ofstream fout("fotbal.out");

struct ev {
	int pos;
	bool val;
	bool pic;
	
	bool operator < (ev const& e)
	{
		if (pos == e.pos)
			return val < e.val;
		return pos < e.pos;
	}
};

const int NMAX = 1e5;
const int MOD = 1e9 + 9;
int N, K;
int st, dr, f;
long long rez;

ev e[2 * NMAX + 1];
long long perm[NMAX + 2];
int nrPic[2];

inline void PreCalcPerm();
long long InversModular(long long x);
long long Combinari(int n, int k);

int main()
{
	PreCalcPerm();
	
	fin >> N >> K;
	for (int i = 1; i <= N; ++i)
	{
		fin >> st >> dr >> f;
		e[2 * i - 2] = {st, false, (bool)f};
		e[2 * i - 1] = {dr, true, (bool)f};
	}
	
	sort(e, e + 2 * N);
	
	for (int i = 0; i < 2 * N; ++i)
		if (e[i].val == false)
			nrPic[e[i].pic]++;
		else
		{
			nrPic[e[i].pic]--;
			rez = (rez + Combinari(nrPic[0] + nrPic[1], K - 1) + MOD - Combinari(nrPic[e[i].pic], K - 1)) % MOD;
		}
	
	fout << rez;
		
	return 0;
}

long long Combinari(int n, int k)
{
	if (n < k)
		return 0;
		
	return perm[n] * InversModular(perm[n - k] * perm[k] % MOD) % MOD;
}

long long InversModular(long long x)
{
	long long p = 1;
	int put = MOD - 2;
	
	while (put)
	{
		if (put & 1)
			p = p * x % MOD;
		x = x * x % MOD;
		
		put >>= 1;
	}
	
	return p;
}

inline void PreCalcPerm()
{
	perm[0] = perm[1] = 1;
	for (int i = 2; i <= NMAX; ++i)
		perm[i] = perm[i - 1] * i % MOD;
}
