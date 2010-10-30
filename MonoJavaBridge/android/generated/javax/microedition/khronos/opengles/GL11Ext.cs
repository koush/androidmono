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
		private static global::MonoJavaBridge.MethodId _m0;
		void javax.microedition.khronos.opengles.GL11Ext.glEnable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glEnable", "(I)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.microedition.khronos.opengles.GL11Ext.glEnableClientState(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glEnableClientState", "(I)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void javax.microedition.khronos.opengles.GL11Ext.glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glTexParameterfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexsOES(short arg0, short arg1, short arg2, short arg3, short arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexsOES", "(SSSSS)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexiOES(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexiOES", "(IIIII)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexxOES(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexxOES", "(IIIII)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexsvOES(java.nio.ShortBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexsvOES", "(Ljava/nio/ShortBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexsvOES(short[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexsvOES", "([SI)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexivOES(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexivOES", "([II)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexivOES(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexivOES", "(Ljava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexxvOES(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexxvOES", "([II)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexxvOES(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexxvOES", "(Ljava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexfOES(float arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexfOES", "(FFFFF)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexfvOES(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexfvOES", "(Ljava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void javax.microedition.khronos.opengles.GL11Ext.glDrawTexfvOES(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexfvOES", "([FI)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void javax.microedition.khronos.opengles.GL11Ext.glCurrentPaletteMatrixOES(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glCurrentPaletteMatrixOES", "(I)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void javax.microedition.khronos.opengles.GL11Ext.glLoadPaletteFromModelViewMatrixOES()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glLoadPaletteFromModelViewMatrixOES", "()V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void javax.microedition.khronos.opengles.GL11Ext.glMatrixIndexPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glMatrixIndexPointerOES", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void javax.microedition.khronos.opengles.GL11Ext.glMatrixIndexPointerOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glMatrixIndexPointerOES", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void javax.microedition.khronos.opengles.GL11Ext.glWeightPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glWeightPointerOES", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		void javax.microedition.khronos.opengles.GL11Ext.glWeightPointerOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glWeightPointerOES", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11Ext_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
