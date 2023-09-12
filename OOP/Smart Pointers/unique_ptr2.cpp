#include <iostream>
#include <string>
#include <memory>

class Student {
public:
    Student() {}

    Student(int age, std::string const& name, int grade) :
        age {age}, name {name}, grade {grade}
    {
        std::cout << __PRETTY_FUNCTION__ << '\n';
    }

    ~Student()
    {
        std::cout << __PRETTY_FUNCTION__ << '\n';
    }

    void PrintInfo() const noexcept
    {
        std::cout << "Age:   " << age << '\n'
                  << "Name:  " << name << '\n'
                  << "Grade: " << grade << '\n';
    }

private:
    int age;
    std::string name;
    int grade;
};

int main()
{
    {
        std::unique_ptr<Student> ptr(new Student(18, "Marcel", 12));
        ptr->PrintInfo();

        // delete ptr; -> INUTIL !
    }

    std::cout << "Ultima instructiune din main()\n";
}