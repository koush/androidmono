namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GLUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GLUtils()
		{
			InitJNI();
		}
		internal GLUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getType6096;
		public static int getType(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._getType6096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInternalFormat6097;
		public static int getInternalFormat(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._getInternalFormat6097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _texImage2D6098;
		public static void texImage2D(int arg0, int arg1, int arg2, android.graphics.Bitmap arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._texImage2D6098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _texImage2D6099;
		public static void texImage2D(int arg0, int arg1, int arg2, android.graphics.Bitmap arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._texImage2D6099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _texImage2D6100;
		public static void texImage2D(int arg0, int arg1, android.graphics.Bitmap arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._texImage2D6100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _texSubImage2D6101;
		public static void texSubImage2D(int arg0, int arg1, int arg2, int arg3, android.graphics.Bitmap arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._texSubImage2D6101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _texSubImage2D6102;
		public static void texSubImage2D(int arg0, int arg1, int arg2, int arg3, android.graphics.Bitmap arg4, int arg5, int arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, global::android.opengl.GLUtils._texSubImage2D6102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLUtils"));
			global::android.opengl.GLUtils._getType6096 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "getType", "(Landroid/graphics/Bitmap;)I");
			global::android.opengl.GLUtils._getInternalFormat6097 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "getInternalFormat", "(Landroid/graphics/Bitmap;)I");
			global::android.opengl.GLUtils._texImage2D6098 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texImage2D", "(IIILandroid/graphics/Bitmap;II)V");
			global::android.opengl.GLUtils._texImage2D6099 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texImage2D", "(IIILandroid/graphics/Bitmap;I)V");
			global::android.opengl.GLUtils._texImage2D6100 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texImage2D", "(IILandroid/graphics/Bitmap;I)V");
			global::android.opengl.GLUtils._texSubImage2D6101 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texSubImage2D", "(IIIILandroid/graphics/Bitmap;)V");
			global::android.opengl.GLUtils._texSubImage2D6102 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLUtils.staticClass, "texSubImage2D", "(IIIILandroid/graphics/Bitmap;II)V");
		}
	}
}
