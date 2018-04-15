import json

sets = open('AllSets.json')
setsRead = sets.read()
setData = json.loads(setsRead)

newFile = open("setList.txt","w")

for sets in setData.keys():
    newFile.write(setData[sets]["name"].encode("utf-8")+"\n")

newFile.close()



