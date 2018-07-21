using System;
using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Meter : Tag, SupportFormAttribute
    {
        private double? _min, _max, _high, _low;
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Meter(double value) : base("meter")
        {
            AddAttribute("value", value.ToString());
        }

        public void AddMin(double value)
        {
            if (value > _low || value > _high || value > _max) { throw new ArgumentException(); }
            _min = value;
            AddAttribute("min", _min.Value.ToString());
        }

        public void AddMax(double value)
        {
            if (value < _min || value < _low || value < _high) { throw new ArgumentException(); }
            _max = value;
            AddAttribute("max", _max.Value.ToString());
        }

        public void AddLow(double value)
        {
            if (value < _min || value > _high || value > _max) { throw new ArgumentException(); }
            _low = value;
            AddAttribute("low", _low.Value.ToString());
        }
        public void AddHigh(double value)
        {
            if (value < _min || value < _low || value > _max) { throw new ArgumentException(); }
            _high = value;
            AddAttribute("high", _high.Value.ToString());
        }

        public void AddOptimum(double value)
        {
            AddAttribute("optimum", value.ToString());            
        }
    }
}