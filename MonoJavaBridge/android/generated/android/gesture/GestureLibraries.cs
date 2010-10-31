namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GestureLibraries : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GestureLibraries(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.gesture.GestureLibrary fromFile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibraries._m0.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibraries._m0 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureLibraries.staticClass, "fromFile", "(Ljava/lang/String;)Landroid/gesture/GestureLibrary;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.gesture.GestureLibrary;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.gesture.GestureLibrary fromFile(java.io.File arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibraries._m1.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibraries._m1 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureLibraries.staticClass, "fromFile", "(Ljava/io/File;)Landroid/gesture/GestureLibrary;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.gesture.GestureLibrary;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.gesture.GestureLibrary fromPrivateFile(android.content.Context arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibraries._m2.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibraries._m2 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureLibraries.staticClass, "fromPrivateFile", "(Landroid/content/Context;Ljava/lang/String;)Landroid/gesture/GestureLibrary;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.gesture.GestureLibrary;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::android.gesture.GestureLibrary fromRawResource(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureLibraries._m3.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureLibraries._m3 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureLibraries.staticClass, "fromRawResource", "(Landroid/content/Context;I)Landroid/gesture/GestureLibrary;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.gesture.GestureLibrary;
		}
		static GestureLibraries()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureLibraries.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureLibraries"));
		}
	}
}
