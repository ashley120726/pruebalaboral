/*Este repositorio contiene un sistema que emula una to do list, creado utilizando Blazor y lenguaje de programacion C#

Explicación
1. El sistema muestra una lista de tareas pendientes en donde se observan las tareas que han sido completadas y las que aun quedan pendientes.
2. Es posible añadir tareas a la lista, pero estas tareas no fueron posibles mostrarlas en la interfaz por choques con el espacio limite del archivo Json
3. La descripcion de las tareas se solicito que fueran editables, se confecciono el input para editar pero no se logro realizar el cambio en el api externo por un choque en cuanto a solicitudes con la api
Ejemplo del mensaje en consola:
   ID de la tarea a editar: 1
   URL de la solicitud PUT: https://dummyjson.com/todos/id:1
   JSON enviado: {"id":1,"todo":"Hola Mundo"}
   Respuesta del servidor: {"message":"Todo with id '1' not found"}
   Error al actualizar la tarea. Código de estado: NotFound
4. El sistema permite eliminar tareas
5. El sistema permite filtrar los estados de cada tarea entre completadas y pendientes
6. El sistema permite hacer check a una tarea y esta pasa de pendiente a completa inmediatamente

