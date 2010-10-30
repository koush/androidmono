namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GLUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GLUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getType9465;
		public static int getType(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._getType9465.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._getType9465 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "getType", "(Landroid/graphics/Bitmap;)I");
			return @__env.CallStaticIntMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._getType9465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInternalFormat9466;
		public static int getInternalFormat(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._getInternalFormat9466.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._getInternalFormat9466 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "getInternalFormat", "(Landroid/graphics/Bitmap;)I");
			return @__env.CallStaticIntMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._getInternalFormat9466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _texImage2D9467;
		public static void texImage2D(int arg0, int arg1, int arg2, android.graphics.Bitmap arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._texImage2D9467.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._texImage2D9467 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texImage2D", "(IIILandroid/graphics/Bitmap;II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._texImage2D9467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _texImage2D9468;
		public static void texImage2D(int arg0, int arg1, int arg2, android.graphics.Bitmap arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._texImage2D9468.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._texImage2D9468 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texImage2D", "(IIILandroid/graphics/Bitmap;I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._texImage2D9468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _texImage2D9469;
		public static void texImage2D(int arg0, int arg1, android.graphics.Bitmap arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._texImage2D9469.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._texImage2D9469 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texImage2D", "(IILandroid/graphics/Bitmap;I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._texImage2D9469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _texSubImage2D9470;
		public static void texSubImage2D(int arg0, int arg1, int arg2, int arg3, android.graphics.Bitmap arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._texSubImage2D9470.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._texSubImage2D9470 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texSubImage2D", "(IIIILandroid/graphics/Bitmap;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._texSubImage2D9470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _texSubImage2D9471;
		public static void texSubImage2D(int arg0, int arg1, int arg2, int arg3, android.graphics.Bitmap arg4, int arg5, int arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLUtils._texSubImage2D9471.native == global::System.IntPtr.Zero)
				global::android.opengl.GLUtils._texSubImage2D9471 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texSubImage2D", "(IIIILandroid/graphics/Bitmap;II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._texSubImage2D9471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		static GLUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLUtils"));
		}
		internal static void InitJNI()
		{
		}
	}
}
