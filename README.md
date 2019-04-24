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
JArray text_multilang = JArray.Parse("[\"Lionel Andrés Messi vuelve a ser el gran protagonista en las portadas de la prensa deportiva internacional al día siguiente de un partido de Champions.\"]"
```
#### Example
```sh
Console.WriteLine("abuse");
String abuse = pd.abuse("you f**king a$$hole");
Console.WriteLine(abuse);



Console.WriteLine("abuse_batch");
String abuse_batch = pd.abuse_batch(text_list);
Console.WriteLine(abuse_batch);


Console.WriteLine("custom_classifier");
String custom_classifier = pd.custom_classifier("Narendra Modi is the Prime Minister of India", category);
Console.WriteLine(custom_classifier);



Console.WriteLine("emotion");
String emotion = pd.emotion("Did you hear the latest Porcupine Tree song ? It's rocking !");
Console.WriteLine(emotion);



Console.WriteLine("emotion_multilang");
String emotion_multilang = pd.emotion("Avez-vous entendu la dernière chanson de Porcupine Tree? Ça berce!", "fr");
Console.WriteLine(emotion_multilang);



Console.WriteLine("emotion batch");
String emotion_batch = pd.emotion_batch(text_list);
Console.WriteLine(emotion_batch);



Console.WriteLine("emotion_multilang batch");
String emotion_multilang_batch = pd.emotion_batch(text_list_multilang, "fr");
Console.WriteLine(emotion_multilang_batch);



Console.WriteLine("sarcasm");
String sarcasm = pd.sarcasm("Did you hear the latest Porcupine Tree song ? It's rocking !");
Console.WriteLine(sarcasm);



Console.WriteLine("sarcasm_multilang");
String sarcasm_multilang = pd.sarcasm("Avez-vous entendu la dernière chanson de Porcupine Tree? Ça berce!", "fr");
Console.WriteLine(sarcasm_multilang);



Console.WriteLine("sarcasm batch");
String sarcasm_batch = pd.sarcasm_batch(text_list);
Console.WriteLine(sarcasm_batch);



Console.WriteLine("sarcasm_multilang batch");
String sarcasm_multilang_batch = pd.sarcasm_batch(text_list_multilang, "fr");
Console.WriteLine(sarcasm_multilang_batch);




Console.WriteLine("facial_emotion");
String facial_emotion = pd.facial_emotion(path_to_image);
Console.WriteLine(facial_emotion);


Console.WriteLine("facial_emotion_url");
String facial_emotion_url = pd.facial_emotion_url(url_to_image);
Console.WriteLine(facial_emotion_url);


Console.WriteLine("intent");
String intent = pd.intent("Finance ministry calls banks to discuss new facility to drain cash");
Console.WriteLine(intent);


Console.WriteLine("intent batch");
String intent_batch = pd.intent_batch(text_list);
Console.WriteLine(intent_batch);


Console.WriteLine("keywords");
String keywords = pd.keywords("Prime Minister Narendra Modi tweeted a link to the speech Human Resource Development Minister Smriti Irani made in the Lok Sabha during the debate on the ongoing JNU row and the suicide of Dalit scholar Rohith Vemula at the Hyderabad Central University.");
Console.WriteLine(keywords);


Console.WriteLine("keywords batch");
String keywords_batch = pd.keywords_batch(text_list);
Console.WriteLine(keywords_batch);



Console.WriteLine("language_detection batch");
String language_detection_batch = pd.language_detection_batch(text_list_multilang);
Console.WriteLine(language_detection_batch);

Console.WriteLine("multilang_keywords");
String multilang_keywords = pd.multilang_keywords("La ville de Paris est très belle", "fr");
Console.WriteLine(multilang_keywords);


Console.WriteLine("ner");
String ner = pd.ner("Narendra Modi is the prime minister of India");
Console.WriteLine(ner);


Console.WriteLine("ner batch");
String ner_batch = pd.ner_batch(text_list);
Console.WriteLine(ner_batch);


Console.WriteLine("Multilang ner");
String multilang_ner = pd.ner("Lionel Andrés Messi vuelve a ser el gran protagonista en las portadas de la prensa deportiva internacional al día siguiente de un partido de Champions.","es");
Console.WriteLine(multilang_ner);


Console.WriteLine("multilang_ner batch");
String multilang_ner_batch = pd.ner_batch(text_multilang,"es");
Console.WriteLine(multilang_ner_batch);


Console.WriteLine("object_recognizer");
String object_recognizer = pd.object_recognizer(path_to_image);
Console.WriteLine(object_recognizer);

Console.WriteLine("object_recognizer_url");
String object_recognizer_url = pd.object_recognizer_url(url_to_image);
Console.WriteLine(object_recognizer_url);


Console.WriteLine("phrase_extractor");
String phrase_extractor = pd.phrase_extractor("The girls giggling and playing in the park never seemed to tire");
Console.WriteLine(phrase_extractor);


Console.WriteLine("phrase_extractor batch");
String phrase_extractor_batch = pd.phrase_extractor_batch(text_list);
Console.WriteLine(phrase_extractor_batch);


Console.WriteLine("sentiment");
String sentiment = pd.sentiment("Come on, lets play together");
Console.WriteLine(sentiment);


Console.WriteLine("sentiment_multilang");
String sentiment_multilang = pd.sentiment("Allez, jouons ensemble", "fr");
Console.WriteLine(sentiment_multilang);


Console.WriteLine("sentiment batch");
String sentiment_batch = pd.sentiment_batch(text_list);
Console.WriteLine(sentiment_batch);


Console.WriteLine("sentiment_multilang batch");
String sentiment_multilang_batch = pd.sentiment_batch(text_list, "fr");
Console.WriteLine(sentiment_multilang_batch);


Console.WriteLine("similarity");
String similarity = pd.similarity("Sachin is the greatest batsman", "Tendulkar is the finest cricketer");
Console.WriteLine(similarity);


Console.WriteLine("taxonomy");
String taxonomy = pd.taxonomy("Narendra Modi is the prime minister of India");
Console.WriteLine(taxonomy);


Console.WriteLine("taxonomy batch");
String taxonomy_batch = pd.taxonomy_batch(text_list);
Console.WriteLine(taxonomy_batch);


Console.WriteLine("text_parser");
String text_parser = pd.text_parser("Thrilling contest between Manchester City and Manchester United ends in a draw.");
Console.WriteLine(text_parser);


Console.WriteLine("usage");
String usage = pd.usage();
Console.WriteLine(usage);

```
