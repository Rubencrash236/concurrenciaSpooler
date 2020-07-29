# concurrenciaSpooler

Tarea simple de Lenguajes de programación 
# *A realizar:*
En un centro de cálculo se cuenta con dos tipos distintos de impresoras para dar servicio a los usuarios: impresoras de tipo
A e impresoras de tipo B. Obviamente, el número de impresoras de cada tipo es limitado: NumA impresoras de tipo A y
NumB impresoras de tipo B, numeradas desde 1 hasta NumA o NumB según corresponda.
Para imprimir un trabajo en una impresora de tipo A es necesario ejecutar la operación con cabecera1
:
type Tipo_Impresora_A is Natural range 1..NumA;
procedure Imprimir_A(Num: in Tipo_Impresora_A; Trabajo: in TipoTrabajo);
Mientras que para imprimir en una de tipo B se utiliza:
type Tipo_Impresora_B is Natural range 1..NumB;
procedure Imprimir_B(Num: in Tipo_Impresora_B; Trabajo: in TipoTrabajo);
A la hora de imprimir los trabajos podemos considerar tres grupos distintos de procesos:
1. Los que requieren una impresora de tipo A.
2. Los que requieren una impresora de tipo B.
3. Los que pueden utilizar una impresora de uno cualquiera de los dos tipos.
La labor de los procesos es generar trabajos (Generar Trabajo) e imprimirlos. Como restricción tenemos que dos procesos
no pueden ejecutar simultáneamente las operaciones de impresión (Imprimir_A o Imprimir_B) sobre una misma impresora.
De esta forma cuando un proceso quiera imprimir un trabajo deberá hacerlo sobre una impresora compatible con él y que
no esté siendo utilizada por otro proceso. En otro caso el proceso deberá esperar.
