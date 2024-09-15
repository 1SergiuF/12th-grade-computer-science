#include <iostream>
#include <cstring>
using namespace std;

int main()
{
    char s[21];
    int p;

    cin.getline(s, 21);

    for (p = 0; s[p]; ++p)
    {
        if (s[p] == 'A' && (s[p + 1] == 'I' || s[p - 1] == 'I'))
            continue;
        else
            cout << s[p];
    }

    return 0;
}