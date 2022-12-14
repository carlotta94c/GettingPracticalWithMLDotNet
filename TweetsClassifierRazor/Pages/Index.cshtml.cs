using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.ML;
using static TweetsClassifierRazor.TextClassifier;

namespace TweetsClassifierRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PredictionEnginePool<ModelInput, ModelOutput> _predictionEnginePool;

        // Injecting PredictionEnginePool configured in Program.cs into IndexModel constructor
        // And storing it in a class variable (_predictionEnginePool)
        public IndexModel(ILogger<IndexModel> logger, PredictionEnginePool<ModelInput, ModelOutput> predictionEnginePool)
        {
            _logger = logger;
            _predictionEnginePool = predictionEnginePool;
        }

        public void OnGet()
        {

        }

        // Method handler using the PredictionEnginePool to make predictions from user input
        public IActionResult OnGetAnalyzeTweet([FromQuery] string text)
        {
            if (String.IsNullOrEmpty(text)) return Content("Checking");

            var input = new ModelInput { Cleaned_Tweets = text };

            var prediction = _predictionEnginePool.Predict(input);

            var isFake = Convert.ToBoolean(prediction.PredictedLabel) ? "Fake" : "Not Fake";

            return Content(isFake);
        }
    }
}