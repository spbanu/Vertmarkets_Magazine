using System;
using System.Collections.Generic;
using System.Text;

namespace Vertmarkets.Contracts.Model
{
    public class MagazinesResponse
    {
        public List<Magazine> Data { get; set; }
        public bool Success { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
    public class Magazine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }
}
