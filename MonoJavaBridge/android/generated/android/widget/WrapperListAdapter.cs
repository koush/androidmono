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
		internal static global::MonoJavaBridge.MethodId _getWrappedAdapter18288;
		global::android.widget.ListAdapter android.widget.WrapperListAdapter.getWrappedAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.ListAdapter>(this, global::android.widget.WrapperListAdapter_.staticClass, "getWrappedAdapter", "()Landroid/widget/ListAdapter;", ref global::android.widget.WrapperListAdapter_._getWrappedAdapter18288) as android.widget.ListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled18289;
		bool android.widget.ListAdapter.isEnabled(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "isEnabled", "(I)Z", ref global::android.widget.WrapperListAdapter_._isEnabled18289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled18290;
		bool android.widget.ListAdapter.areAllItemsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "areAllItemsEnabled", "()Z", ref global::android.widget.WrapperListAdapter_._areAllItemsEnabled18290);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty18291;
		bool android.widget.Adapter.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "isEmpty", "()Z", ref global::android.widget.WrapperListAdapter_._isEmpty18291);
		}
		internal static global::MonoJavaBridge.MethodId _getCount18292;
		int android.widget.Adapter.getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "getCount", "()I", ref global::android.widget.WrapperListAdapter_._getCount18292);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver18293;
		void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.WrapperListAdapter_._registerDataSetObserver18293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver18294;
		void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.WrapperListAdapter_._unregisterDataSetObserver18294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItem18295;
		global::java.lang.Object android.widget.Adapter.getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;", ref global::android.widget.WrapperListAdapter_._getItem18295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId18296;
		long android.widget.Adapter.getItemId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "getItemId", "(I)J", ref global::android.widget.WrapperListAdapter_._getItemId18296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds18297;
		bool android.widget.Adapter.hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "hasStableIds", "()Z", ref global::android.widget.WrapperListAdapter_._hasStableIds18297);
		}
		internal static global::MonoJavaBridge.MethodId _getView18298;
		global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.WrapperListAdapter_._getView18298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType18299;
		int android.widget.Adapter.getItemViewType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "getItemViewType", "(I)I", ref global::android.widget.WrapperListAdapter_._getItemViewType18299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount18300;
		int android.widget.Adapter.getViewTypeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.WrapperListAdapter_.staticClass, "getViewTypeCount", "()I", ref global::android.widget.WrapperListAdapter_._getViewTypeCount18300);
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
