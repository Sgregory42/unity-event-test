# unity-event-registry
 
A simple example of using unity scriptable object as a registry for events.

The scene has 
- 2 cubes (one red, one white) -> publish events
- 2 listeners (an example UIAnimation System, SomeProcessor System)

When you click on a cube it will send an event that something has changed with the name of the cube (see logs)
