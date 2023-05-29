namespace page
{
    interface INavigation
    {
        string NavigationTo(Page page);
        string NavigationBack();
    }

    class Navigation : INavigation
    {
        private Stack<Page> _navigationStack;

        public Navigation()
        {
            _navigationStack = new Stack<Page>();
        }

        public string NavigationTo(Page page)
        {
            _navigationStack.Push(page);
            return "Navigation to: " + page;
        }

        public string NavigationBack()
        {
            if (_navigationStack.Count > 1)
            {
                _navigationStack.Pop();
                Page previousPage = _navigationStack.Peek();
                return "Navigation back to " + previousPage;
            }
            else
            {
                return "Cannot navigate back. Already on the first page.";
            }
        }
    }


}