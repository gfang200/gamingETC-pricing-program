##testLine = "Devils' Playground~Shadows over Innistrad~1"
def cleanInput(line):
    output = line.replace("'","").replace(",","").replace("-"," ")
    return output

##print cleanInput(testLine)

currentFile="cardLists/mtgStocks.txt"
    
