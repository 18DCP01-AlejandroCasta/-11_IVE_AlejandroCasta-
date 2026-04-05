Algoritmo act2_lecc7
	Escribir "===ACTIVIDAD 2 LECCION 7==="
	Definir n Como Real
	
	Escribir "Digite una nota: "
	Leer n
	
	Si (n >= 0 y n <= 60) Entonces
		Escribir "Deficiente"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	Si (n >= 60 y n <= 70) Entonces
		Escribir "Regular"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	Si (n >= 70 y n <= 80) Entonces
		Escribir "Bien"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	Si (n >= 80 y n <= 90) Entonces
		Escribir "Muy Bien"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	Si (n >= 90 y n <= 100) Entonces
		Escribir "Excelente"
	SiNo
		Escribir "Digite un num del 0 al 100"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
FinAlgoritmo
