#include <iostream>
#include "pch.h"

using namespace std;

template <typename T>
T Max(T a, T b)
{
	return a < b ? b : a;
}