MTGS Mafia Votecounter V0.1 (Alpha): Counts votes that occurred between two posts (inclusive), displays vote count.

Also included are some HTML samples, one of a single post, one of an entire thread page.

LICENSE: This project is licensed under the MIT License. Please note that theHTMLAgilityPack library is licensed instead under the Microsoft Public License (Ms-PL) https://htmlagilitypack.codeplex.com/license

ASSUMPTIONS:
Players have exactly 1 vote
Players can only be voted for using the exact name that appears in the playerlist (no abbreviations or mispellings)
Unvotes stand alone (not "unvote:player X")
A player cannot vote and then unvote that vote in the same post (we look for unvotes before vote)
Unvote followed by vote must be in different sets of bold tags
Multiple votes must be made in different sets of bold tags

Future Features:
-Console to output errors/invalid votes
-Handling Replacements
-When did everyone last post?
-Tally posts made by player each day
-Read for "@MOD" requests
-Player nicknames (to allow more flexibility when voting)
-Save config (game link, start post, playerlist)
-Save previous votecount & continue from it
-Votecount formatting options.
-Multivoters (uh oh)
-Online hosting + web GUI
-Perhaps use something more distinct than bold tags (like ##VOTE:)