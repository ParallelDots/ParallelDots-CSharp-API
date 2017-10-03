# ParallelDots-CSharp-API
CSharp Wrapper for ParallelDots APIs
#### Supported Environment
> .NET Framework 4.0
#### Installation

> Open the console in Visual Studio using the Tools > NuGet Package Manager > Package Manager Console command.

```sh
PM> Install-Package ParallelDots
```

#### Set a reference path in Visual C#

> Open the Reference Manager in Visual Studio using the Project > Add Reference > Browse.

> Then select the .dll file from the installed packages in the "packages" directory of the application.

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

{"probabilities": {"positive": 0.00002,"neutral": 0.999954,"negative": 0.000026}}

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

{"taxonomy": [{"tag": "finance", "confidence_score": 4.088}, {"tag": "government", "confidence_score": 3.4284}, {"tag": "business", "confidence_score": 1.2719}]}

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
