namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AutoText : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AutoText(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get12692;
		public static global::java.lang.String get(java.lang.CharSequence arg0, int arg1, int arg2, android.view.View arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.AutoText._get12692.native == global::System.IntPtr.Zero)
				global::android.text.AutoText._get12692 = @__env.GetStaticMethodIDNoThrow(global::android.text.AutoText.staticClass, "get", "(Ljava/lang/CharSequence;IILandroid/view/View;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.AutoText.staticClass, global::android.text.AutoText._get12692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
		}
		public static java.lang.String get(string arg0, int arg1, int arg2, android.view.View arg3)
		{
			return get((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _getSize12693;
		public static int getSize(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.AutoText._getSize12693.native == global::System.IntPtr.Zero)
				global::android.text.AutoText._getSize12693 = @__env.GetStaticMethodIDNoThrow(global::android.text.AutoText.staticClass, "getSize", "(Landroid/view/View;)I");
			return @__env.CallStaticIntMethod(android.text.AutoText.staticClass, global::android.text.AutoText._getSize12693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AutoText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.AutoText.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/AutoText"));
		}
		internal static void InitJNI()
		{
		}
	}
}
