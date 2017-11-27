# ParallelDots-CSharp-API
CSharp Wrapper for ParallelDots APIs
#### Supported Environment
> .NET Framework 4.0
#### Installation

> Open the console in Visual Studio using the Tools > NuGet Package Manager > Package Manager Console command.

```sh
PM> Install-Package ParallelDots -Version 2.0.1
```

#### Set a reference path in Visual C#

> Open the Reference Manager in Visual Studio using the Project > Add Reference > Browse.

> Then select the .dll file from path given below:

> ROOT_PATH\packages\ParallelDots.2.0.1\lib\Paralleldots.dll

#### Import ParallelDots namespace
```sh
using ParallelDots
```
#### Initialize Instance of api Class
```sh
ParallelDots.api pd = new ParallelDots.api(api_key);
```
#### Example
```sh
var sentiment = pd.sentiment("Come on, lets play together");
Console.WriteLine(sentiment);

{"probabilities": {"positive": 0.568817,"neutral": 0.400776,"negative": 0.030407}, "sentiment":"positive"}

var similarity = pd.similarity("Sachin is the greatest batsman", "Tendulkar is the finest cricketer");
Console.WriteLine(similarity);

{"actual_score": 0.8429316084125629, "normalized_score": 4.931468682744329, "similarity": 4.931468682744329}

var ner = pd.ner("Narendra Modi is the prime minister of India");
Console.WriteLine(ner);

{"entities": [{"category": ["place"], "name": "India", "confidence_score": 1.0}, {"category": ["person"], "name": "Narendra Modi", "confidence_score": 1.0}]}

var keywords = pd.keywords("Prime Minister Narendra Modi tweeted a link to the speech Human Resource Development Minister Smriti Irani made in the Lok Sabha during the debate on the ongoing JNU row and the suicide of Dalit scholar Rohith Vemula at the Hyderabad Central University.");
Console.WriteLine(keywords);

{"keywords": [{"relevance_score": 6, "keyword": "Human Resource Development Minister Smriti Irani"}, {"relevance_score": 4, "keyword": "Prime Minister Narendra Modi"}, {"relevance_score": 3, "keyword": "Hyderabad Central University"}, {"relevance_score": 3, "keyword": "ongoing JNU row"}, {"relevance_score": 2, "keyword": "Dalit scholar"}, {"relevance_score": 2, "keyword": "Lok Sabha"}, {"relevance_score": 2, "keyword": "Rohith Vemula"}]}

var taxonomy = pd.taxonomy("Narendra Modi is the prime minister of India");
Console.WriteLine(taxonomy);

{"tag": "terrorism", "confidence_score": 0.531435}, {"tag": "world politics", "confidence_score": 0.391963}, {"tag": "politics", "confidence_score": 0.358955}, {"tag": "religion", "confidence_score": 0.308195}, {"tag": "defense", "confidence_score": 0.26187}, {"tag": "business", "confidence_score": 0.20885}, {"tag": "entrepreneurship", "confidence_score": 0.18349}, {"tag": "health", "confidence_score": 0.171121}, {"tag": "technology", "confidence_score": 0.168591}, {"tag": "law", "confidence_score": 0.156953}, {"tag": "education", "confidence_score": 0.146511}, {"tag": "science", "confidence_score": 0.101002}, {"tag": "crime", "confidence_score": 0.085016}, {"tag": "entertainment", "confidence_score": 0.080634}, {"tag": "environment", "confidence_score": 0.078024}, {"tag": "disaster", "confidence_score": 0.075295}, {"tag": "weather", "confidence_score": 0.06784}, {"tag": "accident", "confidence_score": 0.066831}, {"tag": "sports", "confidence_score": 0.058329}, {"tag": "advertising", "confidence_score": 0.054868}, {"tag": "history", "confidence_score": 0.043581}, {"tag": "mining", "confidence_score": 0.03833}, {"tag": "travel", "confidence_score": 0.025517}, {"tag": "geography", "confidence_score": 0.022372}, {"tag": "nature", "confidence_score": 0.013477}, {"tag": "lifestyle", "confidence_score": 0.006467}, {"tag": "automobile", "confidence_score": 0.001161}, {"tag": "personal care", "confidence_score": 0.000275}]}

var emotion = pd.emotion("Did you hear the latest Porcupine Tree song ? It's rocking !");
Console.WriteLine(emotion);

{"emotion": "happy"}

var intent = pd.intent("Finance ministry calls banks to discuss new facility to drain cash");
Console.WriteLine(intent);

{"intent": "news"}

var multilang = pd.multilang("La ville de Paris est très belle", "fr");
Console.WriteLine(multilang);

{"sentiment": "positive", "confidence_score": 0.845703}

var abuse = pd.abuse("you f**king a$$hole");
Console.WriteLine(abuse);

{"sentence_type": "Abusive", "confidence_score": 0.953125}

var sentiment_social = sentiment_social("I left my camera at home")
Console.WriteLine(sentiment_social);

{"probabilities": {"positive": 0.040374, "neutral": 0.491032, "negative": 0.468594}}

var usage = pd.usage();
Console.WriteLine(usage);

{"emotion": 100, "sentiment": 96, "similarity": 100, "taxonomy": 100, "abuse": 100, "intent": 100, "keywords": 100, "ner": 100, "multilang": 100, "sentiment_social": 97}
```
