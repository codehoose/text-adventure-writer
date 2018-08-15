# 2018-07-31 Day 1
_Time Spent: 2.5hrs_
Thought I'd start the adventure writer project. I was going to do a video about it, but there would be too much uhms and errs. Instead I'll plough on and develop it behind the scenes and then present it when I have things to show.

Tonight I did a first pass at the lexer, such that it is and the parser (such that _it_ is) with a dummy test program. The lexer, parser and dictionary interact with each other and so far I have directions working. So that's a good start. Off to bed now.

# 2018-08-01 August already
_Time Spent: 2.5hrs_
Not sure how many 2.5hr stints I have left in me. Today was a bit of an overhaul of the lexer / parser / syntax thing. I really should go study compiler design or something because I'm sure I've messed up the naming of some of these things.

Tonight's job was to parse out the user's entry character by character so that I could figure out when joiner phrases are used like:

```take lamp and go north```

Because in the future I might (want) to have phrases like:

```take lamp & go north```

Or even:

```take lamp&north```

All of which would take the lamp and try and head north. Once I'd gotten the tokenizer started, it's still got a long way to go because it only recognizes joiner words, not ampersands and the like, I felt like I should do some phrase analysis and finally some syntax checks. So that's what I did :)

The language spec such as it is, is now in a JSON file. This file is read in and the phrases can be validated. Anything that isn't recognized puts up a "I don't know what you mean by..." and what you typed. For tonight, deafening silence greets you when you enter a valid phrase.

# 2018-08-13 Composition
_Time Spent: 2.5hrs_
Added MEF composition. Well, started to anyway.

# 2018-08-14 Composition again
_Time Spent: 2hrs_
Trying to split the editor and runtime out to two separate DLLs. Partially working. The editor window starts up, there's nothing in it, and the console starts but nothing is visible. I'm calling tonight a fail tbh.