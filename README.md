# ParallelDots-CSharp-API
CSharp Wrapper for ParallelDots APIs
#### Supported Environment
> .NET Framework 4.6.1
#### Installation

> Open the console in Visual Studio using the Tools > NuGet Package Manager > Package Manager Console command.

```sh
PM> Install-Package ParallelDots -Version 2.0.8
```
#### Languages Supported
	- Portuguese ( pt )
	- Simplified Chinese ( zh )
	- Spanish ( es )
	- German ( de )
	- French ( fr )
	- Dutch ( nl )
	- Italian (it)
	- Japanese ( ja )
	- Russian ( ru )
	- Thai ( th )
	- Danish ( da )
	- Finish ( fi )
	- Arabic ( ar )
	- Greek ( el )
  
  
#### Set a reference path in Visual C#

> Open the Reference Manager in Visual Studio using the Project > Add Reference > Browse.

> Then select the .dll file from path given below:

> ROOT_PATH\packages\ParallelDots.2.0.2\lib\Paralleldots.dll

#### Import ParallelDots namespace
```sh
using ParallelDots
```
#### Initialize Instance of paralleldots Class
```sh
using Newtonsoft.Json.Linq;
paralleldots pd = new paralleldots(<api_key>);

//define category for the custom classifier api
JObject category = JObject.Parse(@"{'world politics': ['diplomacy', 'UN', 'war'], 'india': ['congress', 'india', 'bjp'], 'finance': ['markets', 'economy', 'shares']}");
//define path_to_image for the visual apis
String path_to_image = @"<path_to_image>";
//define url_to_image for the visual apis
String url_to_image = "<url_to_image>";
//define text_list for the batch apis
JArray text_list = JArray.Parse("[\"drugs are fun\", \"don\'t do drugs, stay in school\", \"lol you a fag son\", \"I have a throat infection\"]");
//define text_list_multilang for the multilang batch apis
JArray text_list_multilang = JArray.Parse("[\"les drogues sont amusantes\", \"ne pas faire de la drogue reste à l'école\", \"lol vous un fils de fag\", \"J'ai une infection de la gorge\"]");
//define lang_text for the language detection api
String lang_text = "C'est un environnement très hostile, si vous choisissez de débattre ici, vous serez vicieusement attaqué par l'opposition.";
```
#### Example
```sh
Console.WriteLine("abuse");
String abuse = pd.abuse("you f**king a$$hole");
Console.WriteLine(abuse);
abuse
{"code": 200, "sentence_type": "Abusive", "confidence_score": 0.953125}

Console.WriteLine("abuse_batch");
String abuse_batch = pd.abuse_batch(text_list);
Console.WriteLine(abuse_batch);
{"code": 200, "abuse": [{"sentence_type": "Non Abusive", "confidence_score": 0.904297}, {"sentence_type": "Non Abusive", "confidence_score": 0.953125}, {"sentence_type": "Abusive", "confidence_score": 0.884766}, {"sentence_type": "Non Abusive", "confidence_score": 0.859375}]}

Console.WriteLine("custom_classifier");
String custom_classifier = pd.custom_classifier("Narendra Modi is the Prime Minister of India", category);
Console.WriteLine(custom_classifier);
custom_classifier
{"code": 200, "taxonomy": [{"confidence_score": 0.929256021976471, "tag": "india"}, {"confidence_score": 0.9066339731216431, "tag": "world politics"}, {"confidence_score": 0.5557219982147217, "tag": "finance"}]}

Console.WriteLine("emotion");
String emotion = pd.emotion("Did you hear the latest Porcupine Tree song ? It's rocking !");
Console.WriteLine(emotion);
emotion
{"code": 200, "emotion": {"probabilities": {"Excited": 0.35946185611995524, "Angry": 0.047388801553766284, "Sarcasm": 0.11246225260033746, "Sad": 0.008463515319536615, "Happy": 0.38386026259527695, "Fear": 0.0832442102790067, "Bored": 0.005119101532120664}, "emotion": "Happy"}}

Console.WriteLine("emotion_multilang");
String emotion_multilang = pd.emotion("Avez-vous entendu la dernière chanson de Porcupine Tree? Ça berce!", "fr");
Console.WriteLine(emotion_multilang);
emotion_multilang
{"code": 200, "emotion": {"probabilities": {"Excited": 0.22379238991339617, "Angry": 0.06747602813321307, "Sarcasm": 0.129273083404285, "Sad": 0.1666631471181756, "Happy": 0.2766871542748692, "Fear": 0.13610819715606104, "Bored": 0.0}, "emotion": "Happy"}}

Console.WriteLine("emotion batch");
String emotion_batch = pd.emotion_batch(text_list);
Console.WriteLine(emotion_batch);
emotion batch
{"code": 200, "emotion": [{"Excited": 0.2082173830066366, "Angry": 0.08368749025924326, "Sarcasm": 0.14361357966835644, "Sad": 0.025132654797074747, "Happy": 0.1269828871815771, "Fear": 0.344180628127824, "Bored": 0.06818537695928778}, {"Excited": 0.10118401124107868, "Angry": 0.28458333402617014, "Sarcasm": 0.09578231410218406, "Sad": 0.05735552847026735, "Happy": 0.11277100320338784, "Fear": 0.13348989058422842, "Bored": 0.21483391837268373}, {"Excited": 0.16457090063285224, "Angry": 0.1216389498218648, "Sarcasm": 0.11124312097614852, "Sad": 0.05410169293913279, "Happy": 0.07598588202024392, "Fear": 0.18020579627989994, "Bored": 0.2922536573298578}, {"Excited": 0.004337021311595699, "Angry": 0.46982189055546925, "Sarcasm": 0.05327575096045899, "Sad": 0.3672790882763135, "Happy": 0.005119673993076841, "Fear": 0.09443579921654321, "Bored": 0.005730775686542725}]}

Console.WriteLine("emotion_multilang batch");
String emotion_multilang_batch = pd.emotion_batch(text_list_multilang, "fr");
Console.WriteLine(emotion_multilang_batch);
emotion_multilang batch
{"code": 200, "emotion": [{"Excited": 0.2082173830066366, "Angry": 0.08368749025924326, "Sarcasm": 0.14361357966835644, "Sad": 0.025132654797074747, "Happy": 0.1269828871815771, "Fear": 0.344180628127824, "Bored": 0.06818537695928778}, {"Excited": 0.04239430417791154, "Angry": 0.5973252487701952, "Sarcasm": 0.07606870827400262, "Sad": 0.05560273629943171, "Happy": 0.048649541948481326, "Fear": 0.09433366519047207, "Bored": 0.08562579533950584}, {"Excited": 0.20433981731805748, "Angry": 0.1220104704524655, "Sarcasm": 0.13830145223523543, "Sad": 0.04597934708090136, "Happy": 0.0987838892687481, "Fear": 0.16393978751891622, "Bored": 0.22664523612567564}, {"Excited": 0.004337021311595699, "Angry": 0.46982189055546925, "Sarcasm": 0.05327575096045899, "Sad": 0.3672790882763135, "Happy": 0.005119673993076841, "Fear": 0.09443579921654321, "Bored": 0.005730775686542725}]}

Console.WriteLine("facial_emotion");
String facial_emotion = pd.facial_emotion(path_to_image);
Console.WriteLine(facial_emotion);
facial_emotion
{"code": 200, "facial_emotion": [{"tag": "Neutral", "score": 0.6072409749031067}, {"tag": "Angry", "score": 0.10396357625722885}, {"tag": "Sad", "score": 0.08047984540462494}, {"tag": "Surprise", "score": 0.05207890272140503}, {"tag": "Happy", "score": 0.05207890272140503}, {"tag": "Fear", "score": 0.05207890272140503}, {"tag": "Disgust", "score": 0.05207890272140503}]}

Console.WriteLine("facial_emotion_url");
String facial_emotion_url = pd.facial_emotion_url(url_to_image);
Console.WriteLine(facial_emotion_url);
facial_emotion_url
{"code": 200, "facial_emotion": [{"tag": "Neutral", "score": 0.45063450932502747}, {"tag": "Happy", "score": 0.1430361568927765}, {"tag": "Surprise", "score": 0.08126586675643921}, {"tag": "Sad", "score": 0.08126586675643921}, {"tag": "Fear", "score": 0.08126586675643921}, {"tag": "Disgust", "score": 0.08126586675643921}, {"tag": "Angry", "score": 0.08126586675643921}]}

Console.WriteLine("intent");
String intent = pd.intent("Finance ministry calls banks to discuss new facility to drain cash");
Console.WriteLine(intent);
intent
{"code": 200, "probabilities": {"feedback/opinion": 0.097, "query": 0.032, "spam/junk": 0.039, "marketing": 0.059, "news": 0.773}, "intent": "news"}

Console.WriteLine("intent batch");
String intent_batch = pd.intent_batch(text_list);
Console.WriteLine(intent_batch);
intent batch
{"code": 200, "intent": [{"feedback/opinion": 0.141, "query": 0.002, "spam/junk": 0.66, "marketing": 0.116, "news": 0.08}, {"feedback/opinion": 0.393, "query": 0.027, "spam/junk": 0.423, "marketing": 0.106, "news": 0.051}, {"feedback/opinion": 0.333, "query": 0.001, "spam/junk": 0.664, "marketing": 0.001, "news": 0.001}, {"feedback/opinion": 0.469, "query": 0.404, "spam/junk": 0.124, "marketing": 0.0, "news": 0.004}]}

Console.WriteLine("keywords");
String keywords = pd.keywords("Prime Minister Narendra Modi tweeted a link to the speech Human Resource Development Minister Smriti Irani made in the Lok Sabha during the debate on the ongoing JNU row and the suicide of Dalit scholar Rohith Vemula at the Hyderabad Central University.");
Console.WriteLine(keywords);
keywords
{"code": 200, "keywords": [{"keyword": "Prime Minister Narendra Modi", "confidence_score": 0.874473}, {"keyword": "link", "confidence_score": 0.940891}, {"keyword": "speech Human Resource Development", "confidence_score": 0.906034}, {"keyword": "Smriti Irani", "confidence_score": 0.966651}]}

Console.WriteLine("keywords batch");
String keywords_batch = pd.keywords_batch(text_list);
Console.WriteLine(keywords_batch);
keywords batch
{"code": 200, "keywords": [[{"keyword": "fun", "confidence_score": 0.560126}], [{"keyword": "drugs", "confidence_score": 0.894901}, {"keyword": "school", "confidence_score": 0.509218}], [{"keyword": "fag", "confidence_score": 0.791485}], [{"keyword": "throat infection", "confidence_score": 0.849233}]]}

Console.WriteLine("language_detection");
String language_detection = pd.language_detection(lang_text);
Console.WriteLine(language_detection);
language_detection
{"output": "French", "code": 200, "prob": 0.9999592304229736}

Console.WriteLine("language_detection batch");
String language_detection_batch = pd.language_detection_batch(text_list_multilang);
Console.WriteLine(language_detection_batch);
language_detection batch
{"code": 200, "lang_detection": [{"output": "French", "prob": 0.9990742802619934}, {"output": "French", "prob": 0.9999998807907104}, {"output": "French", "prob": 0.996209442615509}, {"output": "French", "prob": 0.9985631108283997}]}

Console.WriteLine("multilang_keywords");
String multilang_keywords = pd.multilang_keywords("La ville de Paris est très belle", "fr");
Console.WriteLine(multilang_keywords);
multilang_keywords
{"code": 200, "keywords": [{"confidence_score": 1.0, "keyword": "ville"}, {"confidence_score": 1.0, "keyword": "paris"}, {"confidence_score": 1.0, "keyword": "belle"}]}

Console.WriteLine("ner");
String ner = pd.ner("Narendra Modi is the prime minister of India");
Console.WriteLine(ner);
ner
{"entities": [{"name": "Narendra Modi", "category": "name", "confidence_score": 0.951439}, {"name": "India", "category": "place", "confidence_score": 0.9263}], "code": 200}

Console.WriteLine("ner batch");
String ner_batch = pd.ner_batch(text_list);
Console.WriteLine(ner_batch);
ner batch
{"entities": [[], [{"name": "don", "category": "name", "confidence_score": 0.671695}], [], []], "code": 200}

Console.WriteLine("nsfw");
String nsfw = pd.nsfw(path_to_image);
Console.WriteLine(nsfw);
nsfw
{"code": 200, "nsfw": "not safe to open at work", "probability": 0.787496}

Console.WriteLine("nsfw_url");
String nsfw_url = pd.nsfw_url(url_to_image);
Console.WriteLine(nsfw_url);
nsfw_url
{"code": 200, "nsfw": "safe to open at work", "probability": 0.999648}

Console.WriteLine("object_recognizer");
String object_recognizer = pd.object_recognizer(path_to_image);
Console.WriteLine(object_recognizer);
object_recognizer
{"code": 200, "output": [{"score": 0.21129773557186127, "tag": "Art"}, {"score": 0.180560901761055, "tag": "Person"}, {"score": 0.17255575954914093, "tag": "Sitting"}, {"score": 0.14926795661449432, "tag": "Statue"}, {"score": 0.1323658525943756, "tag": "Poster"}, {"score": 0.11433436721563339, "tag": "Sculpture"}, {"score": 0.1113261878490448, "tag": "Clothing"}, {"score": 0.08422151207923889, "tag": "Album cover"}, {"score": 0.08128573000431061, "tag": "Screenshot"}, {"score": 0.08076596260070801, "tag": "Illustration"}]}

Console.WriteLine("object_recognizer_url");
String object_recognizer_url = pd.object_recognizer_url(url_to_image);
Console.WriteLine(object_recognizer_url);
object_recognizer_url
{"code": 200, "output": [{"score": 0.5784599781036377, "tag": "Screenshot"}, {"score": 0.2543911039829254, "tag": "Person"}, {"score": 0.20797836780548096, "tag": "Presentation"}, {"score": 0.14402228593826294, "tag": "Speech"}, {"score": 0.08889435976743698, "tag": "Man"}, {"score": 0.08697150647640228, "tag": "Brand"}, {"score": 0.06565890461206436, "tag": "Clothing"}, {"score": 0.06072978302836418, "tag": "Poster"}, {"score": 0.05715743452310562, "tag": "Face"}, {"score": 0.034983083605766296, "tag": "Advertising"}]}

Console.WriteLine("phrase_extractor");
String phrase_extractor = pd.phrase_extractor("The girls giggling and playing in the park never seemed to tire");
Console.WriteLine(phrase_extractor);
phrase_extractor
{"keywords": [{"relevance_score": 1, "keyword": "tire"}], "code": 200}

Console.WriteLine("phrase_extractor batch");
String phrase_extractor_batch = pd.phrase_extractor_batch(text_list);
Console.WriteLine(phrase_extractor_batch);
phrase_extractor batch
{"code": 200, "phrases": [[], [{"relevance_score": 1, "keyword": "school"}], [{"relevance_score": 2, "keyword": "fag son"}], [{"relevance_score": 2, "keyword": "throat infection"}]]}

Console.WriteLine("popularity");
String popularity = pd.popularity(path_to_image);
Console.WriteLine(popularity);
popularity
{"Not Popular": "36.5986973047", "code": 200, "Popular": "63.4013056755"}

Console.WriteLine("popularity_url");
String popularity_url = pd.popularity_url(url_to_image);
Console.WriteLine(popularity_url);
popularity_url
{"Not Popular": "31.6112935543", "code": 200, "Popular": "68.3887064457"}

Console.WriteLine("sentiment");
String sentiment = pd.sentiment("Come on, lets play together");
Console.WriteLine(sentiment);
sentiment
{"code": 200, "sentiment": "neutral", "probabilities": {"positive": 0.096, "negative": 0.013, "neutral": 0.891}}

Console.WriteLine("sentiment_multilang");
String sentiment_multilang = pd.sentiment("Allez, jouons ensemble", "fr");
Console.WriteLine(sentiment_multilang);
sentiment_multilang
{"code": 200, "sentiment": "neutral", "probabilities": {"positive": 0.223, "negative": 0.013, "neutral": 0.764}}

Console.WriteLine("sentiment batch");
String sentiment_batch = pd.sentiment_batch(text_list);
Console.WriteLine(sentiment_batch);
sentiment batch
{"sentiment": [{"positive": 0.69, "negative": 0.046, "neutral": 0.265}, {"positive": 0.061, "negative": 0.361, "neutral": 0.578}, {"positive": 0.527, "negative": 0.275, "neutral": 0.198}, {"positive": 0.077, "negative": 0.908, "neutral": 0.015}], "code": 200}

Console.WriteLine("sentiment_multilang batch");
String sentiment_multilang_batch = pd.sentiment_batch(text_list, "fr");
Console.WriteLine(sentiment_multilang_batch);
sentiment_multilang batch
{"sentiment": [{"positive": 0.69, "negative": 0.046, "neutral": 0.265}, {"positive": 0.053, "negative": 0.429, "neutral": 0.518}, {"positive": 0.395, "negative": 0.378, "neutral": 0.226}, {"positive": 0.077, "negative": 0.908, "neutral": 0.015}], "code": 200}

Console.WriteLine("similarity");
String similarity = pd.similarity("Sachin is the greatest batsman", "Tendulkar is the finest cricketer");
Console.WriteLine(similarity);
similarity
{"actual_score": 0.842932, "normalized_score": 4.931469, "code": 200}

Console.WriteLine("taxonomy");
String taxonomy = pd.taxonomy("Narendra Modi is the prime minister of India");
Console.WriteLine(taxonomy);
taxonomy
{"taxonomy": [{"confidence_score": 0.9171473383903503, "tag": "hobbies and interests/inventors and patents"}, {"confidence_score": 0.792364, "tag": "law, govt and politics/government"}, {"confidence_score": 0.916781, "tag": "business and industrial/business news"}], "code": 200}

Console.WriteLine("taxonomy batch");
String taxonomy_batch = pd.taxonomy_batch(text_list);
Console.WriteLine(taxonomy_batch);
taxonomy batch
{"taxonomy": [[{"confidence_score": 0.996437, "tag": "health and fitness/drugs"}, {"confidence_score": 0.967404, "tag": "family and parenting/babies and toddlers"}, {"confidence_score": 0.6848993897438049, "tag": "automotive and vehicles/motor shows"}], [{"confidence_score": 0.977439, "tag": "health and fitness/dental care"}, {"confidence_score": 0.961832, "tag": "family and parenting/babies and toddlers"}, {"confidence_score": 0.970684, "tag": "education/school"}], [{"confidence_score": 0.9779467582702637, "tag": "family and parenting/parenting teens"}, {"confidence_score": 0.972425, "tag": "health and fitness/therapy"}, {"confidence_score": 0.9049649834632874, "tag": "pets/cats"}], [{"confidence_score": 0.985712, "tag": "health and fitness/disease"}, {"confidence_score": 0.974752, "tag": "family and parenting/adoption"}, {"confidence_score": 0.97041, "tag": "pets/cats"}]], "code": 200}

Console.WriteLine("text_parser");
String text_parser = pd.text_parser("Thrilling contest between Manchester City and Manchester United ends in a draw.");
Console.WriteLine(text_parser);
text_parser
{"code": 200, "output": [{"text": "Thrilling", "Dependency": "compound", "Tags": "noun"}, {"text": "contest", "Dependency": "nominal subject", "Tags": "noun"}, {"text": "between", "Dependency": "prepositional modifier", "Tags": "preposition or conjunction"}, {"text": "Manchester", "Dependency": "compound", "Tags": "noun"}, {"text": "City", "Dependency": "object of a preposition", "Tags": "noun"}, {"text": "and", "Dependency": "coordinating conjunction", "Tags": "conjuction"}, {"text": "Manchester", "Dependency": "compound", "Tags": "noun"}, {"text": "United", "Dependency": "conjunct", "Tags": "noun"}, {"text": "ends", "Dependency": "root", "Tags": "verb"}, {"text": "in", "Dependency": "prepositional modifier", "Tags": "preposition or conjunction"}, {"text": "a", "Dependency": "determiner", "Tags": "determiner"}, {"text": "draw", "Dependency": "object of a preposition", "Tags": "noun"}]}

Console.WriteLine("usage");
String usage = pd.usage();
Console.WriteLine(usage);
usage
{"monthly_billable_hits_breakdown": {"facial_emotion": 12, "emotion": 65, "sentiment": 55, "similarity": 5, "language_detection": 30, "ner": 42, "popularity": 34, "text_parser": 6, "custom_classifier": 6, "abuse": 36, "nsfw": 11, "taxonomy": 25, "keywords": 56, "intent": 30, "object_recognizer": 10, "multilang_keywords": 6, "phrase_extractor": 25}, "daily_billable_hits_breakdown": {"facial_emotion": 12, "emotion": 60, "sentiment": 50, "similarity": 5, "language_detection": 30, "ner": 42, "popularity": 10, "text_parser": 6, "custom_classifier": 6, "abuse": 35, "nsfw": 11, "taxonomy": 25, "keywords": 30, "intent": 30, "object_recognizer": 10, "multilang_keywords": 6, "phrase_extractor": 25}, "daily_billable_hits": 393, "monthly_billable_hits": 454}


```
