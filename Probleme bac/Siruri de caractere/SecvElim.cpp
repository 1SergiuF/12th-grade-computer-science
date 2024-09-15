#include <iostream>
#include <cstring>
using namespace std;

char s[256];

void StergeSecv(int i, int l);

int main()
{
    cin.getline(s, 256);

    int i = 0;
    int l = 1;
    bool ok = true;

    while (s[i])
    {
        if (tolower(s[i]) == tolower(s[i - 1]))
            ++l;
        else
        {
            if (l > 1)
            {
                StergeSecv(i, l);
                i = 0;
            }

            l = 1;
        }

        i++;
        if (s[i] == '\0' && ok)
        {
            s[i] = ' ';
            s[i + 1] = '\0';
            ok = false;
        }
    }

    cout << s;

    return 0;
}

void StergeSecv(int i , int l)
{
    for( ; s[i]; i++)
        s[i - l] = s[i];

    s[i - l] = '\0';
}