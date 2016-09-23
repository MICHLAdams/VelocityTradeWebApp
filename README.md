# VelocityTradeWebApp

Hi Guys, just a few points before Running.

1)For authentication i've gone ahead and used identity because this allowed me to get up and running with minimal code and build DB work and ensures that
  it has a db locally, which for these purposes I thought would be fine.I added some work around showing the search page only after 
  auth returns "success".Later today I will commit some changes around logging in with FB and google.
  
2)on the search page i've just dupmed the results from the search "defaulted to search with the keyword csharp" 
  and arranged these inside an "<ul>".
  
3)I've added Unit Tests but not used it, I wanted to get something out to you quickly and wasnt sure I'd have
  enough time to cover the topic.

4)I havent done anything to change the css of the defualt start-up project or had to write a lot of HTML however see my assetLife repo
  for some examples of pages I'v built out using minamal scaffolding.(i.e it may need a web config file,if you want to run it.)

5)because the search is automated the only event I could think would be nice to add would be login/logout which I will add wth the next   commit, but I wanted to give you a peak at my progress.  
