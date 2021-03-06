﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gherkin.Pickles
{
    public class PickleStep
    {
        public string Text { get; private set; }
        public IEnumerable<Argument> Arguments { get; private set; }
        public IEnumerable<PickleLocation> Locations { get; private set; }

        public PickleStep(string text, IEnumerable<Argument> arguments, IEnumerable<PickleLocation> locations)
        {
            Text = text;
            Arguments = arguments;
            Locations = locations;
        }
    }
}
