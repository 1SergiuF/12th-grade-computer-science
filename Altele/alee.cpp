#include <iostream>
#include <fstream>
#include <queue>
#include <utility>
using namespace std;

ifstream fin("alee.in");
ofstream fout("alee.out");

const int N = 176;
const int di[] = { -1, 0, 1, 0 };
const int dj[] = { 0, 1, 0, -1 };

int parc[N][N];
int alee[N][N];
queue<pair<int, int>> Q;

int n, m;
int x1, y1, x2, y2;

void CitesteDate();
void Lee(int i, int j);
bool Ok(int i, int j);

int main()
{
	CitesteDate();
	Lee(x1, y1);
	fout << alee[x2][y2];

	return 0;
}

void Lee(int i, int j)
{
	Q.push({ i, j });
	alee[i][j] = 1;

	while (!Q.empty())
	{
		pair<int, int> p = Q.front();
		Q.pop();

		for (int d = 0; d < 4; ++d)
		{
			int newi = p.first + di[d];
			int newj = p.second + dj[d];

			if (Ok(newi, newj))
			{
				alee[newi][newj] = alee[p.first][p.second] + 1;
				Q.push({ newi, newj });
			}
		}
	}
}

bool Ok(int i, int j)
{
	if (i < 1 || i > n || j < 1 || j > n)
		return false;

	if (alee[i][j] != 0)
		return false;

	if (parc[i][j] == 1)
		return false;

	return true;
}

void CitesteDate()
{
	fin >> n >> m;
	for (int i = 1, x, y; i <= m; ++i)
	{
		fin >> x >> y;
		parc[x][y] = 1;
	}

	fin >> x1 >> y1 >> x2 >> y2;
}