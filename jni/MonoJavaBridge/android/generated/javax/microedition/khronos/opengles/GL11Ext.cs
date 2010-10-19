namespace javax.microedition.khronos.opengles
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.opengles.GL11Ext_))]
	public interface GL11Ext : GL
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
	public sealed partial class GL11Ext_ : java.lang.Object, GL11Ext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GL11Ext_()
		{
			InitJNI();
		}
		internal GL11Ext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glEnable23185;
		 void javax.microedition.khronos.opengles.GL11Ext.glEnable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glEnable23185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glEnable23185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glEnableClientState23186;
		 void javax.microedition.khronos.opengles.GL11Ext.glEnableClientState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glEnableClientState23186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glEnableClientState23186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv23187;
		 void javax.microedition.khronos.opengles.GL11Ext.glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glTexParameterfv23187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glTexParameterfv23187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexsOES23188;
		 void javax.microedition.khronos.opengles.GL11Ext.glDrawTexsOES(short arg0, short arg1, short arg2, short arg3, short arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexsOES23188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexsOES23188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexiOES23189;
		 void javax.microedition.khronos.opengles.GL11Ext.glDrawTexiOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexiOES23189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexiOES23189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexxOES23190;
		 void javax.microedition.khronos.opengles.GL11Ext.glDrawTexxOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexxOES23190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexxOES23190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexsvOES23191;
		 void javax.microedition.khronos.opengles.GL11Ext.glDrawTexsvOES(java.nio.ShortBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexsvOES23191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexsvOES23191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexsvOES23192;
		 void javax.microedition.khronos.opengles.GL11Ext.glDrawTexsvOES(short[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexsvOES23192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexsvOES23192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexivOES23193;
		 void javax.microedition.khronos.opengles.GL11Ext.glDrawTexivOES(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexivOES23193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexivOES23193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexivOES23194;
		 void javax.microedition.khronos.opengles.GL11Ext.glDrawTexivOES(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexivOES23194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexivOES23194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexxvOES23195;
		 void javax.microedition.khronos.opengles.GL11Ext.glDrawTexxvOES(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexxvOES23195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexxvOES23195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexxvOES23196;
		 void javax.microedition.khronos.opengles.GL11Ext.glDrawTexxvOES(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexxvOES23196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexxvOES23196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexfOES23197;
		 void javax.microedition.khronos.opengles.GL11Ext.glDrawTexfOES(float arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexfOES23197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexfOES23197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexfvOES23198;
		 void javax.microedition.khronos.opengles.GL11Ext.glDrawTexfvOES(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexfvOES23198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexfvOES23198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexfvOES23199;
		 void javax.microedition.khronos.opengles.GL11Ext.glDrawTexfvOES(float[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexfvOES23199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexfvOES23199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glCurrentPaletteMatrixOES23200;
		 void javax.microedition.khronos.opengles.GL11Ext.glCurrentPaletteMatrixOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glCurrentPaletteMatrixOES23200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glCurrentPaletteMatrixOES23200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadPaletteFromModelViewMatrixOES23201;
		 void javax.microedition.khronos.opengles.GL11Ext.glLoadPaletteFromModelViewMatrixOES() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glLoadPaletteFromModelViewMatrixOES23201);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glLoadPaletteFromModelViewMatrixOES23201);
		}
		internal static global::MonoJavaBridge.MethodId _glMatrixIndexPointerOES23202;
		 void javax.microedition.khronos.opengles.GL11Ext.glMatrixIndexPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glMatrixIndexPointerOES23202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glMatrixIndexPointerOES23202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMatrixIndexPointerOES23203;
		 void javax.microedition.khronos.opengles.GL11Ext.glMatrixIndexPointerOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glMatrixIndexPointerOES23203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glMatrixIndexPointerOES23203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glWeightPointerOES23204;
		 void javax.microedition.khronos.opengles.GL11Ext.glWeightPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glWeightPointerOES23204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glWeightPointerOES23204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glWeightPointerOES23205;
		 void javax.microedition.khronos.opengles.GL11Ext.glWeightPointerOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_._glWeightPointerOES23205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, global::javax.microedition.khronos.opengles.GL11Ext_._glWeightPointerOES23205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL11Ext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL11Ext"));
			global::javax.microedition.khronos.opengles.GL11Ext_._glEnable23185 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glEnable", "(I)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glEnableClientState23186 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glEnableClientState", "(I)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glTexParameterfv23187 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glTexParameterfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexsOES23188 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexsOES", "(SSSSS)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexiOES23189 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexiOES", "(IIIII)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexxOES23190 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexxOES", "(IIIII)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexsvOES23191 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexsvOES", "(Ljava/nio/ShortBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexsvOES23192 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexsvOES", "([SI)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexivOES23193 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexivOES", "([II)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexivOES23194 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexivOES", "(Ljava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexxvOES23195 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexxvOES", "([II)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexxvOES23196 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexxvOES", "(Ljava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexfOES23197 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexfOES", "(FFFFF)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexfvOES23198 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexfvOES", "(Ljava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glDrawTexfvOES23199 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glDrawTexfvOES", "([FI)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glCurrentPaletteMatrixOES23200 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glCurrentPaletteMatrixOES", "(I)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glLoadPaletteFromModelViewMatrixOES23201 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glLoadPaletteFromModelViewMatrixOES", "()V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glMatrixIndexPointerOES23202 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glMatrixIndexPointerOES", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glMatrixIndexPointerOES23203 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glMatrixIndexPointerOES", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glWeightPointerOES23204 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glWeightPointerOES", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11Ext_._glWeightPointerOES23205 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11Ext_.staticClass, "glWeightPointerOES", "(IIII)V");
		}
	}
}
