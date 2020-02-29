#include "MainRunner.h"
#include <iostream>
#include <string>
using namespace std;
extern "C"             //No name mangling
__declspec(dllexport)  //Tells the compiler to export the function
int                    //Function return type     
__cdecl                //Specifies calling convention, cdelc is default, 
                       //so this can be omitted 
    
    CppTestRun() 
    {
        MainRunner();
        return 1;
    }
