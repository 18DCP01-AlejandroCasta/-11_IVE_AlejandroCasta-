Algoritmo act4_lecc20
	Definir u, c, r Como Caracter
	
	Escribir "Ingrese su Usuario: "
	Leer u
	
	Escribir "Ingrese su Contraseña: "
	Leer c
	
	si (c <> "Password123") Entonces
		Escribir "Contraseña Incorrecta"
	FinSi
	si (c == "Password123") Entonces
		Escribir "Bienvenido"
	FinSi
	
	
FinAlgoritmo
