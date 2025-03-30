#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(){
    int i=0;
    char  *ii;
    char s[1024]="ps2pdf  ";
    char ss[1024]="";
    char sss[1024]="  outs.pdf";
    char sss1[1024]="xdg-open outs.pdf";
    char ccc[1024]="outs.pdf";
    char ccc1[1024]="ps";
    printf("\ec\e[43;30m\ngive me a ps file to print\n");
    fgets(ss,1023,stdin);
    i=strlen(ss)-1;
    ss[i]=32;
    strcpy(ccc,s);
    ii=strstr(ccc,".");
    if (ii!=NULL) ii=0;
    strcat(s,ss);
    strcat(s,sss);
    printf("%s\n",s);
    system(s);
       
    system(sss1);
    return 0;
}