# UI
### Cambios realizados

- He creado un nuevo UI canvas llamado "UI Enemies" desde el apartado XR, lo cual me ha puesto el render mode a "World Space" por defecto. Lo he escalado a un tamaño ideal para que pueda interactuar el usuario con él. He añadido un componente "Image" y le he dado un color negro semitransparente.
- Dentro del canvas he añadido un texto como título de este nuevo panel creado un botón de TextMeshPro y he escogido los colores para los diferentes estados, "normal", "pressed", etc.
- Dentro del botón he creado un hijo "Image" con una imagen y "Show Mask Graphic" a true. Luego como hijo de este he añadido texto para el botón escogiendo fuente, color, y tamaño. En el "Target Graphic" del botón he usado el hijo "Image". He añadido el componente "XR Poke Follow Affordance" dentro del botón y como "Poke follow transform" he usado el hijo "image" con un max distance a "20".
- He reciclado el Spawner y el script, quitando cosas que no voy a usar como el slider. Ahora tengo mi EnemySpawner objeto y script. 
- Al botón del canvas he añadido en el On Click el EnemySpawner y he selecionado la función "SpawnEnemy".
- Busqué un asset que ya venía con sus correspondientes animaciones en el asset store, un esqueleto para hacer de enemigo. 
- Configuré un nuevo Animation Controller "EnemyController" y arrastré las animaciones de "idle", "walking" y "attacking". 
- Creé dos variables, "isWalking" y "isAttacking" y los asigné a la transiciones correspondientes entre cada estado.
- He creado un script "Enemy" donde le hice mirar el jugador (cámara) y moverse hácia él, poniendo "isWalking" a true para mostrar la animación de caminar. Establecí un rango de ataque para que cuando estuviera dentro de ese rango el jugador es atacado, mostrando la animación mediente "isAttacking" a true y "isWalking" a false.