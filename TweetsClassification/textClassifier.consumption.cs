﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;

namespace TweetsClassification
{
    public partial class TextClassifier
    {
        /// <summary>
        /// model input class for TextClassifier.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"Cleaned_Tweets")]
            public string Cleaned_Tweets { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"IsFake")]
            public bool IsFake { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for TextClassifier.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"Cleaned_Tweets")]
            public string Cleaned_Tweets { get; set; }

            [ColumnName(@"IsFake")]
            public uint IsFake { get; set; }

            [ColumnName(@"PredictedLabel")]
            public bool PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float[] Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("textClassifier.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();

            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);

            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}