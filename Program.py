running = True
print("give me number")
while running:
    number = input()
    if number == "stop":
        running = False
    try:
        int(number)
    except:
        print("not integer, try again")
        continue
    intnumber = int(number)
    looping = True
    while looping:
        if intnumber % 2 == 0:
            intnumber /=2
        else:
            intnumber *=3
            intnumber +=1
        print(int(intnumber))
        if intnumber == 1:
            print("infinite loop. gimme again")
            looping = False
