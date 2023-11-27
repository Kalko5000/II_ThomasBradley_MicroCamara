# Interfaces Inteligentes - Practica 08: Micrófono y Cámara

- Autor: Thomas Edward Bradley  
- Fecha: 27/11/23  

## Resumen  
Primera practica que trata sobre el uso de perifericos que captan imagenes y sonidos, con implementación de estas dentro de escenas.     

## Ejemplo de Ejecución
[Video Unlisted con ejecución](https://youtu.be/DFNjNrwlETM)  

## Tarea 01  
***Scripts:*** playAudio.cs  
Cuando ocurre una colisión, revisamos si fue contra un objeto con el tag "Spider", si este es el caso hacemos Play() sobre el AudioSource almacenado en el propio objeto.  

## Tarea 02  
***Scripts:*** recorder.cs  
Inicializamos un AudioSource sound para almacenar el audio del micrófono y un bool start para verificar en que estado estamos al darle a la tecla 'R'. Ahora empezamos a grabar el micrófono (en este caso lo hago con una duración de 7 segundos), lo guardamos en sound y le avisamos al usuario sobre lo ocurrido. Ahora cuando pulse 'R', dependiendo del estado de start, se pondra Play() al clip o se anulara el microfono y se volverá a comenzar la grabación.  

## Tarea 03  
***Scripts:*** screen.cs  
Creamos un objeto WebCamTexture y lo inicializamos, ahora metemos en un Material screenMaterial el material asignado al objeto al que va ligado el script. Si el usuario le da a la tecla 'S' se pone el texture de este material al mismo que tiene el WebCamTexture (y webcam en Play()) y en el caso de que presione 'P', el sistema pondra la textura a null, devolviendolo a su estado inicial (y webcam en Stop()). No consegui hacer los fotogramas.  

## Tarea 04  
***Scripts:*** screen.cs  
Agregamos la línea de código 'Debug.Log(WebCamTexture.devices[0].name);', lo que devuelve el primer dispositivo en la lista de webcams conectados al dispositivo y lo imprime por consola, al principio de la función Start().  

## Tarea 05  
No logre integrar grabación de fotogramas, por lo que no llegue al paso de guardarlas.  