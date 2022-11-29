﻿
// This file was auto-generated by ML.NET Model Builder. 

using TweetsClassification;

// Create single instance of sample data from first line of dataset for model input
TextClassifier.ModelInput sampleData = new TextClassifier.ModelInput()
{
    Retweets = 755F,
    Likes = 26737F,
    Cleaned_Tweets = @"Absolutely",
};

// Make a single prediction on the sample data and print results
var predictionResult = TextClassifier.Predict(sampleData);

Console.WriteLine("Using model to make single prediction -- Comparing actual IsFake with predicted IsFake from sample data...\n\n");


Console.WriteLine($"Retweets: {755F}");
Console.WriteLine($"Likes: {26737F}");
Console.WriteLine($"Cleaned_Tweets: {@"Absolutely"}");


Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();
