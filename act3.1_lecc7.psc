Algoritmo act3_lecc7
	Escribir "===ACTIVIDAD 3.1 LECCION 7==="
	Definir l1, l2, l3 Como Real
	
	Escribir "Ingrese el lado 1 del triangulo"
	Leer l1
	Escribir "Ingrese el lado 2 del triangulo"
	Leer l2
	Escribir "Ingrese el lado 3 del triangulo"
	Leer l3
	
	si (l1 == l2 y l1 == l3) Entonces
		Escribir "El triangulo es equilatero"
	FinSi
	si (l1 == l2 y l1 <> l3) Entonces
		Escribir "Es un triangulo isosceles"
	FinSi
	si (l1 <> l2 y l1 <> l3) Entonces
		Escribir "Es un triangulo escaleno"
	FinSi
	
FinAlgoritmo
