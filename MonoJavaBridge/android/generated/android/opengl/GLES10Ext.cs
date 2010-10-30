namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLES10Ext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GLES10Ext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glQueryMatrixxOES8511;
		public static int glQueryMatrixxOES(int[] arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10Ext._glQueryMatrixxOES8511.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10Ext._glQueryMatrixxOES8511 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10Ext.staticClass, "glQueryMatrixxOES", "([II[II)I");
			return @__env.CallStaticIntMethod(android.opengl.GLES10Ext.staticClass, global::android.opengl.GLES10Ext._glQueryMatrixxOES8511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glQueryMatrixxOES8512;
		public static int glQueryMatrixxOES(java.nio.IntBuffer arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10Ext._glQueryMatrixxOES8512.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10Ext._glQueryMatrixxOES8512 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10Ext.staticClass, "glQueryMatrixxOES", "(Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;)I");
			return @__env.CallStaticIntMethod(android.opengl.GLES10Ext.staticClass, global::android.opengl.GLES10Ext._glQueryMatrixxOES8512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _GLES10Ext8513;
		public GLES10Ext() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10Ext._GLES10Ext8513.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10Ext._GLES10Ext8513 = @__env.GetMethodIDNoThrow(global::android.opengl.GLES10Ext.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLES10Ext.staticClass, global::android.opengl.GLES10Ext._GLES10Ext8513);
			Init(@__env, handle);
		}
		static GLES10Ext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLES10Ext.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLES10Ext"));
		}
		internal static void InitJNI()
		{
		}
	}
}
