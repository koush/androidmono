namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.Filterable_))]
	public interface Filterable  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.widget.Filter getFilter();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Filterable))]
	public sealed partial class Filterable_ : java.lang.Object, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Filterable_()
		{
			InitJNI();
		}
		internal Filterable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getFilter16986;
		 global::android.widget.Filter android.widget.Filterable.getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Filterable_._getFilter16986)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Filterable_.staticClass, global::android.widget.Filterable_._getFilter16986)) as android.widget.Filter;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Filterable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Filterable"));
			global::android.widget.Filterable_._getFilter16986 = @__env.GetMethodIDNoThrow(global::android.widget.Filterable_.staticClass, "getFilter", "()Landroid/widget/Filter;");
		}
	}
}
