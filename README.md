1. What happened

I am trying to configure a unityevent with two actions where each point to a different instance of the same monobehaviour in the same gameobject but only the first monobehaviour is configured (I drag carefully the correct monobehaviuor as the target for each action)

2. How we can reproduce it using the example you attached

1)Open the TestScene
2)there are two gameobjects named Broken and Fixed
3)if you use the context menu execute option in the invoker script it will
    print 
    
   for the broken prefab
      First - 1
      First - 2

   and in the fixed prefab

     First - 1
     Second - 2

the broken prefab is made by dragging carefully each monobehaviour over each action
the fixed prefab is made by manually editting the serialized prefab data to point at the correct instance of the monobehaviour

I tested this on 

2017.1.0p5
2017.2.0p1
2017.3.0b9

and the same thing happens in all of them
