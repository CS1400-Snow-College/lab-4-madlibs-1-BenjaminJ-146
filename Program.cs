﻿// Benjamin Johnson, 2/26, Lab 4 - Mad Libs
Console.Clear();

Console.WriteLine(@"
Welcome to 'Mad Libs'
I will ask for different types of words with which I will build a funny story with.");

string originalStory = @"A vacation is when you take a trip to some (adjective) 
place with your (adjective) family. Usually, you go to some place that is near 
a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride 
(plural noun) or play (game) or go hunting for (plural noun). I like to spend my time 
(verb ending in “ing”) or (verb ending in “ing”). When parents go on a vacation, 
they spend their time eating three (plural noun) a day, and fathers play golf, and 
mothers sit around (verb ending in “ing”) Last summer, my little brother fell in a/an 
(noun) and got poison (plant) all over his (part of the body) My family is going to 
go to (place) and I will practice (verb ending in “ing”) Parents need vacations more 
than kids because parents are always very (adjective) and because they have to work 
(number) hours every day all year making enough (plural noun) to pay for the vacation.";

string[] storyWords = originalStory.Split(' ');