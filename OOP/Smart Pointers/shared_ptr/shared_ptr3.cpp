#include <iostream>
#include <memory>

class Car {
public:
    Car() : brand {""}, speed {0}
    {}

    Car(std::string const& brand, int speed) :
        brand {brand}, speed {speed}
    {
        std::cout << "Construiesc masina " << brand << '\n';
    }

    ~Car()
    {
        std::cout << "Distrug masina " << brand << '\n';
    }

    void PrintInfo() const noexcept
    {
        std::cout << "Model:  " << brand << '\n'
                  << "Viteza: " << speed << '\n';
    }
private:
    std::string brand;
    int speed;
};

void Func(std::shared_ptr<Car> p)   // p se construieste prin copiere dupa p1
{
    std::cout << p.use_count() << '\n';
}

int main()
{
    // Recomandabil sa utilizam make_shared, nu direct new
    std::shared_ptr<Car> p1 = std::make_shared<Car>("Dacia", 170);
    std::cout << p1.use_count() << '\n';

    Func(p1);

    std::cout << p1.use_count() << '\n';
}