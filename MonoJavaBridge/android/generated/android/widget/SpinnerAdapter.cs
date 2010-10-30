namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SpinnerAdapter_))]
	public partial interface SpinnerAdapter : Adapter
	{
		global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SpinnerAdapter))]
	internal sealed partial class SpinnerAdapter_ : java.lang.Object, SpinnerAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SpinnerAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownView17845;
		global::android.view.View android.widget.SpinnerAdapter.getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SpinnerAdapter_._getDropDownView17845.native == global::System.IntPtr.Zero)
				global::android.widget.SpinnerAdapter_._getDropDownView17845 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getDropDownView17845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty17846;
		bool android.widget.Adapter.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SpinnerAdapter_._isEmpty17846.native == global::System.IntPtr.Zero)
				global::android.widget.SpinnerAdapter_._isEmpty17846 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "isEmpty", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._isEmpty17846);
		}
		internal static global::MonoJavaBridge.MethodId _getCount17847;
		int android.widget.Adapter.getCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SpinnerAdapter_._getCount17847.native == global::System.IntPtr.Zero)
				global::android.widget.SpinnerAdapter_._getCount17847 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getCount", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getCount17847);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver17848;
		void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SpinnerAdapter_._registerDataSetObserver17848.native == global::System.IntPtr.Zero)
				global::android.widget.SpinnerAdapter_._registerDataSetObserver17848 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._registerDataSetObserver17848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver17849;
		void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SpinnerAdapter_._unregisterDataSetObserver17849.native == global::System.IntPtr.Zero)
				global::android.widget.SpinnerAdapter_._unregisterDataSetObserver17849 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._unregisterDataSetObserver17849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItem17850;
		global::java.lang.Object android.widget.Adapter.getItem(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SpinnerAdapter_._getItem17850.native == global::System.IntPtr.Zero)
				global::android.widget.SpinnerAdapter_._getItem17850 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getItem17850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId17851;
		long android.widget.Adapter.getItemId(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SpinnerAdapter_._getItemId17851.native == global::System.IntPtr.Zero)
				global::android.widget.SpinnerAdapter_._getItemId17851 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getItemId", "(I)J");
			return @__env.CallLongMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getItemId17851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds17852;
		bool android.widget.Adapter.hasStableIds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SpinnerAdapter_._hasStableIds17852.native == global::System.IntPtr.Zero)
				global::android.widget.SpinnerAdapter_._hasStableIds17852 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "hasStableIds", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._hasStableIds17852);
		}
		internal static global::MonoJavaBridge.MethodId _getView17853;
		global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SpinnerAdapter_._getView17853.native == global::System.IntPtr.Zero)
				global::android.widget.SpinnerAdapter_._getView17853 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getView17853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType17854;
		int android.widget.Adapter.getItemViewType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SpinnerAdapter_._getItemViewType17854.native == global::System.IntPtr.Zero)
				global::android.widget.SpinnerAdapter_._getItemViewType17854 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getItemViewType", "(I)I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getItemViewType17854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount17855;
		int android.widget.Adapter.getViewTypeCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SpinnerAdapter_._getViewTypeCount17855.native == global::System.IntPtr.Zero)
				global::android.widget.SpinnerAdapter_._getViewTypeCount17855 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getViewTypeCount", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getViewTypeCount17855);
		}
		static SpinnerAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SpinnerAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SpinnerAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
