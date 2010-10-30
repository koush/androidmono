namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateSorter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DateSorter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getIndex16035;
		public virtual int getIndex(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.DateSorter._getIndex16035.native == global::System.IntPtr.Zero)
				global::android.webkit.DateSorter._getIndex16035 = @__env.GetMethodIDNoThrow(global::android.webkit.DateSorter.staticClass, "getIndex", "(J)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.DateSorter.staticClass, global::android.webkit.DateSorter._getIndex16035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLabel16036;
		public virtual global::java.lang.String getLabel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.DateSorter._getLabel16036.native == global::System.IntPtr.Zero)
				global::android.webkit.DateSorter._getLabel16036 = @__env.GetMethodIDNoThrow(global::android.webkit.DateSorter.staticClass, "getLabel", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.DateSorter.staticClass, global::android.webkit.DateSorter._getLabel16036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoundary16037;
		public virtual long getBoundary(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.DateSorter._getBoundary16037.native == global::System.IntPtr.Zero)
				global::android.webkit.DateSorter._getBoundary16037 = @__env.GetMethodIDNoThrow(global::android.webkit.DateSorter.staticClass, "getBoundary", "(I)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.webkit.DateSorter.staticClass, global::android.webkit.DateSorter._getBoundary16037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DateSorter16038;
		public DateSorter(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.DateSorter._DateSorter16038.native == global::System.IntPtr.Zero)
				global::android.webkit.DateSorter._DateSorter16038 = @__env.GetMethodIDNoThrow(global::android.webkit.DateSorter.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.DateSorter.staticClass, global::android.webkit.DateSorter._DateSorter16038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
