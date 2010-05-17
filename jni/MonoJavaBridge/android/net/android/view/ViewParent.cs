namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ViewParent 
	{ 
		android.view.ViewParent getParent(); 
		android.view.View focusSearch(android.view.View arg0, int arg1); 
		void createContextMenu(android.view.ContextMenu arg0); 
		bool isLayoutRequested(); 
		void requestLayout(); 
		void requestChildFocus(android.view.View arg0, android.view.View arg1); 
		void focusableViewAvailable(android.view.View arg0); 
		bool showContextMenuForChild(android.view.View arg0); 
		bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2); 
		void clearChildFocus(android.view.View arg0); 
		void recomputeViewAttributes(android.view.View arg0); 
		void bringChildToFront(android.view.View arg0); 
		void requestDisallowInterceptTouchEvent(bool arg0); 
		void invalidateChild(android.view.View arg0, android.graphics.Rect arg1); 
		android.view.ViewParent invalidateChildInParent(int[] arg0, android.graphics.Rect arg1); 
		bool getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2); 
		void requestTransparentRegion(android.view.View arg0); 
		void childDrawableStateChanged(android.view.View arg0); 
	} 
} 
