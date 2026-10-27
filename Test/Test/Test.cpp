#include <iostream>
#include <windows.h>

using namespace std;

int main() {
    // Показываем диалоговое окно с текстом
    MessageBoxW(
        NULL,                   // родительское окно (нет)
        L"Привет! Это простое окошко из консольной программы.",
        L"Не троян",       // заголовок окна
        MB_OK | MB_ICONINFORMATION
    );

    // Дополнительно можно что-то вывести в консоль
    printf("Окно было закрыто. Нажмите Enter для выхода...\n");
    getchar();

    return 0;
}