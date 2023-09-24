#include <iostream>
#include <string>
#include <memory>

class School {
public:
    School() {}

    School(std::string const& school_name) : school_name {school_name}
    {
        std::cout << __PRETTY_FUNCTION__ << '\n';
    }
    
    ~School()
    {
        std::cout << __PRETTY_FUNCTION__ << '\n';
    }

private:
    std::string school_name;
};

class Student {
public:
    Student() {}

    Student(int age, std::string const& name, int grade) :
        school {new School("Liviu Rebreanu")}, 
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
    std::unique_ptr<School> school;
    int age;
    std::string name;
    int grade;
};

int main()
{
    auto ptr = std::make_unique<Student>(17, "Mihai", 11);
    ptr->PrintInfo();
}