/* Reducere la Directed Acyclic Graph (DAG)
 * Colapsarea componentelor tare conexe in noduri.
 * Se obtine un nou graf orientat aciclic,
 */ 
#include <fstream>
#include <vector>
#include <stack>
using namespace std;

ifstream fin("dag.in");
ofstream fout("dag.out");

using VI  = vector<int>;
using VB  = vector<bool>;
using VVI = vector<VI>;

VVI G;
VVI dag;
VI index, low;
VI c;           // c[x] = nodul din noul graf (componenta tare conexa) care include nodul x din graful initial
VB inStack, v;
stack<int> stk; // stiva din care extragem ctc

int n, N;       // n graful initital, N - nr noduri dag
int idx;

void CitesteGraf();
void Tarjan();
void Df(int x);
void CreeazaDag();
void ScrieDag();

int main()
{
    CitesteGraf();
    Tarjan();

    CreeazaDag();
    ScrieDag();

    return 0;
}

void Tarjan()
{
    for (int node = 1; node <= n; ++node)
        if (!v[node])
            Df(node);
}

void Df(int x)
{
    v[x] = true;
    stk.push(x);
    inStack[x] = true;
    index[x] = low[x] = ++idx;

    for (int const& y : G[x])
        if (!v[y])
        {
            Df(y);
            low[x] = min(low[x], low[y]);
        }
        else
            if (inStack[y])
                low[x] = min(low[x], index[y]);

    if (low[x] == index[x])
    {
        N++;
        while (true)
        {
            int y = stk.top();
            stk.pop();
            c[y] = N;
            inStack[y] = false;
            if (y == x)
                break;
        }
    }
}

void CreeazaDag()   // arcele intre componentele tare-conexe
{
    dag = VVI(N + 1);
    for (int x = 1; x <= n; ++x)
        for (int const& y : G[x])
            if (c[x] != c[y])
                dag[c[x]].push_back(c[y]);
}

void ScrieDag()
{
    fout << "N = " << N << '\n';
    for (int x = 1; x <= N; ++x)
    {
        fout << x << " : ";
        for (int const& y : dag[x])
            fout << y << ' ';
        fout << '\n';
    }

    fout << "Ce contin nodurile DAG:\n";
    for (int i = 1; i <= N; ++i)
    {
        fout << "Nodul " << i << " : ";
        for (int j = 1; j <= n; ++j)
            if (c[j] == i)
                fout << j << ' ';
            fout << '\n';
    }
}

void CitesteGraf()
{
    fin >> n;
    
    G = VVI(n + 1);
    c = VI(n + 1);
    v = inStack = VB(n + 1);
    index = low = VI(n + 1);

    for (int x, y; fin >> x >> y; G[x].push_back(y));
}