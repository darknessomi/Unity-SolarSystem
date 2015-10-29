Solar System made in Unity
======================

![](http://omi-blog.qiniudn.com/static/uploads/editor/1442505972.png)
![](http://omi-blog.qiniudn.com/static/uploads/editor/1446133056.png)

### Keyboard Entry
1. W.A.S.D. R.F
2. Esc F1

### VR Support

1. Cardboard May 2015 
2. Cardboard Jun 2014
3. Google Tech C1


### about
I tried to make an explorable solar system, as accurate as possible.

What's in here:
* The Sun
* The eight planets that orbit around it. Sorry Pluto, but you're too eccentric (read below about eccentricity), so I'm going to adapt the recent decision of you not being a planet.

I tried to recreate to recreate the Solar System the best way possible. Each planet orbits around the sun, and rotates around its axis.

What's accurate:
* The relationship between the size of each planet and the Sun (all sizes are in the same scale).
* The relationship between the distance of the planets towards the Sun (all distances are in the same scale).
* The relationship between the rotation period of each planet.
* The relationship between the orbit time of each planet around the Sun.

What's so-so:
* Each planet's orbit has an inclination relative to Earth's orbit according to accurate data. I added this inclination only in one axis, without knowing if it's the right one (or if it is a combination of both).

What's not accurate:
* The size of the planets/Sun and the distance between them are in a different scale. I wanted to be more real, but that would have meant A LOT (really too much) of distance between planets. Right now, the distance between planets/Sun is 50 times smaller. I mean, planets are 50 times closer than they should be, compared to their size (or planets and Sun are 50 bigger than they should be according to their separation).
* I didn't take into account the eccentricity of the orbits. So planets have perfect circle orbits around the Sun. The math to do that was too difficult. This is not too terrible because for all Planets (except Pluto) eccentricity is close to 0.
* The time scale between the orbit speeds and the rotation speeds are not the same. That is because I used different methods to deal with orbit and with rotation (using cos and sin in the former and rotate in the later), and the calculation to make them the same was too much for me at this time.
* I didn't add axis inclination to planets.
* Sun doesn't rotate (some parts rotate but it's more to give a visual effect of solar flares and energy than proper rotation).