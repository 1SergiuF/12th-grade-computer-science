/**
    O(n * log(n)) - Preprocesare
    O(log(n)) / query
*/

#include <fstream>
using namespace std;

ifstream fin("stramosi.in");
ofstream fout("stramosi.out");

const int MAX_N = 250000;
int lg2[MAX_N + 5];
int stramos[18][MAX_N + 5]; // stramos[i][j] = al 2^î lea stramos al lui j
int N, M;

int main()
{
    fin >> N >> M;

    for (int i = 1; i <= N; ++i)
        fin >> stramos[0][i];   // tatii

    lg2[0] = lg2[1] = 0;
    for (int i = 2; i <= N; ++i)
        lg2[i] = lg2[(i >> 1)] + 1;

    // sau lg2 = log2(n)
    for (int i = 1; i <= lg2[N]; ++i)
        for (int j = 1; j <= N; ++j)
            stramos[i][j] = stramos[i - 1][stramos[i - 1][j]];

    int p, nod, i;
    while (M--)
    {
        fin >> nod >> p;

        i = 0;
        while (p)   // O(log2(n))
        {    
            if (p & 1)
                nod = stramos[i][nod];

            i++;
            p >>= 1;
        }

        fout << nod << '\n';
    }

    return 0;
}