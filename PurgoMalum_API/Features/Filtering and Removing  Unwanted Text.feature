Feature: Filtering and Removing Unwanted Text
	This feature file is collection of all necessary test scenarios of PurgoMalum web service used to filter out 
unwanted contents through  it's Web API
    It includes
	 1 Filter and remove all text in profanity lists and displayed as * by default
	   case insensitive
	   part of word or words
	   at front , middle, and end
	 2 Add new word or words as profanity text and can be filtered out and displayed as * by default
	 3 Replace profanity text by the specified word or symbols
	 4 Add and replace the profanity text in the same time 
	 5 Error Handling scenarios
	   Empty string
	   replacing word is more than 20 characters
	   Added bad word is more than 10 word
	6  It only test JSON Method 
Background:
   Given A user setup the web server

Scenario Outline: Filter out bad words from profanity lists_Default
    
	Given The User entered text <inputText>
	When  The user Request Web Service using JSON Method
	Then  The result should be <expectedText>

	Examples:
	| inputText                               | expectedText                             |
	| "without profanity word"                | "without profanity word"                 |
	| "with unwanted word boner"              | "with unwanted word *****"               |
	| "with chink unwanted word"              | "with ***** unwanted word"               |
	| "shit with unwanted word"               | "**** with unwanted word"                |
	| "SHIT with unwanted word"               | "**** with unwanted word"                |
	| "this is Shit and that is ass"          | "this is **** and that is ***"           |    
	| "aa bb cc dd eee fff ggg hhh iii jjj vv"| "aa bb cc dd eee fff ggg hhh iii jjj vv" |

Scenario Outline: Filter out bad words from profanity lists_Advanced
	Given The User entered text <inputText>
	When  The user Request Web Service using JSON Method
	Then  The result should be <expectedText>
	Examples:
	| inputText                                                                       | expectedText                             |
	| "without profanity word&add=word"                                               | "without profanity ****"                 |
	| "without profanity word&add=word&fill_text=aaaa"                                | "without profanity aaaa"                 |
	| "with unwanted word boner&fill_text=[replaced]"                                 | "with unwanted word [replaced]"          |
	| "COCK with unwanted word&fill_text=hhhh"                                        | "hhhh with unwanted word"                |
	| "with chink unwanted word&fill_char=-"                                          | "with ----- unwanted word"               |
	| "with dic unwanted word&fill_char=~"                                            | "with ~~~ unwanted word"                 | 
	| "with dic unwanted word&fill_char=\|"                                           | "with \|\|\| unwanted word"              |
	| "this is Shit and that is ass&fill_text=____"                                   | "this is ____ and that is ____"          |
	| "aa bb cc dd eee fff ggg hhh iii jjj vv&add=aa,bb,cc,dd,eee,fff,ggg,hhh,iii,vv" | "** ** ** ** *** *** *** *** *** jjj **" |


Scenario Outline: Filter out bad words from profanity lists_Error Handling
	Given The User entered text <inputText>
	When  The user Request Web Service using JSON Method
	Then  The error messages should be <expectedText>
	Examples: 
	| inputText                                                                           | expectedText                                            |
	| "      "                                                                            | "No Input"                                              |
	| "this is some test input&fill_text=this is long replacement text"                   | "User Replacement Text Exceeds Limit of 20 Characters." |
	| "aa bb cc dd eee fff ggg hhh iii jjj vv&add=aa,bb,cc,dd,eee,fff,ggg,hhh,iii,jjj,vv" | "User Black List Exceeds Limit of 10 Words."            |
	
	
Scenario Outline: Filter out bad words from profanity lists_Status check
    Given The User entered text check if containing profanity words <inputText>
	When  The user Request Web Service for status
	Then  The expected status is <expectedStatus>
	Examples: 
	| inputText                 |expectedStatus  |
	| "without profanity word"  |"False"         |
	| "with unwanted word boner"|"True"          |
	| "with chink unwanted word"|"True"          |
	| "cock with unwanted word" |"True"          |
	| "COCK with unwanted word" |"True"          |