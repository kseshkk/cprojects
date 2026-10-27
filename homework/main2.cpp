#include <iostream>
#include <windows.h>

using namespace std;

int main() {

    SetConsoleCP(65001);
    SetConsoleOutputCP(65001);

    int price;
    int count;
    int total;
    int discount;


    printf("Введите цену товара: ");
    scanf("%d", &price);

    printf("Введите количество товаров: ");
    scanf("%d", &count);

    total = price * count;
    printf("Стоимость покупки: %d рублей\n", total);

    if (total >= 3000) {
        discount = total * 10 / 100;
        total = total - discount;
        printf("Вы получили скидку %d рублей\n", discount);
    }
    else {
        printf("Скидки нет\n");
    }

    return 0;
}

