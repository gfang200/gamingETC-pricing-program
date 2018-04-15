Case Study: MTG Pricing Program
============
The MTG Pricing Program is an end to end business solution I built for small business owner, Michelle Cove, over a 2 month engagement with her business, Gaming ETC, in 2016. The goal of the end product was to help her optimize the daily re-pricing of her inventory of over 10,000 unique cards, collectively worth over $100,000.

Problem Statement
--------------- 
Magic the Gathering© is a trading card game that has been operated by Wizards of the Coast© since 1993. Since it's inception, over 12,000 unique cards have been printed, played and sold. Similar to a stock market, the value of these cards fluctuates daily based on the 'Meta' (popular cards) and 'rarity' (how many cards exist). Unlike the stock market, which has transitioned to a digital first market in the 21st century, Magic the Gathering© cards still exist primarily as a physical asset.<br/><br/>

This presents a unique challenge to local game stores, brick and mortar locations who make their primary margins by optimizing the transaction between players looking to sell their old cards, and players looking to buy new cards. Since Magic© cards are bought and sold as physical goods in a fluctuating price market, having up to date pricing on the trading cards is crucial to operating a successful business.<br/><br/>

Gaming ETC© is one of the top 10 biggest local game store's in the world, with an inventory of over 10,000 unique cards, collectively worth over $100,000 in market value. A significant portion of this market value is contained within the top 200 cards, sometimes valued at up to $10,000 for a single card. These cards, making the highest margins for the owner, are displayed in cases, with clearly marked price tags. Once a customer declares intent to purchase one of these cards at the marked price, it is difficult to change the price without creating a poor customer experience. <br/><br/>

Since the prices for these large ticket cards are often times the most volatile to price movements and make up the most margins, there is a real business need to always have to most up to date market price for these cards.

The Current Solution
--------------- 
Use word of mouth, news of large price movements, and community events to determine featured cards that need repricing.<br/><br/>

This strategy is extremely weak against small price movements over time, and risks exposure to price fluctuations that are significant in dollar value, but not relative value to the original price.

The Ideal Solution
--------------- 
Use web scraping technology and market analytics to determine the fair market value of the top 200 cards in real time. Move from pull notification to push notification on price changes to enable fast response on a change of either relative value or absolute value.

The Challenge
--------------- 
As a physical first asset, the market data for these cards is considered a commodity. Companies that hold this data have a real competitive advantage as the actor who can best optimize on the market value of these cards. Due to this, several preventative measures have been employed by these companies to protect their data and their market position. <br/><br/>

The largest, and most reputable of these data holding companies, www.tcgplayer.com, contracts Distil Networks (https://www.distilnetworks.com/) to prevent bots from scraping their website. Their methods involve the following:
* Captchas
* Javascript injections
* Header request analysis
* Browser validation
* Digital fingerprinting
<br/>
In the past, Gaming ETC has tried (unsuccessfully) to scrape their website using conventional techniques (urllib, selenium, api requests, etc)

The Proposed Solution
--------------- 
Custom designed software utilizing COM (Component Object Model) design of Microsoft applications (Internet Explorer in this case) in order to inject scripts that interface with the application. These script injections allow the automated browsing of web pages in a manner indistinguishable from regular browsing. The script never interfaces with TCGplayer.com or the acting browser, thus evades all data scraping prevention measures.

The Implementation
--------------- 
Use web scraping technology and market analytics to determine the fair market value of the top 200 cards in real time. Move from pull notification to push notification on price changes to enable fast response on either relative value or absolute value.
