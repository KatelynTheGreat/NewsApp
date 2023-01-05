# NewsApp





# How to get a token and more.

Navigate to gnews.io
Click on “pricing”
Click on “Start for Free” and sign-up
Note there are limitations with the free plan, but there are enough options for us to test it. 
Make sure you go to your email and verify the email address.
Go to the documentation link: https://gnews.io/docs/v4#introduction
You’ll see the different documentation along with the information you can pull in. 
For this project, we’re specifically interested in “Top Headlines Endpoint” located here: https://gnews.io/docs/v4#top-headlines-endpoint
There is an HTTP Request Url used for getting the headlines.  (If you’ve done any web scraping with python, you’ll remember using the “requests” library. This is very similar). You’ll need this link provided: https://gnews.io/api/v4/top-headlines?token=API-Key&topic=breaking-news 
You’ll notice, if you take the address and paste it in your browser you’ll get a warning that your API key is invalid. That is because, to pull the data you also need to include your API key along with the web link.
If you go back to your dashboard you’ll see your API-Token. If you copy and paste that log alphanumeric number where the web address has “API-Key”, you’ll actually get back the latest news. 
Notice, it will pull the news in of all the languages available. But we only want English for this project. So go back to the “Documentation” → “Top Headlines Endpoint”. Notice there is a “lang” parameter. This will be used to select English only. If you click the link, it will provide the language parameter to pass through. 
If you want to only see a particular topic like sports or business, you can pass through the parameters of what you are specifically looking for. You simply add “&lang=en&topic=sports” to the end of the web address. 


What’s been delivered to us using the api and keys is JSON data. You can review more on what JSON is here: https://www.w3schools.com/whatis/whatis_json.asp
What we need to do is convert the JSON to a C# Object and we’re going to do that by copying the JSON response, the response from copying and pasting the url with the api key + title and lang. 
Now we cheat and take a shortcut! In a browser, navigate to: www.json2csharp.com
Copy the response from gnews.io response into the JSON Side and Click Convert. The following should be your response:
Notice it creates classes for you that includes getters and setters in C#. Beautiful!
But!!! If we use it as is, we’ll likely get an error. We need the strings and ints to be in Pascal Case, where the first letter is capitalized. So, on the bottom left, you’ll see “Pascal Case” under property settings. Check that and click convert again. 
Copy to clipboard and go back to Visual Studio.

