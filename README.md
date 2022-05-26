# AngryBirdsGame


  ![angrybirdsmovie](https://user-images.githubusercontent.com/52263061/170590425-589896b4-7ddc-4621-a1da-97608df2b964.jpg)
  
  Basically, the game series focuses on a flock of birds referred to by the same name who try to save their eggs from green-colored pigs. Inspired by the game Crush the Castle🏠, the game has been praised for its successful combination of fun gameplay, comical style, and low price. Its popularity led to many spin-offs, versions of Angry Birds created for PCs and video game consoles, a market for merchandise featuring its characters, Angry Birds Toons, a televised animated series, and two films; The Angry Birds Movie and its sequel The Angry Birds Movie 2. By January 2014, there had been over 2 billion downloads across all platforms 😎, including both regular and special editions
  
  
  If you are one of the people who like to learn through videos 😉, you can follow the explanation through a quick video on YouTube 👉

  The First Part: 
  
  <div align="center">
      <a href="https://www.youtube.com/watch?v=ioG6H5dCyKI&ab_channel=OhMyCode">
     <img 
      src="https://user-images.githubusercontent.com/52263061/170590425-589896b4-7ddc-4621-a1da-97608df2b964.jpg" 
      alt="Everything Is AWESOME" 
      style="width:100%;">
      </a>
    </div>
 
 
 The Second Part:
 <div align="center">
      <a href="https://www.youtube.com/watch?v=F1ENgt4uxqI&ab_channel=OhMyCode">
     <img 
      src="https://user-images.githubusercontent.com/52263061/170590425-589896b4-7ddc-4621-a1da-97608df2b964.jpg" 
      alt="Everything Is AWESOME" 
      style="width:100%;">
      </a>
    </div>
    
    In this article, we will create the Angry Birds game using unity 2d and some scripts using C# by following these steps 👉:
create a new game on Unity Hub and name it whatever you want (in our example it will be Angry Birds) 
on your browser let's search for opengameart.org to choose the appropriate bird images for our game, in the search bar type a bird and choose this one Link, download the package on your machine then move the images inside to the project on the Assets folder
select all the images together and grab them to the Scene in order for animation then rename it to Green Bird.

one Link, download it then move it to the Assets folder on the project, drag the background to the Scene and make sure that the Background Order in layer property is set to Zero, then allocate the bird on the left of the background and make it smaller.
Now select the Green Bird animation on the Hierarchy and add a Rigidbody 2d component in order to make the Bird full down.
Select the Background on the Hierarchy and add a BoxCollider 2D component, on the Inspector below the BoxCollider 2D click on Edit Collider then make the collider touch the grass line on the background (in order to make the bird full down on the grass line).
Then select the Green Bird animation on the Hierarchy again and add a Polygon Collider 2D component to take the bird's shape and make collide with the grass line when full down.

Now let's play with the bird a little by changing the bird's color when we click on it, to do that we have to create a C# script, firstly let's create a new folder and name it Scripts open it and by clicking the mouse left button create > c# script, name it to bird then open the  script with visual studio, add the following code to your bird script :

![Capture](https://user-images.githubusercontent.com/52263061/170591620-24e8ec81-be92-4bb0-813a-b850e0cc36e4.PNG)


[Copy the code from here](https://rextester.com/TGJUH78356)

Then let's move to the next step by dragging the bird which is easy by adding a Drag method to the Bird script, so let's do that by adding the OnMouseDrag method so the code should look like this:

![d](https://user-images.githubusercontent.com/52263061/170591866-caf443e0-2319-4531-b9f9-f6bfcd17b0c9.PNG)


[Copy the code from here](https://rextester.com/RCFL19573)

Then let's make the bird fly by adding the following code:

![dd](https://user-images.githubusercontent.com/52263061/170592089-a5ee8ad4-0947-47d8-bf8c-4deb290dea59.PNG)

[Copy the code from here](https://rextester.com/HXJQ93491)


 Now we will add some more restrictions to the code in order to restart the game when the bird flies out of the specified coordinates by adding the Update method:
 
 ![ss](https://user-images.githubusercontent.com/52263061/170592230-9410a619-6d48-422c-a864-e47cd115c909.PNG)\
 
 [Copy the code from here](https://rextester.com/MCGSW56947)



I hope that was easy and clear to read more 😁, you can follow me on :|


[Twitter](https://twitter.com/AhmadAk86120125)
[Medium](https://medium.com/@ahmadakell)

