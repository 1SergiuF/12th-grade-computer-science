#ifndef ITERATOR_H
#define ITERATOR_H

template<
    template<typename> typename Container,
    typename T
>
class Iterator {
private:
    Container<T>& container;
    int index;

public:
    Iterator(Container<T>& container, int index = int()) : container {container}, index {index}
    {}

    T operator * () const
    {
        return container[index];
    }

    T& operator * ()
    {
        return container[index];
    }

    T* operator -> () const
    {
        return container + index;
    }

    T*& operator -> ()
    {
        return container + index;
    }

    Iterator& operator ++ ()
    {
        index++;
        return *this;
    }

    Iterator operator ++ (int)
    {
        Iterator temp {*this};
        index++;
        return temp;
    }

    bool operator == (Iterator const& it) const noexcept
    {
        return index == it.index;
    }

    bool operator != (Iterator const& it) const noexcept
    {
        return !(*this == it)
    }
};

#endif