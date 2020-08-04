# PassGen
Password generator based off name + seed (with GUI)

Password generator written in C#, featuring a GUI. This is my first C# project.

I'm not a cryptographic expert, so the actual "randomness" and "security" of the passwords from this generator is unknown.

This app generates passwords from a name, a seed, and a number of chars. As long as these are the same, it will re-create the exact same password any number of times it is run (as those 3 create the seed for the random number generator, and thus, the password).

The big benefit of this is that if the user forgets their password, they can simply re-enter the credentials (the name, seed, and char count) and they will get the exact same password back (since the seed of the random num gen is the same).

For example, I want to create a password for Facebook, my seed is Cookie, and I keep it at 10 chars. I enter the creds, and get "CbjhehZyrD" as the password.
If I ever forget the password, I can re-enter the creds that created that same password (Facebook, Cookie, 10 chars), and regenerate the password perfectly. 

The generator natively has at least one of the following characters: Uppercase letter, lowercase letter, number, and "special character" (right now, ! and ?). Most passwords, from what I've seen, have these requirements.
