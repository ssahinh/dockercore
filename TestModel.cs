using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace DockerTest
{
    public class TestModel
    {
        [Key]
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
    }
}