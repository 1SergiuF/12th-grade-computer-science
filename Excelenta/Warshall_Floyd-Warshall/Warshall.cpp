/* Alg lui Warshall
 * Determina pt oricare pereche de noduri x, y
 * din graf daca exista sau nu un lant care le uneste
 * 
 * matr de adiacenta  => matr lanturilor
 */ 

#include <fstream>
using namespace std;

ifstream fin("warshall.in");
ofstream fout("warshall.out");

const int N = 101;
int n;
bool a[N][N];

void CitesteGraf();
void ScrieGraf();
void Warshall();

int main()
{
    CitesteGraf();
    ScrieGraf();  // matricea de adiacenta
    Warshall();
    ScrieGraf();  // matricea lanturilor

    return 0;
}

void Warshall() // O(n^3)
{
    for (int k = 1; k <= n; ++k)
        for (int i = 1; i <= n; ++i)
            for (int j = 1; j <= n; ++j)
                if (i != j && !a[i][j])
                    a[i][j] = a[i][k] && a[k][j];
}

void CitesteGraf()
{
    fin >> n;
    int x, y;
    while (fin >> x >> y)
    {
        a[x][y] = true;
        a[y][x] = true;
    }
}

void ScrieGraf()
{
    for (int i = 1; i <= n; ++i)
    {
        for (int j = 1; j <= n; ++j)
            fout << a[i][j] << ' ';
        fout << '\n';
    }

    fout << "\n\n";
}