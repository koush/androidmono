namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Editable_Factory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Editable_Factory()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getInstance12739;
		public static global::android.text.Editable_Factory getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.Editable_Factory.staticClass, global::android.text.Editable_Factory._getInstance12739)) as android.text.Editable_Factory;
		}
		internal static global::MonoJavaBridge.MethodId _newEditable12740;
		public virtual global::android.text.Editable newEditable(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Editable_Factory._newEditable12740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Editable_Factory.staticClass, global::android.text.Editable_Factory._newEditable12740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Editable;
		}
		public android.text.Editable newEditable(string arg0)
		{
			return newEditable((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _Editable_Factory12741;
		public Editable_Factory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Editable_Factory.staticClass, global::android.text.Editable_Factory._Editable_Factory12741);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Editable_Factory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Editable$Factory"));
			global::android.text.Editable_Factory._getInstance12739 = @__env.GetStaticMethodIDNoThrow(global::android.text.Editable_Factory.staticClass, "getInstance", "()Landroid/text/Editable$Factory;");
			global::android.text.Editable_Factory._newEditable12740 = @__env.GetMethodIDNoThrow(global::android.text.Editable_Factory.staticClass, "newEditable", "(Ljava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.Editable_Factory._Editable_Factory12741 = @__env.GetMethodIDNoThrow(global::android.text.Editable_Factory.staticClass, "<init>", "()V");
		}
	}
}
