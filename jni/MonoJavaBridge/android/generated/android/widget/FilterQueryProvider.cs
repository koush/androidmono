namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.FilterQueryProvider_))]
	public interface FilterQueryProvider  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.database.Cursor runQuery(java.lang.CharSequence arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.FilterQueryProvider))]
	public sealed partial class FilterQueryProvider_ : java.lang.Object, FilterQueryProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FilterQueryProvider_()
		{
			InitJNI();
		}
		internal FilterQueryProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _runQuery11284;
		 global::android.database.Cursor android.widget.FilterQueryProvider.runQuery(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.FilterQueryProvider_._runQuery11284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.FilterQueryProvider_.staticClass, global::android.widget.FilterQueryProvider_._runQuery11284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.FilterQueryProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/FilterQueryProvider"));
			global::android.widget.FilterQueryProvider_._runQuery11284 = @__env.GetMethodIDNoThrow(global::android.widget.FilterQueryProvider_.staticClass, "runQuery", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;");
		}
	}
}
