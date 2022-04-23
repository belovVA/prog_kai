#include <iostream>
#include <limits>
#include <fstream>

#include <string>
#include<vector>
#include <map>

#include "functions.h"

using namespace std;

vector<double> my_vector;
multimap<double, int> my_dict;

int n;

bool init()
{
    double now_value;
    cout << "Введите значение n больше 4: ";
    n = trunc(getIndex()); // считывание n с использованием функции getIndex()

    if (checkIndexes()) // проверка правильности ввода n
    {
        for (int j = 0; j < n; j++) {
            cout << "my_vector[" << j << "] = ";
            now_value = getIndex(); // считывание значения
            my_vector.push_back(now_value); // добавление значения 
            my_dict.insert({ now_value,j });
        }
    }
    else {
        cout << "Неправильно указан индекс 'n' " << endl;
        return init();
    }
    return true;
}


bool file_init(ifstream& file) // считывание с файла
{
    double now_value;
    n = trunc(getNumberFromFile(file));
    cout << "n = " << n << endl;
    if (checkIndexes())
    {
        for (int j = 0; j < n; j++) {
            now_value = getNumberFromFile(file);
            cout << "my_vector[" << j << "] = " << now_value << endl;
            my_vector.push_back(now_value);
            my_dict.insert({ now_value, j });
        }
    }
    else {
        cout << "Неправильно указан индекс 'n' " << endl;
        return false;
    }
    return true;
}


double getIndex() // считывание n
{
    while (true)
    {
        double a;
        cin >> a;
        if (cin.fail()) { // проверка ошибки ввода
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            cout << "Ошибка ввода." << endl;
        }
        else {
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            return a; // вывод  
        }
    }
}

double getNumberFromFile(ifstream& file) // считывание n
{
    while (true)
    {
        double a;
        file >> a;
        if (file.fail()) {
            file.clear();
            file.ignore(numeric_limits<streamsize>::max(), '\n');
            cout << "Ошибка ввода." << endl;
        }
        else {
            file.ignore(numeric_limits<streamsize>::max(), '\n');
            return a;
        }
    }
}


bool checkIndexes()
{
    return (n >= 4);
}


char get_0_1()
{
    setlocale(LC_ALL, "Rus");
    while (true)
    {
        char sm;
        cin >> sm;
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        if (sm == '0' || sm == '1') {
            return sm;
        }
        else {
            cout << "Ошибка ввода." << endl;
        }
    }
}


bool getNext()
{
    setlocale(LC_ALL, "Rus");
    cout << "Продолжаем? (0 - нет, 1 - да): ";
    while (true)
    {
        char sm;
        cin >> sm;
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        if (sm == '0' || sm == '1') {
            return sm == '1';
        }
        else {
            cout << "Ошибка ввода." << endl;
        }
    }
}

