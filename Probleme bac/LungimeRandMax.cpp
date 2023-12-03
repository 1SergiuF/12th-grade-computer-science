#include <fstream>
#include <cstring>
using namespace std;

ifstream fin("lungimerandmax.in");
ofstream fout("lungimerandmax.out");

const int N = 10001;
int main()
{
    int l;
    char a[N];
    char c[N][100];

    fin >> l;
    fin.get();
    fin.getline(a, N);

    int cnt = 0;
    int sum = 0;

    char* p = strtok(a, " ");
    while (p)
    {
        strcpy(c[cnt++], p);
        p = strtok(nullptr, " ");
    }

    for (int i = 0; i < cnt; ++i)
    {
        if (sum + (int)strlen(c[i]) <= l)
            fout << c[i] << ' ';
        else
        {
            sum = 0;
            fout << '\n' << c[i] << ' ';
        }

        sum += strlen(c[i]) + 1;
    }

    return 0;
}