# LocomotionSimple
### Cambios realizados

- He creado un gameobject vacío y lo he nombrado "Teleport Anchor Cube". He adjuntado el componente "Teleportation Anchor" y en su "Interaction Layer Mask" lo he puesto a "Teleport".
- Luego como hijo he añadido un cubo para la parte visual y le he añadido un color a través de un material. He puesto "isTrigger" a true en el box collider de este objeto.
- He creado otro hijo vacío y le he adjuntado el componente "XR Interactable Snap Volume". Dentro de este he puesto el Cubo como el "Snap Collider" y he deshabilitado la opción "DisableSnapColliderWhenSelected".
- He convertido mi objeto en prefab para poder reutilizarlo por la escena creando así cubos para "saltar" de uno a otro.
- He añadido al mundo un texto indicando por donde tiene que ir el usuario en forma de cartel.
- He creado una plataforma la cual es la meta final y le he aplicado un "Teleportation Area" y el "Interaction Layer Mask" a "teleport".