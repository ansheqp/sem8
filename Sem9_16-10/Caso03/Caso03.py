import random
suma=0
cantidad1=0
cantidad2=0
cantidad3=0
cantidad4=0

#Generar 15 aleatorios entre 1250 a 10000
for i in range (1,16):
    aleatorio=random.randint(1250,10000)
    print(aleatorio)

    suma+=aleatorio; #sumamos los numeros aleatorios

    if 1250<=aleatorio<=3000:
        cantidad1+=1
    elif 3001<=aleatorio<=5000:
        cantidad2+=1
    elif 5001<=aleatorio<=6999:
        cantidad3+=1
    else: #aleatorio>=7000
        cantidad4+=1

print("Suma:",suma)
print("Cantidad entre 1250 y 3000",cantidad1)
print("Cantidad entre 3001 y 5000",cantidad2)
print("Cantidad entre 5001 y 6999", cantidad3)
print("Cantidad mayor a 7000",cantidad4)





