#include <iostream>


typedef struct myfloat {
    unsigned int mantissa : 23;
    unsigned int exponent : 8;
    unsigned int sign : 1;
} myfloat_t;




int main()
{
    float num = 0.025f;
    myfloat_t shit = *(myfloat_t*)&num;
    printf("Sign:\t%d\nexponent:\t%d\nmantissa:\t%d\n", shit.sign, shit.exponent, shit.mantissa);


    // std::cout << "Hello World!\n";
    return 0;
}
