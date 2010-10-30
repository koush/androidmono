namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.WrapperListAdapter_))]
	public partial interface WrapperListAdapter : ListAdapter
	{
		global::android.widget.ListAdapter getWrappedAdapter();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.WrapperListAdapter))]
	internal sealed partial class WrapperListAdapter_ : java.lang.Object, WrapperListAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal WrapperListAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::android.widget.ListAdapter android.widget.WrapperListAdapter.getWrappedAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.ListAdapter>(this, global::android.widget.WrapperListAdapter_.staticClass, "getWrappedAdapter", "()Landroid/widget/ListAdapter;", ref global::android.widget.WrapperListAdapter_._m0) as android.widget.ListAdapter;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool android.widget.ListAdapter.isEnabled(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "isEnabled", "(I)Z", ref global::android.widget.WrapperListAdapter_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool android.widget.ListAdapter.areAllItemsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "areAllItemsEnabled", "()Z", ref global::android.widget.WrapperListAdapter_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool android.widget.Adapter.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "isEmpty", "()Z", ref global::android.widget.WrapperListAdapter_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int android.widget.Adapter.getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "getCount", "()I", ref global::android.widget.WrapperListAdapter_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.WrapperListAdapter_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.WrapperListAdapter_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.lang.Object android.widget.Adapter.getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;", ref global::android.widget.WrapperListAdapter_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		long android.widget.Adapter.getItemId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "getItemId", "(I)J", ref global::android.widget.WrapperListAdapter_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool android.widget.Adapter.hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "hasStableIds", "()Z", ref global::android.widget.WrapperListAdapter_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.WrapperListAdapter_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		int android.widget.Adapter.getItemViewType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "getItemViewType", "(I)I", ref global::android.widget.WrapperListAdapter_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		int android.widget.Adapter.getViewTypeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "getViewTypeCount", "()I", ref global::android.widget.WrapperListAdapter_._m12);
		}
		static WrapperListAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.WrapperListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/WrapperListAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
