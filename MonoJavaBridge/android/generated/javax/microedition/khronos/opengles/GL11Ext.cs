namespace javax.microedition.khronos.opengles
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.opengles.GL11Ext_))]
	public partial interface GL11Ext : GL
	{
		void glEnable(int arg0);
		void glEnableClientState(int arg0);
		void glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3);
		void glDrawTexsOES(short arg0, short arg1, short arg2, short arg3, short arg4);
		void glDrawTexiOES(int arg0, int arg1, int arg2, int arg3, int arg4);
		void glDrawTexxOES(int arg0, int arg1, int arg2, int arg3, int arg4);
		void glDrawTexsvOES(java.nio.ShortBuffer arg0);
		void glDrawTexsvOES(short[] arg0, int arg1);
		void glDrawTexivOES(int[] arg0, int arg1);
		void glDrawTexivOES(java.nio.IntBuffer arg0);
		void glDrawTexxvOES(int[] arg0, int arg1);
		void glDrawTexxvOES(java.nio.IntBuffer arg0);
		void glDrawTexfOES(float arg0, float arg1, float arg2, float arg3, float arg4);
		void glDrawTexfvOES(java.nio.FloatBuffer arg0);
		void glDrawTexfvOES(float[] arg0, int arg1);
		void glCurrentPaletteMatrixOES(int arg0);
		void glLoadPaletteFromModelViewMatrixOES();
		void glMatrixIndexPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3);
		void glMatrixIndexPointerOES(int arg0, int arg1, int arg2, int arg3);
		void glWeightPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3);
		void glWeightPointerOES(int arg0, int arg1, int arg2, int arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.opengles.GL11Ext))]
	internal sealed partial class GL11Ext_ : java.lang.Object, GL11Ext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GL11Ext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glEnable29633;
		void javax.microedition.khronos.opengles.GL11Ext.glEnable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glEnable", "(I)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glEnable29633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glEnableClientState29634;
		void javax.microedition.khronos.opengles.GL11Ext.glEnableClientState(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glEnableClientState", "(I)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glEnableClientState29634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv29635;
		void javax.microedition.khronos.opengles.GL11Ext.glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glTexParameterfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glTexParameterfv29635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexsOES29636;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexsOES(short arg0, short arg1, short arg2, short arg3, short arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexsOES", "(SSSSS)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexsOES29636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexiOES29637;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexiOES(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexiOES", "(IIIII)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexiOES29637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexxOES29638;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexxOES(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexxOES", "(IIIII)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexxOES29638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexsvOES29639;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexsvOES(java.nio.ShortBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexsvOES", "(Ljava/nio/ShortBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexsvOES29639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexsvOES29640;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexsvOES(short[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexsvOES", "([SI)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexsvOES29640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexivOES29641;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexivOES(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexivOES", "([II)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexivOES29641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexivOES29642;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexivOES(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexivOES", "(Ljava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexivOES29642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexxvOES29643;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexxvOES(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexxvOES", "([II)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexxvOES29643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexxvOES29644;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexxvOES(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexxvOES", "(Ljava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexxvOES29644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexfOES29645;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexfOES(float arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexfOES", "(FFFFF)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexfOES29645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexfvOES29646;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexfvOES(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexfvOES", "(Ljava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexfvOES29646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexfvOES29647;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexfvOES(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexfvOES", "([FI)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexfvOES29647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glCurrentPaletteMatrixOES29648;
		void javax.microedition.khronos.opengles.GL11Ext.glCurrentPaletteMatrixOES(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glCurrentPaletteMatrixOES", "(I)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glCurrentPaletteMatrixOES29648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadPaletteFromModelViewMatrixOES29649;
		void javax.microedition.khronos.opengles.GL11Ext.glLoadPaletteFromModelViewMatrixOES()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glLoadPaletteFromModelViewMatrixOES", "()V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glLoadPaletteFromModelViewMatrixOES29649);
		}
		internal static global::MonoJavaBridge.MethodId _glMatrixIndexPointerOES29650;
		void javax.microedition.khronos.opengles.GL11Ext.glMatrixIndexPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glMatrixIndexPointerOES", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glMatrixIndexPointerOES29650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMatrixIndexPointerOES29651;
		void javax.microedition.khronos.opengles.GL11Ext.glMatrixIndexPointerOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glMatrixIndexPointerOES", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glMatrixIndexPointerOES29651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glWeightPointerOES29652;
		void javax.microedition.khronos.opengles.GL11Ext.glWeightPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glWeightPointerOES", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glWeightPointerOES29652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glWeightPointerOES29653;
		void javax.microedition.khronos.opengles.GL11Ext.glWeightPointerOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glWeightPointerOES", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._glWeightPointerOES29653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static GL11Ext_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL11Ext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL11Ext"));
		}
		internal static void InitJNI()
		{
		}
	}
}
