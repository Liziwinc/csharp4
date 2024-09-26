#include <fstream>
#include <string>
#include <iostream>

#ifdef DLLFORSHARP_EXPORTS
#define DLL_EXPORT __declspec(dllexport)
#else
#define DLL_EXPORT __declspec(dllimport)
#endif

using namespace std;

extern "C" DLL_EXPORT void input(float arr[]);
extern "C" DLL_EXPORT void output(float arr[]);
extern "C" DLL_EXPORT void summa(float arr[],int i,int j);

