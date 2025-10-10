


def suma(a,b):
    print("\nLa suma es:",a+b)
def resta(a,b):
    print("\nLa resta es:",a-b)
def multi(a,b):
    print("\nLa multiplicación es:",a*b)
def divi(a,b):
    if b!=0: #Esto es para decir no es igual a !=0
        print("\nLa división es:",a/b)
    else:
        print("\nERROR. No se puede dividir entre 0")

while True:
    print("Bienvenidos al sistema de calculadora básica\n")
    print("1.Suma")
    print("2.Resta")
    print("3.Multiplicación")
    print("4.División")

    opción=int(input("\nIngrese una opción: "))

    a=int(input("\nIngrese el primer número : "))
    b=int(input("Ingrese el primer número : "))

    match opción:
        case 1:suma(a,b)
        case 2:resta(a,b)
        case 3:multi(a,b)
        case 4:divi(a,b)
        case _:print("\nOpción no valida")

    continuar=input("\n¿Desea continuar? presione(y):")

    if continuar != "y": #no es igual a !=y
        break