package android.opengl;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class GLSurfaceView_EGLConfigChooserDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.opengl.GLSurfaceView.EGLConfigChooser
{
	static
	{
		MonoBridge.link(GLSurfaceView_EGLConfigChooserDelegateWrapper.class, "chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;)Ljavax/microedition/khronos/egl/EGLConfig;", "javax.microedition.khronos.egl.EGL10,javax.microedition.khronos.egl.EGLDisplay");

	}

	@Override
	public native javax.microedition.khronos.egl.EGLConfig chooseConfig(javax.microedition.khronos.egl.EGL10 arg0,javax.microedition.khronos.egl.EGLDisplay arg1);



}
