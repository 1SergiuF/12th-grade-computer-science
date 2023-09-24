#ifndef my_unique_ptr
#define my_unique_ptr

#include <iostream>

template<class T>
class my_unique_p {
private:
    // member types
    using pointer = T*;
    using element_type = T;
public:

    /*  
        Ca sa fie smart-pointer, trebuie implementate operatiile:
        *  - deferentiere
        -> - indirectare        
    */

    pointer operator -> ()
    {
        return ptr;
    }

    element_type& operator * ()
    {
        return *ptr;
    }

    my_unique_p() : ptr {nullptr}
    {}

    explicit my_unique_p(pointer p) : ptr {p}
    {}

    // Copy Constructor - stergem
    my_unique_p(my_unique_p const&) = delete;

    // Move (copy) constructor (permis)
    my_unique_p(my_unique_p&& u) : ptr {u.ptr}
    {
        u.ptr = nullptr;  // IMPORTANT
    }

    // Assignment Operator (Operator de atribuire) - sters
    my_unique_p& operator = (my_unique_p const&) = delete;

    // Move Assignment Operator - permis
    my_unique_p& operator = (my_unique_p&& u)
    {
        if (this == &u) return *this;

        delete ptr;     // eliberez resursele curente
        ptr = u.ptr;
        u.ptr = nullptr;

        return *this;
    }

    ~my_unique_p()
    {
        delete ptr;
    }

    pointer get() const noexcept
    {
        return ptr;
    }

    pointer release() noexcept
    {
        pointer p = ptr;
        ptr = nullptr;
        return p;
    }

    void reset(pointer p = nullptr) noexcept
    {
        delete p;   // distrug vechiul obiect gestionat
        ptr = p;
    }

    // operator de conversie la tipul bool
    operator bool() const noexcept
    {
        return ptr != nullptr;
    }

private:
    pointer ptr;
};

template<class T, class...Types>
my_unique_p<T> make_my_unique(Types...args)
{
    T* ptr = new T(args...);
    return my_unique_p<T>(ptr);
}

#endif