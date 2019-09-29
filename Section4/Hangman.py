import random
words = ["apple", "leaves", "geese", "bananas", "submarines"]

chosenWord = words[random.randint(0, len(words) - 1)]
encryptedWord = "*" * len(chosenWord)

print("Welcome to HANGMAN!")
print("A word has been chosen at random")
print("It is " + str(len(chosenWord)) + " characters long")
print("Let's play!")

chosenWordLetters = list(chosenWord)
encryptedWordLetters = list(encryptedWord)
counter = 0
while (chosenWordLetters != encryptedWordLetters):
    guess = input("Enter a letter to guess:")
    for i, letter in enumerate(chosenWordLetters):
        if letter == guess:
            encryptedWordLetters[i] = guess
            print(encryptedWordLetters)
            if (chosenWordLetters == encryptedWordLetters):
                print("Correct! The word is " + chosenWord)
    if (guess not in chosenWordLetters):
        print("Letter not in word!")
        counter += 1
    if (counter > 8):
        print("Out of guesses! The word was " + chosenWord)
        break;