#include <iostream>
#include <algorithm>
#include <vector>
#include <limits>
using namespace std;

typedef vector<int> VI;
typedef vector<VI> VVI;

class LCA {
private:
    const int LOGMAX = 15;
	int n;
	vector<vector<int>> up;
	vector<vector<int>> g;
	vector<int> depth;
	void dfs(int node, int parent) {
		up[0][node] = parent;
		depth[node] = depth[parent] + 1;
		for(auto son : g[node])
			if(son != parent)
				dfs(son, node);
	}
public:
	void build(vector<vector<int>> &t) {
		n = t.size();
		g = t;
		up.resize(LOGMAX);
		depth.resize(n);
		for(int i = 0; i < LOGMAX; i++) up[i].resize(n);  
		dfs(0, 0);	
		
		for(int i = 1; i < LOGMAX; i++)
			for(int j = 0; j < n; j++)
				up[i][j] = up[i-1][up[i-1][j]]; 
	}
	int find(int x, int y) {
		if(depth[x] > depth[y]) swap(x, y);
		while(depth[y] != depth[x]) 
			y = up[0][y];
		if(x == y) return x;
		for(int i = LOGMAX-1; i >= 0 && x != y; i--)
			if(up[i][x] != up[i][y]) {
				x = up[i][x];
				y = up[i][y];
			}
		return up[0][y];
	}
	
};

class segtree {
private:
	vector<int> t;
public:
	void build(int sz) {
		t.resize(3 * sz);
	}
	void update(int node, int l, int r, int p, int val) {
		if(l == r) {
			t[node] = val;
			return ;
		}
		int mid = (l + r) >> 1;
		if(p <= mid) update(2*node+1, l, mid, p, val);
		else update(2*node+2, mid+1, r, p, val);
		t[node] = max(t[2*node+1], t[2*node+2]);
	}
	int query(int node, int l, int r, int x, int y) {
		if(x <= l && r <= y) return t[node];
		if(r < x || l > y) return 0;
		int mid = (l + r) >> 1;
		int a = query(2 * node + 1, l ,mid, x, y);
		int b = query(2 * node + 2, mid+1 ,r, x, y);
		return max(a, b);
	}	
};

class HLD {
private:
	int n, timer = 0;
	vector<vector<int>> g;
	vector<int> heavyChild, sz, chain, SegTreePos, nums, father;
	segtree sg;
	LCA l;
public:
	HLD(vector<vector<int>> &t, vector<int> &v) {
		n = t.size();
		g = t, nums = v;
		heavyChild.resize(n);
		sz.resize(n);
		father.resize(n);
		chain.resize(n);
		SegTreePos.resize(n);
		for(int node = 0; node < n; node++) chain[node] = node, heavyChild[node] = -1, SegTreePos[node] = 0;
		
		computeSize(0, 0);
		computeHeavyChains(0, 0);
		setHeavyChains(0, 0);
		sg.build(n);
		buildSegTree();
		l.build(t);
	} 
	void computeSize(int node, int parent) {
		sz[node] = 1;
		father[node] = parent; 
		int bestSon = -1, hmax = -1;
		for(int son : g[node]) {
			if(son == parent) continue;
			computeSize(son, node);
			sz[node] += sz[son];
			if(sz[son] > hmax) 
				hmax = sz[son], bestSon = son;
		}
		heavyChild[node] = bestSon;
	}
	void computeHeavyChains(int node, int parent) {
		if(heavyChild[node] != -1)
			chain[heavyChild[node]] = chain[node];
		for(auto son : g[node])
			if(son != parent)
				computeHeavyChains(son, node);
	}
	void setHeavyChains(int node, int parent) { 
		SegTreePos[node] = timer++;
		if(heavyChild[node] !=-1) setHeavyChains(heavyChild[node], node);
		for(auto son : g[node])
			if(son != parent && son != heavyChild[node])
				setHeavyChains(son, node);
	}
	void buildSegTree() {
		for(int i = 0; i < n; i++)
			sg.update(0, 0, n, SegTreePos[i], nums[i]);
	}
	int queryPath(int parent, int son) {
		int ans = -10000;
		while(chain[parent] != chain[son]) { 
			ans = max(ans, sg.query(0 ,0 ,n, SegTreePos[chain[son]], SegTreePos[son]));
			son = father[chain[son]];
		}
		ans = max(ans, sg.query(0 ,0 ,n, SegTreePos[chain[son]], SegTreePos[son]));
		return ans;
	}
	int query(int x, int y) {
		int lca = l.find(x, y);
		return max(queryPath(lca, x), queryPath(lca, y)); 
	}
};

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(0); cout.tie(0);

	int n, q;
	cin >> n >> q;
	VI v;

	int value;
	for (int i = 1; i <= n; ++i)
	{
		cin >> value;
		v.push_back(value);
	}

	VVI G = VVI(n + 1);

	for (int i = 1, u, v; i < n; ++i)
	{
		cin >> u >> v;
		G[u].push_back(v);
		G[v].push_back(u);
	}

	int qt, a, b;
	HLD hld = HLD(G, v);
	for (int i = 1; i <= q; ++i)
	{
		cin >> qt >> a >> b;
		if (qt == 1)
			v[a] = b;
		else
		{			
			cout << hld.query(a, b) << ' ';
		}
	}

	return 0;
}