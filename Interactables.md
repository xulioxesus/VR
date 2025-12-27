# Interactables
### Cambios realizados

- En la primera "mesa" he creado 3 objetos y les he añadido un "XR Grab Interactable" con "Use Dynamic Attach" habilitado. También les he añadido unos collider.
- Al primer objeto he puesto el tipo de movimiento a "Kinematic", al segundo "Instantaneous", y al tercero "Velocity Tracking".

- En la segunda mesa he creado 3 botones usando cilindros de diferentes tamaños. Para cada uno tengo la base, la parte intermedia y el cabezal del botón. Un object "PokeButton" les engloba a estos y también a un objeto con box collider "PokeCollider".
- Al objeto padre que engloba todo el botón le añadí los script "XR Simple Interactable", "XR Poke Filter", y "XR Poke Follow Affordance".
- En el Poke Filter puse el objeto "Botton" (que engloba parte de en medio y cabezal del botón) como "Interactable" y el "PokeCollider" como collider. Puse la "Poke Direction" a "Negative Y".
- En el "XR Poke Follow Affordance" puse el objeto "Button" en el "Poke Follow Transform". Max Distance a 0.03 y "Clamp at Max Distance" habilitado.
- He creado otro objeto "InteractionAffordance" dentro del "PokeButton" (padre), y a ello le he añadido el script "XR Interactable Affordance State Provider" con el "PokeButton" como "Interactable Source".
- Al primer objeto PokeButton añadí un sistema de partículas, al segundo un sonido, y al tercero un canvas con un texto. En el "Interactable Events" de cada botón he vínculado el objeto correspondiente (Particle, Sonido, UI) en "Select" y "Select Exited", con la función correspondiente (Play, Stop), y en el de UI tuve que crear un script cutom con una función al cual he llamado "IncrementNumber", el cual incrementa el numero en una variable y actualiza el valor del texto del TextMeshPro. 

- Para la tercera mesa he descargado 3 objetos de "OpenGameArt.org", una linterna, una pistola, y una metralleta. 
- Les puse un "XR Grab Interactable" y un "Mesh Collider" con "Convex" habilitado. "Select Mode" a "Single" en el caso de la Pistola y a los otros dos "Multiple". "Dynamic Attach" para la linterna.
- Para la pistola creé un objeto hijo vació "Attachment Transform" y lo coloqué donde normalmente se cogería una pistola. Este objeto luego lo vínculé en el "Attach Transform". 
- Para la metralleta hice casi lo mismo pero en este caso usé dos "Attach Transform", cada uno en los grips del arma.
- "Far Attach Mode" puesto a "Near" para los tres objetos.
