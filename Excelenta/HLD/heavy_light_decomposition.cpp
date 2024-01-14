// Heavy-Light Decompozition  (HLD)
#include <fstream>
#include <vector>
#include <algorithm>
using namespace std;

ifstream fin("heavypath.in");
ofstream fout("heavypath.out");

const int NMAX = 100001;
int n, q;
int val[NMAX], level[NMAX], father[NMAX];
int tree[4 * NMAX];      // arborele de intervale - retine toate lanturile heavy-path pe pozitii consecutive
int weight[NMAX];        // weight[x] - greutatea (nr de noduri) subarborelui cu radacina in x
int heavy_son[NMAX];     // heavy_son[x] = fiul cel mai greu al lui x
int head[NMAX];          // head[x] - nodul de inceput (cel mai de sus) al lantului greu caruia ii apartine x
int pos[NMAX];           // pos[x] - pozitia lui x in arborele de intervale (care contine toate lanturile grele)
int position;            // pozitia (eticheta) nodului curent in aint
vector<int> adj[NMAX];

void ReadGraph();
void Solve();

void Dfs(int x);
void Decompose(int x, int h);
int Query(int x, int y);

void UpdateTree(int node, int left, int right, int pos, int val);
int QueryTree(int node, int left, int right, int a, int b);

int main()
{
	ReadGraph();
	Solve();
	return 0;
}

void ReadGraph()
{
	fin >> n >> q;
	for (int i = 1; i <= n; ++i)
		fin >> val[i];

	int x, y;
	for (int i = 1; i < n; ++i)
	{
		fin >> x >> y;
		adj[x].push_back(y);
		adj[y].push_back(x);
	}
}

void Solve()
{
	Dfs(1);
	Decompose(1, 1);

	for (int i = 1; i <= n; ++i)
		UpdateTree(1, 1, n, pos[i], val[i]);

	int op, x, y;
	while (q--)
	{
		fin >> op >> x >> y;
		if (op == 0)
			UpdateTree(1, 1, n, pos[x], y);
		else
			fout << Query(x, y) << '\n';
	}
}

void Dfs(int x)
{
	int max_weight = 0;
	weight[x] = 1;

	for (int son : adj[x])
		if (son != father[x])
		{
			father[son] = x;
			level[son] = level[x] + 1;
			Dfs(son);
			weight[x] += weight[son];

			if (weight[son] > max_weight)
			{
				max_weight = weight[son];
				heavy_son[x] = son;
			}
		}
}

void Decompose(int x, int hd)
{
	pos[x] = ++position;
	head[x] = hd;
 //   UpdateTree(1, 1, n, poz[x], val[x]);
	if (heavy_son[x])
		Decompose(heavy_son[x], hd);

	for (int son : adj[x])
		if (heavy_son[x] != son && son != father[x])    // cu fiecare fiu exceptand fiul greu
			Decompose(son, son);                        // incepe un nou lant
}

int Query(int x, int y)
{
	int res = 0;

	while (head[x] != head[y])    // cat timp x si y sunt pe lanturi diferite
	{
		if (level[head[x]] < level[head[y]])
			swap(x, y);
		res = max(res, QueryTree(1, 1, n, pos[head[x]], pos[x]));
		x = father[head[x]];      // x trece in un alt lant pe o muchie usoara
	}

	// acum x si y se gasesc pe acelasi lant
	if (level[x] > level[y])
		swap(x, y);

	return max(res, QueryTree(1, 1, n, pos[x], pos[y]));
}

void UpdateTree(int node, int left, int right, int pos, int val)
{
	if (left == right)
	{
		tree[node] = val;
		return;
	}
	int mid = (left + right) >> 1;

	if (pos <= mid)
		UpdateTree(2 * node, left, mid, pos, val);
	else
		UpdateTree(2 * node + 1, mid + 1, right, pos, val);

	tree[node] = max(tree[2 * node], tree[2 * node + 1]);
}

int QueryTree(int node, int left, int right, int a, int b)
{
	if (a <= left && right <= b)
		return tree[node];

	int mid = (left + right) >> 1;
	int max1 = 0, max2 = 0;

	if (a <= mid)
		max1 = QueryTree(2 * node, left, mid, a, b);
	if (b > mid)
		max2 = QueryTree(2 * node + 1, mid + 1, right, a, b);
	return max(max1, max2);
}


