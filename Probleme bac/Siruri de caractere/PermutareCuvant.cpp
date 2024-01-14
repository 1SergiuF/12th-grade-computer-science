#include <fstream>
#include <cstring>
using namespace std;

ifstream fin("permutarecuvant.in");
ofstream fout("permutarecuvant.out");

const int N = 21;

int main()
{
    char cuv[N];
    fin.getline(cuv, N);

    fout << cuv << ' ';

    char aux[N];

    for (int i = 1; cuv[i]; ++i)
    {
        strcpy(aux, cuv + i);
        strncpy(aux + strlen(cuv) - i, cuv, i);
        aux[strlen(cuv)] = '\0';

        fout << aux << ' ';
    }

    return 0;
}