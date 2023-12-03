#include <iostream>
#include <cstring>
using namespace std;

const int N = 101;

bool Palindrom(char c[]);

int main()
{
    char a[N];
    char suf[N];
    char pref[N];
    char aux[N];

    cin.getline(a, N);

    if (Palindrom(a))
    {
        strcpy(suf, a);
        strcpy(pref, a);
    }

    else
    {
        for (int i = static_cast<int>(strlen(a)) - 1; i > 0; --i)
        {
            strncpy(aux, a, i);
            aux[i] = '\0';
            if (Palindrom(aux))
            {
                strcpy(pref, aux);
                break;
            }
        }

        for (int i = 1; i < static_cast<int>(strlen(a)); ++i)
        {
            strcpy(aux, a + i);
            if (Palindrom(aux))
            {
                strcpy(suf, aux);
                break;
            }
        }
    }

    cout << pref << ' ' << suf;
    return 0;
}

bool Palindrom(char c[])
{
    for (int i = 0, j = strlen(c) - 1; i <= j; i++, j--)
        if (c[i] != c[j])
            return false;

    return true;
}