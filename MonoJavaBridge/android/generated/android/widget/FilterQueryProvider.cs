namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.FilterQueryProvider_))]
	public partial interface FilterQueryProvider  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.database.Cursor runQuery(java.lang.CharSequence arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.FilterQueryProvider))]
	internal sealed partial class FilterQueryProvider_ : java.lang.Object, FilterQueryProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FilterQueryProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _runQuery17087;
		global::android.database.Cursor android.widget.FilterQueryProvider.runQuery(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.FilterQueryProvider_._runQuery17087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.FilterQueryProvider_.staticClass, global::android.widget.FilterQueryProvider_._runQuery17087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		static FilterQueryProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.FilterQueryProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/FilterQueryProvider"));
			global::android.widget.FilterQueryProvider_._runQuery17087 = @__env.GetMethodIDNoThrow(global::android.widget.FilterQueryProvider_.staticClass, "runQuery", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;");
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate android.database.Cursor FilterQueryProviderDelegate(java.lang.CharSequence arg0);

	internal partial class FilterQueryProviderDelegateWrapper : java.lang.Object, FilterQueryProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FilterQueryProviderDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _FilterQueryProviderDelegateWrapper17088;
		public FilterQueryProviderDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FilterQueryProviderDelegateWrapper.staticClass, global::android.widget.FilterQueryProviderDelegateWrapper._FilterQueryProviderDelegateWrapper17088);
			Init(@__env, handle);
		}
		static FilterQueryProviderDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.FilterQueryProviderDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/FilterQueryProviderDelegateWrapper"));
			global::android.widget.FilterQueryProviderDelegateWrapper._FilterQueryProviderDelegateWrapper17088 = @__env.GetMethodIDNoThrow(global::android.widget.FilterQueryProviderDelegateWrapper.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class FilterQueryProviderDelegateWrapper
	{
		private FilterQueryProviderDelegate myDelegate;
		public android.database.Cursor runQuery(java.lang.CharSequence arg0)
		{
			return myDelegate(arg0);
		}
		public static implicit operator FilterQueryProviderDelegateWrapper(FilterQueryProviderDelegate d)
		{
			global::android.widget.FilterQueryProviderDelegateWrapper ret = new global::android.widget.FilterQueryProviderDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
