
//// structure 

#include<stdio.h>
struct student{no.;

  int rno;
  char name[50];
  float per;



}s[50];
void main(){
    
 int i,size;
    
 printf("enter no. of student  :");
 scanf("%d", &size);
 for(i=0;i<size;i++){
     printf("enter %d student details\n"i+1);
     printf("enter roll no :");
     
     scanf("%d",s[i].rno);
     
     printf("enter student percentage");
     scanf("%f" &s[i].per);
        getchar();
     
     printf("enter student name : ");
     scanf("%s",s[i].name);
     
    }
    for(i=0;i<size;i++){
        printf("%d\t%s\t%.2f\n", s[i].rno,s[i].name,s[i].per);
    }
 
}
     
     
     
 }

 printf("enter name :");
 scanf("%s",s.name);


 printf("enter roll no :");
 scanf("%d",s.rno);

 printf("enter percentage :");
 scanf("%f",s.per);


 printf("%s\t%d\t%.2f\n",s.name,s.rno,s.per);
    
}




