using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legbiter.Core.Models
{
    public class Bike : RootEntity
    {
        public string Registration { get; set; }
        public string FrameNumber { get; set; }
        public string Saddle { get; set; }
        public string Brakes { get; set; }
        public string Color { get; set; }
        public string Shifter { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime ModifiedOnUtc { get; set; }
        public List<Bike> History { get; set; }
        private Bike()
        {

        }
        public static Bike Create(string frameNumber)
        {
            var bike = new Bike() { FrameNumber = frameNumber };
            return bike;
        }
        //public void Update(Bike updates)
        //{
        //    var old = new Bike()
        //}
    }
}