#include "pch.h"
#include "CppMath.h"
#include <stdio.h>

#define DLLDEMO1_EXPORTS

int Add(int a, int b)
{
	return a + b;
	printf("abc");
}

template <class T>
T Math<T>::Add(T a, T b)
{
	return a + b;
}