##import gdata.docs.service
##import gdata.gauth
##import gdata.spreadsheets.client
import gspread
##from oauth2client.client import SignedJwtAssertionCredentials
##import oauth2client.client
##import oauth2client
from oauth2client.service_account import ServiceAccountCredentials
import json

##credentials = gdata.gauth.OAuth2Token(client_id = '280266354018-1v16tml5e3483jhlk7invaadi5jprk1p.apps.googleusercontent.com',
##                                          client_secret = 'xL4VWLpMmcGVCBKI_GtFp39I',
##                                          scope = 'https://www.google.com/m8/feeds/',
##                                          user_agent = None, # This is from the headers sent to google when getting your access token (they don't return it)
##                                          access_token = None,
##                                          refresh_token = None)

##client = gdata.docs.service.DocsService()
####client.ClientLogin('280266354018-1v16tml5e3483jhlk7invaadi5jprk1p.apps.googleusercontent.com','xL4VWLpMmcGVCBKI_GtFp39I')
##
##credentials.authorize(client)
##

##client.
##
##credentials = SignedJwt....

##token = gdata.gauth.OAuth2TokenFromCredentials(credentials)
##client = gdata.spreadsheets.client.SpreadsheetsClient()
##client = token.authorize(client)
##
##feed = client.get_spreadsheets()
##print feed

##json_key = json.load(open("GamingETCpricing-94a6ac17df21.json"))
scope = ['https://spreadsheets.google.com/feeds']

credentials = ServiceAccountCredentials.from_json_keyfile_name('GamingETCpricing-94a6ac17df21.json', scope)


gc = gspread.authorize(credentials)

wks = gc.open("Cases").sheet1

valuesList = wks.col_values(10)

cleanValuesList = [line for line in valuesList if (len(line)>1 and line!="USE WITH PROGRAM")]

caseSheetFile = open("CardLists/case sheet.txt","w")

finalLine = ""

for line in cleanValuesList:
    finalLine += line+"\n"

caseSheetFile.write(finalLine[:-1])

caseSheetFile.close()


##sh = gc.open_by_key("1sIR6Z6XNbCCh78s5QbmJL8HhAPVNmFRw2qpAojPOoyo")

##worksheet_list = sh.worksheets()

##credentials.authorize(client)
##documents_feed = client.GetSpreadsheets()

