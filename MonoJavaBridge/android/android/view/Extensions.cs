using System;

namespace android.view
{
    public static class Extensions
    {
        public static MenuItem @add(this Menu menu, string arg0)
        {
            return menu.@add((java.lang.CharSequence)(java.lang.String)arg0);
        }
        
        public static void setOnMenuItemClickListener(this MenuItem menuItem, MenuItem_OnMenuItemClickListenerDelegate arg0)
        {
            menuItem.setOnMenuItemClickListener((MenuItem_OnMenuItemClickListenerDelegateWrapper)arg0);
        }
    }
}

