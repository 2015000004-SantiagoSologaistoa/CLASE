Algoritmo Lecc9_Act1_Inc1
	Definir pesoAcumulado, pesoManzana, acumulado Como Real
	pesoAcumulado=0;
	acumulado=0
	Escribir "Bascula del mercado"
	Mientras pesoAcumulado<1000 Hacer
		Escribir "Ingrese el peso de la manzana en gramos(100-300)"
		Leer pesoManzana
			Si pesoManzana>=100 y pesoManzana<=300 Entonces
				pesoAcumulado=pesoAcumulado+pesoManzana+acumulado
				Escribir  "Peso actual:", pesoAcumulado,"gramos"
				acumulado=acumulado+1
			SiNo
				Escribir "No pesa lo suficiente"
			Fin Si
		FinMientras
	Escribir "Meta alcanzada, Ya tiene:", pesoAcumulado/1000," Kilos y Esta cantidad de manzanas ",+acumulado
FinAlgoritmo
