namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateSorter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DateSorter()
		{
			InitJNI();
		}
		protected DateSorter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getIndex10307;
		public virtual int getIndex(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.DateSorter._getIndex10307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.DateSorter.staticClass, global::android.webkit.DateSorter._getIndex10307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLabel10308;
		public virtual global::java.lang.String getLabel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.DateSorter._getLabel10308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.DateSorter.staticClass, global::android.webkit.DateSorter._getLabel10308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoundary10309;
		public virtual long getBoundary(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.webkit.DateSorter._getBoundary10309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.webkit.DateSorter.staticClass, global::android.webkit.DateSorter._getBoundary10309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DateSorter10310;
		public DateSorter(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.DateSorter.staticClass, global::android.webkit.DateSorter._DateSorter10310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int DAY_COUNT
		{
			get
			{
				return 5;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.DateSorter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/DateSorter"));
			global::android.webkit.DateSorter._getIndex10307 = @__env.GetMethodIDNoThrow(global::android.webkit.DateSorter.staticClass, "getIndex", "(J)I");
			global::android.webkit.DateSorter._getLabel10308 = @__env.GetMethodIDNoThrow(global::android.webkit.DateSorter.staticClass, "getLabel", "(I)Ljava/lang/String;");
			global::android.webkit.DateSorter._getBoundary10309 = @__env.GetMethodIDNoThrow(global::android.webkit.DateSorter.staticClass, "getBoundary", "(I)J");
			global::android.webkit.DateSorter._DateSorter10310 = @__env.GetMethodIDNoThrow(global::android.webkit.DateSorter.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
