/* Det Componentelor tare-conexe.
 * Algoritmul lui Tarjan
 * 
 * Complexitate: 
 * 	O(2 * m) adica O(m)  - timp de executare
 *  O(2 * m) adica O(m)  - ca spatiu de memorie ocupat
 */ 

#include <fstream>
#include <vector>
#include <stack>
using namespace std;

ifstream fin("tarjan.in");
ofstream fout("tarjan.out");

using VI  = vector<int>;
using VB  = vector<bool>;
using VVI = vector<VI>;

int n, m;
VVI G;
VB v;
VB inStack;
VI index;       // retine timpii (indecsii) de descoperire
VI low;         // low[x] = indexul minim la care se poate ajunge dintr-un nod
                // utilizand o singura muchie de intoarcere

int idx;        // indexul curent

VVI ctc;        // retine pe fiecare linie cate o comp tare-conexa
VI c;           // componenta tare-conexa curenta
stack<int> stk; // retine nodurile in ordinea timpilor de descoperire

void CitesteGraf();
void Tarjan();
void Df(int x);
void ExtractCTC(int x);
void ScrieCTC();

int main()
{
    CitesteGraf();
    Tarjan();
    ScrieCTC();
    
    return 0;
}

void Tarjan()   // O(m)
{
    for (int node = 1; node <= n; ++node)
        if (!v[node])   // if (index[node] == 0)
            Df(node);
}

void Df(int x)  // O(m)
{
    v[x] = true;
    stk.push(x);
    inStack[x] = true;
    index[x] = low[x] = ++idx;

    for (int const& y : G[x])
        if (!v[y])  // daca y este fiul lui x
        {
            Df(y);
            low[x] = min(low[x], low[y]);
        }
        else
            if (inStack[y]) // daca y este stramos (back-edge)
                low[x] = min(low[x], index[y]);

    if (low[x] == index[x])
        ExtractCTC(x);
}

void ExtractCTC(int x)
{
    c.clear();
    while (!stk.empty())
    {
        int node = stk.top();
        c.push_back(node);
        stk.pop();
        inStack[node] = false;
        if (node == x)
            break;
    }

    ctc.push_back(c);
}

void CitesteGraf()
{
    fin >> n >> m;
    
    G = VVI(n + 1); // G[0], G[1], ..., G[n]
    v = inStack = VB(n + 1);
    index = low = VI(n + 1);

    int x, y;
    while (m--)
    {
        fin >> x >> y;
        G[x].push_back(y);
    }
}

void ScrieCTC()
{
    fout << ctc.size() << '\n';

    for (VI const& c : ctc)
    {
        for (int const& x : c)
            fout << x << ' ';
        fout << '\n';
    }
}