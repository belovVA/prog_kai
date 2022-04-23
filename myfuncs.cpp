#include <iostream>

#include <string>
#include<vector>
#include <map>
#include <algorithm>



#include "functions.h"

using namespace std;

extern vector<double> my_vector;
extern multimap<double,int > my_dict;

string my_func() {
    setlocale(LC_ALL, "Rus");
    string answer;
    sort(my_vector.begin(), my_vector.end());
    cout << endl;
    int count = 0;
    answer = "Ответ: ";
    count = 0;
    for (int now = 0; now < my_vector.size(); now++) {
        for (auto itr = my_dict.begin(); itr != my_dict.end(); itr++) {
            answer += to_string(itr->second) + ",";
            count++;
            if (count == 4)
                break;
        }
        if (count == 4)
            break;
    }
    answer.pop_back();
    answer += ".";
    return answer;
}