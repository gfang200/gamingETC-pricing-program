import urllib
import re

stocks = urllib.urlopen("http://www.mtgstocks.com/interests")
stockRead=stocks.read()
##print stockRead

#don't change
importFile = "CardLists/case sheet.txt"

stockRead= stockRead.split("last week")[0]

##stockReadList = stockRead.split('"screenshot"')



##for stock in stockReadList:
##    if "%" in stock:
##	print stock.split(">")[1].replace("&#39;","'")[:-3]
##	print stock
##	print

stockRead2 = stockRead.split("<tbody")[1].split("</table")[0]

stockReadList=stockRead2.split("<tr>")

mtgInterests=[]

for stock in stockReadList:
    if "td" in stock:
        currentCard = []
        current = stock.split("</tr>")[0].replace("&#39;","'")

##        print current
##        print
        currentCard.append(current.split(">")[2].split("<")[0])
##        print current
        if "small" in current.split(">")[8].split("<")[1]:
            currentCard.append(current.split(">")[14].split("<")[0])
        else:
            currentCard.append(current.split(">")[8].split("<")[0])

        mtgInterests.append(currentCard)

currentSet=open(importFile).readlines()
##print currentSet

currentSetInterests = []

for piece in currentSet:
    currentSetInterests.append(piece.strip().split("~"))

##print currentSetInterests
cardsHighlight = []

for card in mtgInterests:
    for piece in currentSetInterests:
        if card[0] == piece[0] and card[1] == piece[1]:
            cardsHighlight.append(piece)

##print cardsHighlight


outputFile = open("cardLists/mtgStocks.txt","w")
for card in cardsHighlight:
    outputFile.write(card[0]+"~"+card[1]+"~"+card[2]+"\n")

outputFile.close()


##    for each in  
##    pass        
##        print current
##        nameSet = re.findall(">[A-Za-z:0-9',(). ]+<",current)
##        if len(nameSet)!=2:
##            print nameSet
##            print current
##            print
