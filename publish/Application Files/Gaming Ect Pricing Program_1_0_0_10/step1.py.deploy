from tools import *

inputFile = open(currentFile,"r").readlines()

lineBreak = [line.strip().split("~") for line in inputFile if len(line.strip().split("~")[1])!=0]

ahkFile = []
caseFile = []

for card in lineBreak:
    ahkFile.append((cleanInput(card[0]),cleanInput(card[1])))
    caseFile.append((card[0],card[2],card[1]))
    

buyList = open("buyList.csv","w")
casePrice = open("case prices.csv","w")

for i in range(len(ahkFile)):
    buyList.write(ahkFile[i][0]+","+ahkFile[i][1]+"\n")
    casePrice.write(caseFile[i][0]+"~"+caseFile[i][1]+"~"+caseFile[i][2]+"\n")

buyList.close()
casePrice.close()
