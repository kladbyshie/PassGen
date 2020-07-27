# PassGen
Password generator based off name + seed (with GUI)

Password generator written in C#, featuring a GUI. 
This uses a "Name" field (used for website, keywords, etc) and a "Seed" field (can be textual or numeric) to generate a combined numeric "seed" to create a random number generator, which in turn generates a password composed of lowercase, uppercase, numerics, and ?! characters, There is also a # of characters field (how many characters you want the password to be). I'm not a cryptographic expert, so the actual "randomness" and "security" of the passwords from this generator is unknown.

I wanted a way to generate passwords for websites in an easy to remember, yet secure, way, in a way where passwords can be recreated in the future if I forget them. With this, a user only needs to remember the "seed" (which can be a number, a passphrase, or anything like that), and how many characters there were in the password (10 by default). Then, the user simply inputs the website name into the Name field, inputs the seed, and inputs char count, and gets a "random password".

The big benefit of this is that if the user forgets their password, they can simply re-enter the credentials (the name, seed, and char count) and they will get the exact same password back (since the seed of the random num gen is the same).

For example, I want to create a password for Facebook, my seed is Cookie, and I keep it at 10 chars. I enter the creds, and get "CbjhehZyrD" as the password.
If I ever forget the password, I can re-enter the creds that created that same password (Facebook, Cookie, 10 chars), and regenerate the password perfectly. 
