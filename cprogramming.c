#include <stdio.h>
#include<conio.h>

void main()
{
    int year;
    printf("%d",&year);
    scanf("%d",&year);


    if(year%4==0){
        if(year%100==0){
            if(year%400==0){
                printf("Its  leap year");

            }
        }else
        printf("its not century leap yaer");
    }
    else
    printf("its not leap yaer")
}

return 0;


