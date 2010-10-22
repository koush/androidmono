namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AutoText : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AutoText()
		{
			InitJNI();
		}
		protected AutoText(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get12634;
		public static global::java.lang.String get(java.lang.CharSequence arg0, int arg1, int arg2, android.view.View arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.AutoText.staticClass, global::android.text.AutoText._get12634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSize12635;
		public static int getSize(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.AutoText.staticClass, global::android.text.AutoText._getSize12635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.AutoText.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/AutoText"));
			global::android.text.AutoText._get12634 = @__env.GetStaticMethodIDNoThrow(global::android.text.AutoText.staticClass, "get", "(Ljava/lang/CharSequence;IILandroid/view/View;)Ljava/lang/String;");
			global::android.text.AutoText._getSize12635 = @__env.GetStaticMethodIDNoThrow(global::android.text.AutoText.staticClass, "getSize", "(Landroid/view/View;)I");
		}
	}
}
