namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Editable_Factory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Editable_Factory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.text.Editable_Factory Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.text.Editable_Factory getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Editable_Factory._m0.native == global::System.IntPtr.Zero)
				global::android.text.Editable_Factory._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.Editable_Factory.staticClass, "getInstance", "()Landroid/text/Editable$Factory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.Editable_Factory.staticClass, global::android.text.Editable_Factory._m0)) as android.text.Editable_Factory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.text.Editable newEditable(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.text.Editable_Factory.staticClass, "newEditable", "(Ljava/lang/CharSequence;)Landroid/text/Editable;", ref global::android.text.Editable_Factory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.text.Editable;
		}
		public android.text.Editable newEditable(string arg0)
		{
			return newEditable((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public Editable_Factory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Editable_Factory._m2.native == global::System.IntPtr.Zero)
				global::android.text.Editable_Factory._m2 = @__env.GetMethodIDNoThrow(global::android.text.Editable_Factory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Editable_Factory.staticClass, global::android.text.Editable_Factory._m2);
			Init(@__env, handle);
		}
		static Editable_Factory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Editable_Factory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Editable$Factory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
