Algoritmo act1lecc7
	Escribir "===PROMEDIO DE NOTAS==="
	Definir n1,n2,n3,n4,n5,r Como Real
	Definir m Como Caracter
	Escribir "Ingrese la materia: "
	Leer m
	Escribir "Ingrese la primera nota: "
	leer n1
	Escribir "Ingrese la segunda nota: "
	leer n2
	Escribir "Ingrese la tercera nota: "
	leer n3
	Escribir "Ingrese la cuarta nota: "
	leer n4
	Escribir "Ingrese la quinta nota: "
	leer n5
	r = (n1+n2+n3+n4+n5)/5
	Si (r>70) Entonces
		Escribir "El estudiante esta aprobado"
	SiNo
		Escribir "El estudiante esta reprobado"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	
	Escribir "El promedio es de: ", r
	Escribir "La materia es: ", m
	
FinAlgoritmo
