using System;
using System.Collections.Generic;
using System.Text;

namespace Vertmarkets.Contracts.Model
{
    public class AnswerResponse
    {
        public Data Data { get; set; }
        public bool Success { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
    public class Data
    {
        public string TotalTime { get; set; }
        public bool AnswerCorrect { get; set; }
        public List<string> ShouldBe { get; set; }
    }
}
