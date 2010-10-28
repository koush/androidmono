namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GestureLibraries : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GestureLibraries(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _fromFile4881;
		public static global::android.gesture.GestureLibrary fromFile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._fromFile4881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.gesture.GestureLibrary;
		}
		internal static global::MonoJavaBridge.MethodId _fromFile4882;
		public static global::android.gesture.GestureLibrary fromFile(java.io.File arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._fromFile4882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.gesture.GestureLibrary;
		}
		internal static global::MonoJavaBridge.MethodId _fromPrivateFile4883;
		public static global::android.gesture.GestureLibrary fromPrivateFile(android.content.Context arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._fromPrivateFile4883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.gesture.GestureLibrary;
		}
		internal static global::MonoJavaBridge.MethodId _fromRawResource4884;
		public static global::android.gesture.GestureLibrary fromRawResource(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._fromRawResource4884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.gesture.GestureLibrary;
		}
		static GestureLibraries()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureLibraries.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureLibraries"));
			global::android.gesture.GestureLibraries._fromFile4881 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureLibraries.staticClass, "fromFile", "(Ljava/lang/String;)Landroid/gesture/GestureLibrary;");
			global::android.gesture.GestureLibraries._fromFile4882 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureLibraries.staticClass, "fromFile", "(Ljava/io/File;)Landroid/gesture/GestureLibrary;");
			global::android.gesture.GestureLibraries._fromPrivateFile4883 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureLibraries.staticClass, "fromPrivateFile", "(Landroid/content/Context;Ljava/lang/String;)Landroid/gesture/GestureLibrary;");
			global::android.gesture.GestureLibraries._fromRawResource4884 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureLibraries.staticClass, "fromRawResource", "(Landroid/content/Context;I)Landroid/gesture/GestureLibrary;");
		}
		internal static void InitJNI()
		{
		}
	}
}
