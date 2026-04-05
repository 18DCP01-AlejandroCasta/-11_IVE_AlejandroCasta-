Algoritmo act3_lecc7
	Escribir "===ACTIVIDAD 3 LECCION 7==="
	Definir dia, mes Como Entero
	
	Escribir "Ingrese el día :"
    Leer dia
    Escribir "Ingrese el mes :"
    Leer mes
	
	Si (mes = 3 y dia >= 21) O (mes = 4) O (mes = 5) O (mes = 6 Y dia <= 20) Entonces
        Escribir "Primavera"
    Sino
        Si (mes = 6 Y dia >= 21) O (mes = 7) O (mes = 8) O (mes = 9 Y dia <= 22) Entonces
            Escribir "Verano"
        Sino
            Si (mes = 9 Y dia >= 23) O (mes = 10) O (mes = 11) O (mes = 12 Y dia <= 20) Entonces
                Escribir "Otoño"
            Sino
                Escribir "Invierno"
            FinSi
        FinSi
    FinSi
FinAlgoritmo
