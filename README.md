# AnkiCardCreator

Application helps to create Anki Card, it translate a word from En-Ru and Ru-En, get transcription and find images for this word.
Anki card must have next fields:
1. Question
2. Answer
3. Transcription
4. Image source.

The output generates into import.txt - file, which will be saved in selected directory and contains next values (for example):
word;translation;transcription;image source
fox;лисица;[fɔks];<img src="fox.jpg">

The image will be copied into selected directory for anki-content.

Click right mouse button on the AnkiCardCreator form to open and change settings:
1. Change Anki card content folder
2. Change Anki import.txt file folder
3. Change or add Pixabay Image Searcher Api-Key, which are using for search and download images.
