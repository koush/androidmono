namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateSorter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DateSorter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getIndex(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.DateSorter.staticClass, "getIndex", "(J)I", ref global::android.webkit.DateSorter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getLabel(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.DateSorter.staticClass, "getLabel", "(I)Ljava/lang/String;", ref global::android.webkit.DateSorter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual long getBoundary(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.webkit.DateSorter.staticClass, "getBoundary", "(I)J", ref global::android.webkit.DateSorter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public DateSorter(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.DateSorter._m3.native == global::System.IntPtr.Zero)
				global::android.webkit.DateSorter._m3 = @__env.GetMethodIDNoThrow(global::android.webkit.DateSorter.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.DateSorter.staticClass, global::android.webkit.DateSorter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int DAY_COUNT
		{
			get
			{
				return 5;
			}
		}
		static DateSorter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.DateSorter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/DateSorter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
