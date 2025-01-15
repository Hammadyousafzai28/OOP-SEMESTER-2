#include <iostream>


#define X 2
#define Y 3
#define Z 4

int main()
{
    // dynamically allocate memory of size X*Y*Z
    int* A = new int[X * Y * Z];

    // assign values to allocated memory
    for (int i = 0; i < X; i++)
        for (int j = 0; j < Y; j++)
            for (int k = 0; k < Z; k++)
                *(A + i*Y*Z + j*Z + k) = rand() % 100;

    // print the 3D array
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            for (int k = 0; k < Z; k++)
                std::cout << *(A + i*Y*Z + j*Z + k) << " ";

            std::cout << std::endl;
        }
        std::cout << std::endl;
    }

    // deallocate memory
    delete[] A;
}
