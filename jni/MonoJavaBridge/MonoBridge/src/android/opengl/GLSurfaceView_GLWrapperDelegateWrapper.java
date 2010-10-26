package android.opengl;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class GLSurfaceView_GLWrapperDelegateWrapper extends java.lang.Object implements MonoProxy, android.opengl.GLSurfaceView.GLWrapper
{
	static
	{
		MonoBridge.link(GLSurfaceView_GLWrapperDelegateWrapper.class, "wrap", "(Ljavax/microedition/khronos/opengles/GL;)Ljavax/microedition/khronos/opengles/GL;", "javax.microedition.khronos.opengles.GL");

	}

	@Override
	public native javax.microedition.khronos.opengles.GL wrap(javax.microedition.khronos.opengles.GL arg0);


	long myGCHandle;
	public long getGCHandle() {
		return myGCHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGCHandle = gcHandle;
	}

	@Override
	protected void finalize() throws Throwable {
	    super.finalize();
	    MonoBridge.releaseGCHandle(myGCHandle);
	}
}
