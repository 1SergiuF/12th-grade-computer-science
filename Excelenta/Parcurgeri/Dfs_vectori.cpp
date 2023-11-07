#include <fstream>
#include <vector>
using namespace std;

ifstream fin("graf.in");
ofstream fout("graf.out");

using VI  = vector<int>;
using VB  = vector<bool>;
using VVI = vector<VI>;

int n;
VB v;
VVI G;

void CitesteDate();
void Dfs(int x);

int main()
{
    CitesteDate();
    Dfs(1);
    return 0;
}

void Dfs(int x) // O(n + m)
{
    v[x] = true;
    fout << x << ' ';
    for (int y : G[x])
        if (!v[y])
            Dfs(y);
}

void CitesteDate()
{
    fin >> n;

    v = VB(n + 1);  // acum exista G[0], G[1], ..., G[n] - vectori vizi
    G = VVI(n + 1); // acum exista v[0], v[1], ..., v[n] 

    int x, y;
    while (fin >> x >> y)
    {
        G[x].push_back(y);
        G[y].push_back(x);
    }
}