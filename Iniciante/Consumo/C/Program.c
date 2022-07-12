#include <stdio.h>

void Consumption(int km, double gas){
	double c = km / gas;
	printf("%.3lf km/l\n", c);
}

int main(int argc, char **argv){
	int km = 0;
	double gas = 0;
	scanf("%d", &km);
	scanf("%lf", &gas);
	Consumption(km, gas);
}

