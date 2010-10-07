namespace android.gesture
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class GestureLibraries : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static GestureLibraries()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.gesture.GestureLibraries), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.gesture.GestureLibraries(@__env);
			}
		}
		internal GestureLibraries(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _fromFile2781;
		public static global::android.gesture.GestureLibrary fromFile(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.GestureLibrary>(@__env, @__env.CallStaticObjectMethodPtr(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._fromFile2781, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fromFile2782;
		public static global::android.gesture.GestureLibrary fromFile(java.io.File arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.GestureLibrary>(@__env, @__env.CallStaticObjectMethodPtr(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._fromFile2782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fromPrivateFile2783;
		public static global::android.gesture.GestureLibrary fromPrivateFile(android.content.Context arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.GestureLibrary>(@__env, @__env.CallStaticObjectMethodPtr(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._fromPrivateFile2783, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fromRawResource2784;
		public static global::android.gesture.GestureLibrary fromRawResource(android.content.Context arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.GestureLibrary>(@__env, @__env.CallStaticObjectMethodPtr(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._fromRawResource2784, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.gesture.GestureLibraries.staticClass = @__class;
			global::android.gesture.GestureLibraries._fromFile2781 = @__env.GetStaticMethodID(global::android.gesture.GestureLibraries.staticClass, "fromFile", "(Ljava/lang/String;)Landroid/gesture/GestureLibrary;");
			global::android.gesture.GestureLibraries._fromFile2782 = @__env.GetStaticMethodID(global::android.gesture.GestureLibraries.staticClass, "fromFile", "(Ljava/io/File;)Landroid/gesture/GestureLibrary;");
			global::android.gesture.GestureLibraries._fromPrivateFile2783 = @__env.GetStaticMethodID(global::android.gesture.GestureLibraries.staticClass, "fromPrivateFile", "(Landroid/content/Context;Ljava/lang/String;)Landroid/gesture/GestureLibrary;");
			global::android.gesture.GestureLibraries._fromRawResource2784 = @__env.GetStaticMethodID(global::android.gesture.GestureLibraries.staticClass, "fromRawResource", "(Landroid/content/Context;I)Landroid/gesture/GestureLibrary;");
		}
	}
}
