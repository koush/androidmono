namespace javax.microedition.khronos.opengles
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.opengles.GL10Ext_))]
	public partial interface GL10Ext : GL
	{
		int glQueryMatrixxOES(int[] arg0, int arg1, int[] arg2, int arg3);
		int glQueryMatrixxOES(java.nio.IntBuffer arg0, java.nio.IntBuffer arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.opengles.GL10Ext))]
	internal sealed partial class GL10Ext_ : java.lang.Object, GL10Ext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GL10Ext_()
		{
			InitJNI();
		}
		internal GL10Ext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glQueryMatrixxOES29317;
		 int javax.microedition.khronos.opengles.GL10Ext.glQueryMatrixxOES(int[] arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10Ext_._glQueryMatrixxOES29317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10Ext_.staticClass, global::javax.microedition.khronos.opengles.GL10Ext_._glQueryMatrixxOES29317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glQueryMatrixxOES29318;
		 int javax.microedition.khronos.opengles.GL10Ext.glQueryMatrixxOES(java.nio.IntBuffer arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10Ext_._glQueryMatrixxOES29318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10Ext_.staticClass, global::javax.microedition.khronos.opengles.GL10Ext_._glQueryMatrixxOES29318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL10Ext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL10Ext"));
			global::javax.microedition.khronos.opengles.GL10Ext_._glQueryMatrixxOES29317 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10Ext_.staticClass, "glQueryMatrixxOES", "([II[II)I");
			global::javax.microedition.khronos.opengles.GL10Ext_._glQueryMatrixxOES29318 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10Ext_.staticClass, "glQueryMatrixxOES", "(Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;)I");
		}
	}
}
