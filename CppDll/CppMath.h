#pragma once
#ifdef DLLDEMO1_EXPORTS
#define EXPORTS_API _declspec(dllexport)
#else
#define EXPORTS_API _declspec(dllimport)
#endif // DLLDEMO1_EXPORTS

extern "C" EXPORTS_API int Add(int a, int b);

template <class T>
class Math {
public:
	T Add(T a, T b);
};

