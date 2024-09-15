#include <vector>
#include <stdio.h>
#include <time.h>
#include <string.h>
#include <algorithm>
using namespace std;

const int MaxN = 128;

vector<int> G[MaxN];
int tmin[MaxN][MaxN]; // tmin[x][k] = nr. min de orase pe care le pot plasa in judetul
					  // din subarborele cu radacina in x astfel incat sa ramana k orase neplasate
int nr[MaxN];
int v[MaxN];
int C[2 * MaxN];
int n, K;

void ReadData();
void Dfs(int x);
void WriteData();

int main()
{
	freopen("judete.in", "r", stdin);
	freopen("judete.out", "w", stdout);

	ReadData();
	Dfs(1);
	WriteData();

	return 0;
}

void Dfs(int x)
{
	nr[x] = 1;
	v[x] = 1;

	for (int const& f : G[x])
		if (!v[f])
		{
			Dfs(f);
			nr[x] += nr[f];
		}

	memset(tmin[x], 1, sizeof(tmin[x]));
	tmin[x][1] = 0;

	for (int const& f : G[x])
		if (v[f] == 2)
		{
			memset(C, 1, sizeof(C));

			for (int j = 0; j <= nr[x]; ++j)
				for (int k = 0; k <= nr[f]; ++k)
					if (j + k <= n)
					{
						C[j + k] = min(C[j + k], max(tmin[x][j], tmin[f][k]));

						if (k >= K)
							C[j] = min(C[j], max({ tmin[x][j], tmin[f][k], k }));
					}

			memcpy(tmin[x], C, sizeof(C));
		}

	v[x] = 2;
}

void ReadData()
{
	scanf("%d%d", &n, &K);
	int x, y;
	for (int i = 1; i < n; ++i)
	{
		scanf("%d%d", &x, &y);
		G[x].push_back(y);
		G[y].push_back(x);
	}
}

void WriteData()
{
	int T = 1 << 20;

	for (int i = K; i <= n; ++i)
		T = min(T, max(tmin[1][i], i));

	printf("%d\n", T);
}