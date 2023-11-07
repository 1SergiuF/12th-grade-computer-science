/* Alg lui Floyd-Warshall
 * Determina pt oricare pereche de noduri x, y
 * distanta minima dintre ele (costul minim al unui lant care le uneste)
 * 
 * F-W porneste de la matricea ponderilor
 *     pe care o transforma in matricea costurilor minime ale lanturilor
 */

#include <fstream>
#include <iomanip>
using namespace std;

ifstream fin("floyd_warshall.in");
ofstream fout("floyd_warshall.out");

const int N = 101, Inf = 0x3f3f3f3f;
int n;
int c[N][N];    // matricea ponderilor (se va transforma in matricea coosturilor minime ale lanturilor)

void CitesteGraf();
void Floyd_Warshall();
void ScrieMatrice();

int main()
{
    CitesteGraf();
    ScrieMatrice(); // matricea de adiacenta
    Floyd_Warshall();
    ScrieMatrice(); // matricea lanturilor

    return 0;
}

void Floyd_Warshall()   // O(n^3)
{
    for (int k = 1; k <= n; ++k)
        for (int i = 1; i <= n; ++i)
            for (int j = 1; j <= n; ++j)
                if (i != j && c[i][j] > c[i][k] + c[k][j])
                    c[i][j] = c[i][k] + c[k][j];
}

void CitesteGraf()
{
    fin >> n;
    for (int i = 1; i <= n; ++i)
        for (int j = 1; j <= n; ++j)
            if (i != j)
                c[i][j] = Inf;

    int x, y, cost;
    while (fin >> x >> y >> cost)
    {
        c[x][y] = cost;
        c[y][x] = cost;
    }
}

void ScrieMatrice()
{
    for (int i = 1; i <= n; ++i)
    {
        for (int j = 1; j <= n; ++j)
            if (c[i][j] == Inf)
                fout << " oo";
            else
                fout << setw(3) << c[i][j];

        fout << '\n';
    }

    fout << "\n\n";
}