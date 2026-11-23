# Naves-2D
Juego de naves 2D en Unity 6 de una nave, dispara con cooldown y destruye enemigos antes de que lleguen abajo. Incluye versión básica y versión avanzada con sprites, VFX y sonido.

## Escenas

- `SampleScene`: versión básica, donde solo están los Prefabs hechos con Sprites.
- `BattleShip`: versión avanzada con Sprites importados desde Unity Assets Store, fondo con estrellas a partir de un scrit que solo dibuja una textura, explosiones VFX y sonido.

## Controles

- Flechas / A-D: para mover la nave solo eje horizontal.
- Espacio: disparar con cooldown de 0.2 s.

## Funcionamiento

- Los enemigos aparecen arriba en una X aleatoria por corrutina y bajan.
- Bala y enemigo se destruyen al colisionar y sumas puntos.
- Si un enemigo llega a la parte inferior: Game Over y botón "Jugar de nuevo".

## Scripts

PlayerController, Bullet/BulletAvanzada, EnemyController, EnemySpawner,
GameManager, AudioManager, GameVFX, BackgroundScroller, CreateStarfield.

## Trabajo realizado por 

- Angeleau Pierre Jeudi ---> Enlace al Blog: [https://anpije.github.io/Naves-2D/]
- Ejecutable: Descargar la build: [(https://github.com/Anpije/Naves-2D/releases/latest)]
