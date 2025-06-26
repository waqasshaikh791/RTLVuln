using System.Collections.Generic;

namespace RTLVuln
{
    public class DeepseekPost
    {
        public string model { get; set; }
        public List<DeepseekMessages> messages { get; set; }
        public bool stream { get; set; }
    }

    public class DeepseekMessages
    {
        public string role { get; set; }
        public string content { get; set; }
    }

    public class Dataset
    {
        public string Instruction { get; set; }
        public List<string> Response { get; set; }
    }

    public class DatasetExport
    {
        public DatasetExport()
        {
            Instruction = "";
            Response = new List<string> { "" };
            VulnerableInstruction = "";
            VulnerableResponse = new List<string> { "" };
            VulnerabilityReason = "";
            Category = "";
            IsSyntax = "";
            IsFunctionality = "";

        }
        public string Instruction { get; set; }
        public List<string> Response { get; set; }
        public string VulnerableInstruction { get; set; }
        public List<string> VulnerableResponse { get; set; }
        public string VulnerabilityReason { get; set; }
        public string Category { get; set; }
        public string IsSyntax { get; set; }
        public string IsFunctionality { get; set; }
    }

    #region Deepseek Response

    public class ChatCompletionResponse
    {
        public string Id { get; set; }
        public string Object { get; set; }
        public long Created { get; set; }
        public string Model { get; set; }
        public List<Choice> Choices { get; set; }
        public Usage Usage { get; set; }
        public string SystemFingerprint { get; set; }
    }

    public class Choice
    {
        public int Index { get; set; }
        public Message Message { get; set; }
        public object Logprobs { get; set; }
        public string FinishReason { get; set; }
    }

    public class Message
    {
        public string Role { get; set; }
        public string Content { get; set; }
    }

    public class Usage
    {
        public int PromptTokens { get; set; }
        public int CompletionTokens { get; set; }
        public int TotalTokens { get; set; }
        public PromptTokensDetails PromptTokensDetails { get; set; }
        public int PromptCacheHitTokens { get; set; }
        public int PromptCacheMissTokens { get; set; }
    }

    public class PromptTokensDetails
    {
        public int CachedTokens { get; set; }
    }

    #endregion

}
