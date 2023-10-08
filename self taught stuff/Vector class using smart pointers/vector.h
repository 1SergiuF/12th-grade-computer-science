#ifndef VECTOR_H
#define VECTOR_H

#include <string>
#include <initializer_list>
#include <memory>
#include <utility>
#include "iterator.h"

template<typename T>
class Vector {
private:
    size_t cap;
    size_t n;
    std::shared_ptr<T[]> sptr;

public:
    using iterator = Iterator<Vector, T>;

    Vector() : cap {0}, n {0}, sptr {std::shared_ptr<T[]>()}
    {}

    Vector(size_t n, T const& value = T()) : cap {n}, n {n}, sptr {std::make_shared<T[]>(n)}
    {
        for (size_t i = 0; i < n; ++i)
            sptr[i] = value;
    }

    Vector(std::initializer_list<T> list) : n {list.size()}, sptr {std::make_shared<T[]>(n)}
    {
        int index = 0;
        for (auto it = list.begin(); it != list.end(); ++it)
            sptr[index++] = *it;
    }

    Vector(Vector const& v) : cap {v.cap}, n {v.n}, sptr {std::make_shared<T[]>(n)}
    {
        for (size_t i = 0; i < n; ++i)
            sptr[i] = v.sptr[i];
    }

    Vector(Vector&& v) : cap {v.cap}, n {v.n}, sptr {v.sptr}
    {
        v.n = 0;
    }

    Vector& operator = (Vector const& v)
    {
        if (this == &v) return *this;
        n = v.n;
        sptr.reset(std::make_shared<T[]>(n));

        for (size_t i = 0; i < n; ++i)
            sptr[i] = v.sptr[i];

        return *this;
    }
};

#endif