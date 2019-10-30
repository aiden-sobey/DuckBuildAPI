using System;
using System.ComponentModel.DataAnnotations;

namespace DuckBuildAPI
{
    public class Quack
    {
        [Key]
        public int DuckId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        public bool QuackStatus { get; set; }
    }
}
