using System.Collections;

namespace BIMTClassLibrary.GoogleSearch
{
    class UrlEntity
    {
        ArrayList back = new ArrayList(15);
        ArrayList forward = new ArrayList(5);

        public void ToNewPage(string url)
        {
            back.Add(url);
        }

        public string BackPage()
        {
            if (back.Count-2 >= 0)
            {
                string url = back[back.Count - 2].ToString();
                forward.Add(back[back.Count - 1].ToString());
                return url;
            }
            return "-1";
        }

        public string ForwardPage() {
            if (forward.Count > 0)
            {
                string url = forward[forward.Count - 1].ToString();
                back.Add(url);
                return url;
            }
            return "-1";
        }
    }
}
