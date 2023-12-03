#include <iostream>
using namespace std;

#define Dim 100010

long long A[4 * Dim];
long long op, a, b;
int n, m;

void Build(int nod, int st, int dr);
void Update(int nod, int st, int dr, int poz, int val);
long long Query(int nod, int st, int dr);

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(0); cout.tie(0);

    cin >> n >> m;
    Build(1, 1, n);

    for (int i = 1; i <= m; ++i)
    {
        cin >> op >> a >> b;
        if (op == 1)
            Update(1, 1, n, a, b);
        else if (op == 2)
            cout << Query(1, 1, n) << '\n';
    }

    return 0;
}

void Build(int nod, int st, int dr)
{
    if (st == dr)
    {
        cin >> A[nod];
        return;
    }

    int mid = (st + dr) / 2;
    Build(2 * nod, st, mid);
    Build(2 * nod + 1, mid + 1, dr);
    A[nod] = A[2 * nod] + A[2 * nod + 1];
}

void Update(int nod, int st, int dr, int poz, int val)
{
    if (st == dr)
    {
        A[nod] = val;
        return;
    }

    int mid = (st + dr) / 2;
    if (poz <= mid)
        Update(2 * nod, st, mid, poz, val);
    else
        Update(2 * nod + 1, mid + 1, dr, poz, val);

    A[nod] = A[2 * nod] + A[2 * nod + 1];
}

long long Query(int nod, int st, int dr)
{
    if (a <= st && dr <= b)
        return A[nod];

    int mid = (st + dr) / 2;
    long long sum = 0;
    
    if (a <= mid)
        sum = Query(2 * nod, st, mid);
    if (b > mid)
        sum += Query(2 * nod + 1, mid + 1, dr);

    return sum;
}