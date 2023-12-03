#include <fstream>
#include <vector>
#include <utility>
using namespace std;

ifstream fin("heapuri.in");
ofstream fout("heapuri.out");

class Heap {
    using VI = vector<int>;
    using VP = vector<pair<int, int>>;
public:
    Heap(int n = 0, const VI& D = VI(1)) :
        nH {0},
        H {VP(n + 1)},
        P {VI(n + 1)},
        D {D}
    {}

    void pop(int node)
    {
        int p = P[node];

        Swap(p, nH--);
        int s = 2 * p;

        while (s <= nH)
        {
            if (s + 1 <= nH && D[H[s + 1].first] < D[H[s].first])
                s++;
            if (D[H[s].first] < D[H[p].first])
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
        H[++nH].first = node;
        H[nH].second = nH;
        P[node] = nH;
        up(node);
    }

    void up(int node)
    {
        int s = P[node], p = s / 2;
        while (p != 0 && D[H[s].first] < D[H[p].first])
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
        return H[1].first;
    }

private:
    
    void Swap(int s, int p)
    {
        swap(H[s], H[p]);
        P[H[p].second] = p;
        P[H[s].second] = s;
    }

    int nH;
    VI P;
    VP H;      
    const VI& D;  
};

const int Inf = 0x3f3f3f3f;
int main()
{
    int n, op, node;
    vector<int> D(n + 1, Inf);
    Heap heap(n, D);

    fin >> n;
    while(n--)
    {
        fin >> op;
        if (op == 1)
        {
            fin >> node;
            heap.push(node);
        }

        else if (op == 2)
        {
            fin >> node;
            heap.pop(node);
        }

        else
            fout << heap.top() << '\n';
    }

    return 0;
}