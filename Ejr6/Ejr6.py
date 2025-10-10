dolar=3.78
euro=4.20

def conversión_dolar():
    return soles/dolar

def conversión_euro():
    return soles/euro

while True:
    soles=float(input("Ingrese el monto en soles:"))

    print("1.Convertir a dolares")
    print("2.Convertir a euros")
    print("3.Salir")

    opción=int(input("\nIngrese una opción: "))

    match opción:
        case 1:print("\nEl monto en dólares:",round(conversión_dolar()))
        case 2:print("\nEl monto en euros:",round(conversión_euro()))
        case 3:exit()
        case _:print("\nOpción no válida")

    continuar=input("\n¿Desea continuar? presione(y):")

    if continuar != "y": #no es igual a !=y
        break