import json

sets = open('AllSets.json')
setsRead = sets.read()
setData = json.loads(setsRead)

#never change this line
searchSet ="Rise of the Eldrazi"

savedSet = open("cardLists/"+searchSet+".txt","w")

for sets in setData.keys():
    if setData[sets]["name"].encode("utf-8")==searchSet:
        for card in setData[sets]["cards"]:
            savedSet.write(card["name"]+"~"+searchSet+"~"+"0"+"\n")

savedSet.close()
            




