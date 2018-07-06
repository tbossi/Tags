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
            TagBuilder.MergeAttribute("value", value.ToString());
        }

        public void AddMin(double value)
        {
            if (value > _low || value > _high || value > _max) { throw new ArgumentException(); }
            _min = value;
            TagBuilder.MergeAttribute("min", _min.Value.ToString());
        }

        public void AddMax(double value)
        {
            if (value < _min || value < _low || value < _high) { throw new ArgumentException(); }
            _max = value;
            TagBuilder.MergeAttribute("max", _max.Value.ToString());
        }

        public void AddLow(double value)
        {
            if (value < _min || value > _high || value > _max) { throw new ArgumentException(); }
            _low = value;
            TagBuilder.MergeAttribute("low", _low.Value.ToString());
        }
        public void AddHigh(double value)
        {
            if (value < _min || value < _low || value > _max) { throw new ArgumentException(); }
            _high = value;
            TagBuilder.MergeAttribute("high", _high.Value.ToString());
        }

        public void AddOptimum(double value)
        {
            TagBuilder.MergeAttribute("optimum", value.ToString());            
        }
    }
}