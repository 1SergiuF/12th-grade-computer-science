#include <iostream>
#include <algorithm>
#include <cstring>
using namespace std;

const int N = 10001;
char a[N];
int frecv[31];

int main()
{
    cin.getline(a, N);
    int dist = 0, lmin = strlen(a);
    int k = 0, j = 0;

    for (int i = 0; a[i]; ++i)
        if (!frecv[a[i] - 'a'])
        {
            frecv[a[i] - 'a'] = -1;
            ++dist;
        }

    for (int i = 0; a[i]; ++i)
    {
        frecv[a[i] - 'a']++;
        if (!frecv[a[i] - 'a'])
            ++k;
        
        if (k == dist)
        {
            while (frecv[a[j] - 'a'])
            {
                frecv[a[j] - 'a']--;
                ++j;
            }

            lmin = min(lmin, i - j + 1);
        }
    }

    cout << lmin;

    return 0;
}