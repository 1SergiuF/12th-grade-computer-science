#include <fstream>
#include <vector>
using namespace std;

ofstream fout("dijkstra.out");

//===============================================
class Heap {
    using VI = vector<int>;
public:
    Heap(int n = 0, const VI& D = VI(1)) :
        nH {0},
        H {VI(n + 1)},
        P {VI(n + 1)},
        D {D}
    {}

    void pop(int node = -1)
    {
        int p = node == -1 ? 1 : P[node];

        Swap(p, nH--);
        int s = 2 * p;

        while (s <= nH)
        {
            if (s + 1 <= nH && D[H[s + 1]] < D[H[s]])
                s++;
            if (D[H[s]] < D[H[p]])
            {
                Swap(s, p);
                p = s;
                s = 2 * p;
            }
            else break;
        }
    }

    void push(int node)
    {
        H[++nH] = node;
        P[node] = nH;
        up(node);
    }

    void up(int node)
    {
        int s = P[node], p = s / 2;
        while (p != 0 && D[H[s]] < D[H[p]])
        {
            Swap(p, s);
            s = p;
            p = s / 2;
        }
    }

    bool empty() const noexcept
    {
        return nH <= 0;
    }

    int top() const noexcept
    {
        return H[1];
    }

private:
    
    void Swap(int s, int p)
    {
        swap(H[s], H[p]);
        P[H[p]] = p;
        P[H[s]] = s;
    }

    int nH;
    VI H, P;      // P = poz in heap
    const VI& D;  // obligatoriu referinta constanta, altfel D e o copie a lui ::D
};

//===============================================

using VI  = vector<int>;
using VP  = vector<pair<int, int>>;
using VVP = vector<VP>;

const int Inf = 0x3f3f3f3f;
int n, m;
bool inHeap;
VI D;
VVP G;

void Read();
void Write(const VI& D);
void Dijkstra(int x, VI& D);

int main()
{
    Read();
    Dijkstra(1, D);
    Write(D);
    return 0;
}

void Dijkstra(int x, VI& D)
{
    D = VI(n + 1, Inf);
    D[x] = 0;
    Heap heap(n, D);
    heap.push(x);

    while (!heap.empty())
    {
        x = heap.top(); // O(1)
        heap.pop();

        for (auto const& node : G[x])
        {
            int y = node.first;
            int w = node.second;
            if (D[y] > D[x] + w)
            {   
                inHeap = D[y] != Inf;   // y poate fi doar in heap sau cu D[y] = Inf
                D[y] = D[x] + w;

                if (inHeap)
                    heap.up(y);
                else
                    heap.push(y);
            }
        }
    }
}

void Read()
{
    ifstream fin("dijkstra.in");

    fin >> n >> m;
    G.resize(n + 1);
    int x, y, w;

    for (int i = 0; i < m; ++i)
    {
        fin >> x >> y >> w;
        G[x].emplace_back(y, w);
    }
}

void Write(VI const& D)
{
    for (int i = 2; i <= n; ++i)
        if (D[i] != Inf)
            fout << D[i] << ' ';
        else
            fout << "0 ";

    fout << '\n';
}