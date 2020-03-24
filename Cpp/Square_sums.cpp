#include <vector>
#include <iostream>
#include <math.h>

std::vector<int> square_sums_row(int n)
{
    std::vector<int> result;
    int min_square = (int)pow((int)sqrt(n + 1) - 1,2);
    int common_square = (int)pow((int)sqrt(n + 1), 2);
    int max_square = (int)pow((int)sqrt(n + 1) + 1, 2);
    if (max_square > (2*n -1))
    {
        max_square = common_square;
        common_square = min_square;
    }
    int max_count = n;
    if (common_square % 2 == 1)
    {
        max_count = n / 2;
    }
    bool* isUsed = new bool[n]();
    int number = (n + 1) / 2;
    result.push_back(number);



    for (int i = 0; i < result.size(); i++)
    {
        std::cout << result[i] << " ";
    }
    std::cout << std::endl;


    return std::vector<int>();
}


void TestCase()
{
    std::cout << "TEST1" << std::endl;
    square_sums_row(2);
    std::cout << "TEST2" << std::endl;
    square_sums_row(4);
    std::cout << "TEST3" << std::endl;
    square_sums_row(5);
    std::cout << "TEST4" << std::endl;
    square_sums_row(6);
    std::cout << "TEST5" << std::endl;
    square_sums_row(7);
    std::cout << "TEST6" << std::endl;
    square_sums_row(8);
}