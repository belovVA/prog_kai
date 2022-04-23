#include <iostream>
#include <fstream>
#include <vector>
#include <map>

#include "functions.h"


extern std::vector<double> my_vector;
extern std:: multimap<double, int> my_dict;

int main()
{
    using namespace std;
    ifstream file_in("in.txt");
    ofstream file_out("out.txt");
    unsigned char in_lab;
    unsigned char out_lab;
    setlocale(LC_ALL, "Rus");
    while (true)
    {
        if (file_in.is_open() && file_out.is_open())
        {
            cout << "Ввод с консоли (0) или из файла  (1): ";
            in_lab = get_0_1();
            cout << "Вывод с консоли (0) или из файла (1): ";
            out_lab = get_0_1();
            if (in_lab == '0' && out_lab == '0')
            {
                if (init())
                    cout << my_func() << endl;

                if (getNext())
                {
                    my_vector.clear();
                    my_dict.clear();
                    continue;
                }
                else
                {
                    cout << "До скорой встречи." << endl;
                    break;
                }
            }
            else if (in_lab == '0' && out_lab == '1')
            {
                if (init())
                    file_out << my_func() << endl;

                if (getNext())
                {
                    my_vector.clear();
                    my_dict.clear();
                    continue;
                }
                else
                {
                    cout << "До скорой встречи." << endl;
                    break;
                }
            }
            else if (in_lab == '1' && out_lab == '0')
            {
                if (file_init(file_in))
                    cout << my_func() << endl;

                break;
            }
            else if (in_lab == '1' && out_lab == '1')
            {
                if (file_init(file_in))
                    file_out << my_func() << endl;

                break;
            }
        }
        else
        {
            cout << "Не удалось открыть файл(ы)!" << endl;
            break;
        }
    }
    file_in.close();
    file_out.close();
    return 0;
}