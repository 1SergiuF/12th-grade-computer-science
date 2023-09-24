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

int main()
{
    std::shared_ptr<Car> p1(new Car("Dacia", 170));
    std::cout << p1.use_count() << '\n';

    std::shared_ptr<Car> p2 {p1};  // p2 se construiste prin copiere
    std::cout << p2.use_count() << '\n';
}