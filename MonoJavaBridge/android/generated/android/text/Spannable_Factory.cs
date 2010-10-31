namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Spannable_Factory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Spannable_Factory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.text.Spannable_Factory Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.text.Spannable_Factory getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Spannable_Factory._m0.native == global::System.IntPtr.Zero)
				global::android.text.Spannable_Factory._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.Spannable_Factory.staticClass, "getInstance", "()Landroid/text/Spannable$Factory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.Spannable_Factory.staticClass, global::android.text.Spannable_Factory._m0)) as android.text.Spannable_Factory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.text.Spannable newSpannable(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Spannable>(this, global::android.text.Spannable_Factory.staticClass, "newSpannable", "(Ljava/lang/CharSequence;)Landroid/text/Spannable;", ref global::android.text.Spannable_Factory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.text.Spannable;
		}
		public android.text.Spannable newSpannable(string arg0)
		{
			return newSpannable((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public Spannable_Factory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Spannable_Factory._m2.native == global::System.IntPtr.Zero)
				global::android.text.Spannable_Factory._m2 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_Factory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Spannable_Factory.staticClass, global::android.text.Spannable_Factory._m2);
			Init(@__env, handle);
		}
		static Spannable_Factory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Spannable_Factory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Spannable$Factory"));
		}
	}
}
