#include "pch.h"
#include "file.h"

DLL_EXPORT void input(float arr[])
{
    std::cout << "Введите 11 чисел: " << std::endl;
    for (int i = 0; i < 11; i++) {

        std::cin >> arr[i];
    }
}

DLL_EXPORT void output(float arr[])
{
    std::cout << "Ваш массив: " << std::endl;
    for (int i = 0; i < 11; i++) {
        std::cout << arr[i]<<" ";
    }
}

DLL_EXPORT void summa(float arr[], int i, int j)
{
    float sum = 0;
    for (i; i <= j; i++) {
        sum += arr[i];
    }
    cout <<"сумма ="<< sum;
}
