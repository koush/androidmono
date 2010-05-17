namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SurfaceHolder 
	{ 
		void setType(int arg0); 
		void setFormat(int arg0); 
		void setKeepScreenOn(bool arg0); 
		void addCallback(android.view.SurfaceHolder_Callback arg0); 
		void removeCallback(android.view.SurfaceHolder_Callback arg0); 
		bool isCreating(); 
		void setFixedSize(int arg0, int arg1); 
		void setSizeFromLayout(); 
		android.graphics.Canvas lockCanvas(); 
		android.graphics.Canvas lockCanvas(android.graphics.Rect arg0); 
		void unlockCanvasAndPost(android.graphics.Canvas arg0); 
		android.graphics.Rect getSurfaceFrame(); 
		android.view.Surface getSurface(); 
	} 
} 
