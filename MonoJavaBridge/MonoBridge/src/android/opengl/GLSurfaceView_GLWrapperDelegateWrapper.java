package android.opengl;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class GLSurfaceView_GLWrapperDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.opengl.GLSurfaceView.GLWrapper
{
	static
	{
		MonoBridge.link(GLSurfaceView_GLWrapperDelegateWrapper.class, "wrap", "(Ljavax/microedition/khronos/opengles/GL;)Ljavax/microedition/khronos/opengles/GL;", "javax.microedition.khronos.opengles.GL");

	}

	@Override
	public native javax.microedition.khronos.opengles.GL wrap(javax.microedition.khronos.opengles.GL arg0);



}
