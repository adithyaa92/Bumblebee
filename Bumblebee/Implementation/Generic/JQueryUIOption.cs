using Bumblebee.Interfaces.Generic;
using OpenQA.Selenium;

namespace Bumblebee.Implementation.Generic
{
    public class JQueryUIOption<TResult> : Clickable<TResult>, IOption<TResult> where TResult : Block
    {
        public JQueryUIOption(Block parent, By by) : base(parent, by)
        {
        }

        public JQueryUIOption(Block parent, IWebElement element) : base(parent, element)
        {
        }
        
        public override bool Selected { get { return Dom.GetAttribute("aria-selected") != "true"; } }
    }
}