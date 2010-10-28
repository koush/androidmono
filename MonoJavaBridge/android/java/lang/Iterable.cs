using System;
using System.Collections;

namespace java.lang
{
    public partial interface Iterable : global::System.Collections.IEnumerable
    {
    }
    
    static class IterableHelper
    {
        private class IteratorWrapper : IEnumerator
        {
            public IteratorWrapper(global::java.util.Iterator iterator)
            {
                mIterator = iterator;
            }
            
            global::java.util.Iterator mIterator;
            
            global::java.lang.Object mCurrent = null;
            
            public bool MoveNext()
            {
                if (!mIterator.hasNext())
                    return false;
                mCurrent = mIterator.next();
                return true;
            }

            public void Reset()
            {
                throw new InvalidOperationException("Unable to reset java.lang.Iterator");
            }

            public object Current {
                get {
                    return mCurrent;
                }
            }
        }
        
        public static global::System.Collections.IEnumerator WrapIterator(global::java.util.Iterator iter)
        {
            return new IteratorWrapper(iter);
        }
    }
}

