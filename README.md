# Getting Practical With ML.Net
This repository contains the demo material for Microsoft Reactor series "Getting  Practical With ML.Net".

In the near future, every application on every platform will incorporate some form of machine learning capabilities, empowering the application itself and making it smarter. In this series, you learn how the ML.NET framework has been designed to democratise the art of machine learning, converting it into a technology available to all developers around the globe. 

* Speakers: [Carlotta Castelluccio](https://www.linkedin.com/in/carlotta-castelluccio/), Academic Cloud Advocate at Microsoft &
            [Liam Hampton](https://www.linkedin.com/in/liam-conroy-hampton), Regional Cloud Advocate at Microsoft
* Series page: [Getting Practical With ML.Net](https://developer.microsoft.com/en-us/reactor/series/S-1059/?WT.mc_id=academic-82020-cacaste) 
* Cloud Skills Challenge: [Join the Challenge](https://aka.ms/ML.NETSeries?WT.mc_id=academic-82020-cacaste)

## Demo
### Pre-requisites
To set up your local environment and run the ML.NET project you need to configure the following pre-requisites:
* [Visual Studio 2022 Community](https://aka.ms/install-visual-studio?WT.mc_id=academic-82020-cacaste)
* [.Net 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0?WT.mc_id=academic-82020-cacaste)
* [Model Builder](https://marketplace.visualstudio.com/items?itemName=MLNET.ModelBuilder2022?WT.mc_id=academic-82020-cacaste)

### Description
The goal of this demo is to showcase how to build a text classification model with ML.NET locally, integrate it in a web application and deploy it to the cloud. No advanced data science skills required.

In a virtual world, where there are thousands of sources of information across the web, bots posting on social medias and AI generating fake news, it's hard to find the truth. In this demo, we'll be training a text classification model able to predict if a Tweet is fake or not, based on a historical dataset of Tweets published by Elon Musk in 2022 ([original dataset](https://www.kaggle.com/datasets/marta99/elon-musks-tweets-dataset-2022)).  

*TweetsClassification* is a console application that allows the user to retrain the ML pipeline initially built with a low code approach (using Model Builder, a UI VS extension), by tweaking some hyperparameters to improve performance and save it as a zip file. It also enables the user to consume the trained ML model, by typing the input text to use for the prediction. 

*TweetsClassifierRazor* is an ASP.NET Razor Pages web app which consumes the same ML.NET pre-trained text classifier model, by enabling the user to interact with it using a simple graphical user interface. The app code is similar to the code of [this tutorial](https://learn.microsoft.com/en-us/dotnet/machine-learning/tutorials/sentiment-analysis-model-builder?WT.mc_id=academic-82020-cacaste), but it uses the classifier for fake Tweets detection rather than the original sentiment analysis model.

### Useful Resources
* [ML.NET samples](https://github.com/dotnet/machinelearning-samples/blob/main/README.md?WT.mc_id=academic-82020-cacaste)
* [ML.NET docs](https://learn.microsoft.com/en-gb/dotnet/machine-learning/?WT.mc_id=academic-82020-cacaste)
