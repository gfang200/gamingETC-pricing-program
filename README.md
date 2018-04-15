Case Study: MTG Pricing Program
============
The MTG Pricing Program is an end to end business solution I built for a local game store over a 2 month engagement in 2016. The goal of the end product was to help her optimize the daily re-pricing of an inventory of over 10,000 unique cards, collectively worth over $100,000.

Problem Statement
--------------- 
Magic the Gathering© is a trading card game that has been operated by Wizards of the Coast© since 1993. Since it's inception, over 12,000 unique cards have been printed, played and sold. Similar to a stock market, the value of these cards fluctuates daily based on the 'meta' (which cards are currently popular) and 'rarity' (the volume of cards in existance). Unlike stocks, which have transitioned to a digital asset in the 21st century, Magic the Gathering© cards still exist primarily as a physical asset.<br/>

This presents a unique challenge to local game stores, brick and mortar locations who make their primary margins by optimizing the transaction between players looking to sell their old cards and players looking to buy new cards. Since Magic© cards are bought and sold as physical goods in a fluctuating price market, having up to date pricing on the trading cards is crucial to operating a successful business.<br/>

Gaming ETC© is one of the top 10 biggest local game store's in the world, with an inventory of over 10,000 unique cards, collectively worth over $100,000 in market value. A significant portion of this market value is contained within the top 200 cards, sometimes valued at up to $10,000 for a single card. These cards, making the highest margins for the owner, are displayed in cases with clearly marked price tags. Once a customer declares intent to purchase one of these cards at the marked price, it is difficult to change the price without creating a poor customer experience. <br/>

Since the prices for these large ticket cards are often the most volatile to price movements, there is a real business need to always have to most up to date market prices for cards.

The Current Solution
--------------- 
Use word of mouth, news of large price movements, and community events to determine featured cards that need repricing.<br/>

This strategy is extremely weak against small price movements over time, and risks exposure to price fluctuations that are significant in dollar value, but not relative value to the original price.

The Proposal
--------------- 
Use web scraping technology and market analytics to determine the fair market value of the top 200 cards in real time. Move from pull to push notification on price changes, enabling fast response on a change of value.

The Challenge
--------------- 
As a physical first asset, the market data for these cards is considered a commodity. Companies that hold this data have a competitive advantage by optimizing prices on the market value of these cards. Due to this, several preventative measures have been employed by these companies to protect this data. <br/>

The largest, and most reputable of these data holding companies, www.tcgplayer.com, contracts Distil Networks© (https://www.distilnetworks.com/) to prevent bots from scraping their website. Their methods involve the following:
* Captchas
* Javascript injections
* Header request analysis
* Browser validation
* Digital fingerprinting

In the past, Gaming ETC© has tried (unsuccessfully) to scrape the Tcgplayer© website using conventional techniques. (urllib, selenium, api requests, etc)

The Solution
--------------- 
Custom designed software utilizing the COM (Component Object Model) design of Microsoft applications (Internet Explorer in this case) in order to inject scripts into Windows that then interface with the application. These script injections allow the automated browsing of web pages in a manner completely indistinguishable from regular browsing. The script never interfaces with TCGplayer.com or the acting browser, thus evades all data scraping prevention measures.

The Implementation (Core Stack)
--------------- 
#### gdata.py ####
Gdata.py is responsible for interfacing with the main database system used by Gaming ETC (Google Sheets). It pulls data of current in-store card prices which will be compared with new scraped prices in order to identify cards with a high delta in value.
#### step1.py ####
Step 1 cleans the list of cards pulled by gdata.py and provides an output that can be consumed by the scraping engine.
#### step2.ahk ####
Step 2 is where the 'magic' happens. Using the object, ComObjCreate("InternetExplorer.Application"), we can interact directly with the component object model of the internet explorer. Since AHK is a scripting language, we don't bother trying to parse the HTML at this step, we just record the whole thing. Most importantly, we hide the browser, but when the script is inevitably presented with a captcha for speed or volume, we will unhide the browser and present the user with an alert to complete the captcha challenge to continue.
#### step3.py ####
Use regular expressions to extract the appropriate data. Generate a dynamic HTML page to present the insights and recommendations to the user.
#### User Experience/Interface ####
The user interface is a desktop executable built in VBA. You can learn more about how to use the product and the different features by looking at the direction manual, "GamingETC Pricing Program Manual 2016".
