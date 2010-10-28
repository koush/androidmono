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
		internal static global::MonoJavaBridge.MethodId _getInstance12930;
		public static global::android.text.Spannable_Factory getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.Spannable_Factory.staticClass, global::android.text.Spannable_Factory._getInstance12930)) as android.text.Spannable_Factory;
		}
		internal static global::MonoJavaBridge.MethodId _newSpannable12931;
		public virtual global::android.text.Spannable newSpannable(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Spannable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Spannable_Factory._newSpannable12931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Spannable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Spannable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Spannable_Factory.staticClass, global::android.text.Spannable_Factory._newSpannable12931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Spannable;
		}
		public android.text.Spannable newSpannable(string arg0)
		{
			return newSpannable((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _Spannable_Factory12932;
		public Spannable_Factory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Spannable_Factory.staticClass, global::android.text.Spannable_Factory._Spannable_Factory12932);
			Init(@__env, handle);
		}
		static Spannable_Factory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Spannable_Factory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Spannable$Factory"));
			global::android.text.Spannable_Factory._getInstance12930 = @__env.GetStaticMethodIDNoThrow(global::android.text.Spannable_Factory.staticClass, "getInstance", "()Landroid/text/Spannable$Factory;");
			global::android.text.Spannable_Factory._newSpannable12931 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_Factory.staticClass, "newSpannable", "(Ljava/lang/CharSequence;)Landroid/text/Spannable;");
			global::android.text.Spannable_Factory._Spannable_Factory12932 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_Factory.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
