using System;
using System.Collections.Generic;
using System.Text;

namespace PostIt
{
    struct PostIt
    {
        public string BackgroundColor;
        public string TextColor;
        public string Text;

        public PostIt(string BackgroundColor, string TextColor, string Text)
        {
            this.BackgroundColor = BackgroundColor;
            this.TextColor = TextColor;
            this.Text = Text;
        }
    }
}
