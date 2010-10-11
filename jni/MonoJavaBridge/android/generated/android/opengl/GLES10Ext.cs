namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLES10Ext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GLES10Ext()
		{
			InitJNI();
		}
		protected GLES10Ext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glQueryMatrixxOES5675;
		public static int glQueryMatrixxOES(int[] arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES10Ext.staticClass, global::android.opengl.GLES10Ext._glQueryMatrixxOES5675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glQueryMatrixxOES5676;
		public static int glQueryMatrixxOES(java.nio.IntBuffer arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES10Ext.staticClass, global::android.opengl.GLES10Ext._glQueryMatrixxOES5676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _GLES10Ext5677;
		public GLES10Ext()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLES10Ext.staticClass, global::android.opengl.GLES10Ext._GLES10Ext5677);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLES10Ext.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLES10Ext"));
			global::android.opengl.GLES10Ext._glQueryMatrixxOES5675 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10Ext.staticClass, "glQueryMatrixxOES", "([II[II)I");
			global::android.opengl.GLES10Ext._glQueryMatrixxOES5676 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10Ext.staticClass, "glQueryMatrixxOES", "(Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;)I");
			global::android.opengl.GLES10Ext._GLES10Ext5677 = @__env.GetMethodIDNoThrow(global::android.opengl.GLES10Ext.staticClass, "<init>", "()V");
		}
	}
}
