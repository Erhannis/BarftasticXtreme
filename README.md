Unity game (or proof of concept).  Iron Man style flying.  Neither position nor rotation are constrained by your real play space - you can face straight ahead any your camera will do loop-de-loops.  Have a bucket handy if you're not REALLY confident in your nausea resistance.  The other candidate title is "Iron Stomach".

Make a steamvr controller binding, or your controllers probably won't do anything.  I recommend the ReversedDirectionals on your primary triggers and the Directionals on your secondary triggers (if you have them), and maybe Downs on a button pair or grip pair.

Directional provides thrust opposite the direction of the thruster, ReversedDirectional provides thrust in the OPPOSITE direction, and Down provides thrust upwards (Y+) (as though it were a thruster pointing downwards).

Tips:
If you point the thrusters so you can see it end-on, like you're looking down the shaft in either direction, there should be litte to no rotation.  Otherwise, the thrusters are applying a torque to you, and you spin (barring interaction with objects etc.).
Generally, turning off gravity and increasing drag / angular drag make it easier, doing the opposite makes it harder.
I think the force the thrusters provide is (for some reason) proportional to your FPS.  I may fix that at some point, but you can adjust the `multiplier` on the thrusters if you want.

Uh, Apache 2.0 License I guess?

-Erhannis
