namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.Filterable_))]
	public partial interface Filterable  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.widget.Filter getFilter();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Filterable))]
	internal sealed partial class Filterable_ : java.lang.Object, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Filterable_()
		{
			InitJNI();
		}
		internal Filterable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getFilter17089;
		global::android.widget.Filter android.widget.Filterable.getFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Filterable_._getFilter17089)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Filterable_.staticClass, global::android.widget.Filterable_._getFilter17089)) as android.widget.Filter;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Filterable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filterable"));
			global::android.widget.Filterable_._getFilter17089 = @__env.GetMethodIDNoThrow(global::android.widget.Filterable_.staticClass, "getFilter", "()Landroid/widget/Filter;");
		}
	}

	public delegate android.widget.Filter FilterableDelegate();

	internal partial class FilterableDelegateWrapper : java.lang.Object, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FilterableDelegateWrapper()
		{
			InitJNI();
		}
		protected FilterableDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _FilterableDelegateWrapper17090;
		public FilterableDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FilterableDelegateWrapper.staticClass, global::android.widget.FilterableDelegateWrapper._FilterableDelegateWrapper17090);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.FilterableDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/FilterableDelegateWrapper"));
			global::android.widget.FilterableDelegateWrapper._FilterableDelegateWrapper17090 = @__env.GetMethodIDNoThrow(global::android.widget.FilterableDelegateWrapper.staticClass, "<init>", "()V");
		}
	}
	internal partial class FilterableDelegateWrapper
	{
		private FilterableDelegate myDelegate;
		public android.widget.Filter getFilter()
		{
			return myDelegate();
		}
		public static implicit operator FilterableDelegateWrapper(FilterableDelegate d)
		{
			global::android.widget.FilterableDelegateWrapper ret = new global::android.widget.FilterableDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
