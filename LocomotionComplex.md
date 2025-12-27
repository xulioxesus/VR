# LocomotionComplex
### Cambios realizados

- He creado una pared y techo usando cubos.
- Luego he creado una escaleras mediante cilindros y al objeto padre "Handles" he adjuntado el componenente "Climb Interactable" y he puesto la opción "Distance Calculation Mode" a "Collider Volume". En el rigidbody he congelado la posición y rotación. Le he añadido también el componente "XR Interactable Affordance State Provider".
- A cada escalón de las escaleras he añadido el componente "Color Material Property Affordance Receiver" para que cambie de color al usuario acercarse al objeto. El "Affordance State Provider" es el objeto handles, lo cual es el padre de todos los escalones. Como "Affordance Theme Datum" puse el "ColorAffordanceTheme".
- Tambien he creado un techo para colgarse, hecho de esferas y usando los mismos componentes/interacciones que las escaleras.
