//Programa que muestre un mensaje de voz
//Crear menu
Algoritmo mensajedvoz
	Escribir "===MENSAJE DE VOZ==="
	//Variables
	Definir opc Como Entero
	//Menu
	Escribir "Menu principal"
	Escribir "1- Recepcion"
	Escribir "2- Vigilancia"
	Escribir "3- Mantenimiento"
	Escribir "4- Salir"
	Escribir Sin Saltar "Digite una opcion:"
	Leer opc
	//Condiciones
	si (opc == 1) Entonces
		Escribir "Bienvenido al dep. de Recepción."
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	si (opc == 2) Entonces
		Escribir "Bienvenido al dep. de Vigilancia."
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	si (opc == 3) Entonces
		Escribir "Bienvenido al dep. de Mantenimiento."
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	si (opc <> 1 y opc<>2 y opc<>3) Entonces
		Escribir "Saliendo del sistema..."
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	
	
	
FinAlgoritmo
