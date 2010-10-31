namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GLUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GLUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static int getType(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._m0.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "getType", "(Landroid/graphics/Bitmap;)I");
			return @__env.CallStaticIntMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int getInternalFormat(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._m1.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "getInternalFormat", "(Landroid/graphics/Bitmap;)I");
			return @__env.CallStaticIntMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void texImage2D(int arg0, int arg1, int arg2, android.graphics.Bitmap arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._m2.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texImage2D", "(IIILandroid/graphics/Bitmap;II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void texImage2D(int arg0, int arg1, int arg2, android.graphics.Bitmap arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._m3.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._m3 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texImage2D", "(IIILandroid/graphics/Bitmap;I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void texImage2D(int arg0, int arg1, android.graphics.Bitmap arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._m4.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._m4 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texImage2D", "(IILandroid/graphics/Bitmap;I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void texSubImage2D(int arg0, int arg1, int arg2, int arg3, android.graphics.Bitmap arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._m5.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._m5 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texSubImage2D", "(IIIILandroid/graphics/Bitmap;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void texSubImage2D(int arg0, int arg1, int arg2, int arg3, android.graphics.Bitmap arg4, int arg5, int arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._m6.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._m6 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texSubImage2D", "(IIIILandroid/graphics/Bitmap;II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		static GLUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLUtils"));
		}
	}
}
