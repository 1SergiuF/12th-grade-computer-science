#include <fstream>
#include <cstring>
using namespace std;

ifstream fin("muzical.in");
ofstream fout("muzical.out");

char muz[][4] = {"do1", "re", "mi", "fa", "sol", "la", "si", "do2"};
int Codificare(char* x)
{
    for (int i = 0; i < 8; ++i)
        if (strcmp(muz[i], x) == 0)
            return i;
}

int main()
{
    int n;
    int z;
    int sum = 0;
    char a[150];
    fin >> n;
    fin.get();

    for (int i = 0; i < n; ++i)
    {
        fin >> a;
        z = Codificare(a);
        sum += z;
    }

    fout << muz[sum % 8];

    return 0;
}