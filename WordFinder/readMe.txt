Consideraciones para la resolución del ejercicio:

- Se estableció el valor 64 para el número de columnas y de filas como lo especifica el problema, por eso no se usó numRows = this.matrix.Count por ejemplo.
- Si ninguna palabra es encontrada, el programa devuelve la lista de palabras con el contador en 0.
- Usamos HashSet para evitar duplicados sin tener que preocuparnos por revisar las palabras.
- Usamos dictionary para guardar las palabras y la cantidad de veces que aparecen.
- Las palabras se buscan solamente de izquierda a derecha y de arriba a abajo.
- El programa es case sensitive.
- La cantidad total (CT) que se guarda por cada palabra en el diccionario, es igual a la cantidad de veces que aparece la palabra horizontalmente (CH) mas la cantidad de veces que aparece verticalmente (CV) CT=CH+CV

-------------------------------------------------------------------------------------------------------------------------------

Considerations for solving the exercise:

- The value 64 was set for the number of columns and rows as specified in the problem, so numRows = this.matrix.Count was not used.
- If no word is found, the program returns the list of words with the counter at 0.
- I used HashSet to avoid duplicates without having to worry about checking the words.
- I used dictionary to save the words and the number of times they appear.
- Words are searched only from left to right and from top to bottom.
- Software is case sensitive.
- The total amount (CT) that is saved for each word in the dictionary is equal to the number of times the word appears horizontally (CH) plus the number of times it appears vertically (CV) CT=CH+CV