namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ListAdapter_))]
	public partial interface ListAdapter : Adapter
	{
		bool isEnabled(int arg0);
		bool areAllItemsEnabled();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ListAdapter))]
	internal sealed partial class ListAdapter_ : java.lang.Object, ListAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ListAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled17324;
		bool android.widget.ListAdapter.isEnabled(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListAdapter_.staticClass, "isEnabled", "(I)Z", ref global::android.widget.ListAdapter_._isEnabled17324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled17325;
		bool android.widget.ListAdapter.areAllItemsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListAdapter_.staticClass, "areAllItemsEnabled", "()Z", ref global::android.widget.ListAdapter_._areAllItemsEnabled17325);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty17326;
		bool android.widget.Adapter.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListAdapter_.staticClass, "isEmpty", "()Z", ref global::android.widget.ListAdapter_._isEmpty17326);
		}
		internal static global::MonoJavaBridge.MethodId _getCount17327;
		int android.widget.Adapter.getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ListAdapter_.staticClass, "getCount", "()I", ref global::android.widget.ListAdapter_._getCount17327);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver17328;
		void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.ListAdapter_._registerDataSetObserver17328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver17329;
		void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.ListAdapter_._unregisterDataSetObserver17329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItem17330;
		global::java.lang.Object android.widget.Adapter.getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ListAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;", ref global::android.widget.ListAdapter_._getItem17330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId17331;
		long android.widget.Adapter.getItemId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ListAdapter_.staticClass, "getItemId", "(I)J", ref global::android.widget.ListAdapter_._getItemId17331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds17332;
		bool android.widget.Adapter.hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListAdapter_.staticClass, "hasStableIds", "()Z", ref global::android.widget.ListAdapter_._hasStableIds17332);
		}
		internal static global::MonoJavaBridge.MethodId _getView17333;
		global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ListAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ListAdapter_._getView17333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType17334;
		int android.widget.Adapter.getItemViewType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ListAdapter_.staticClass, "getItemViewType", "(I)I", ref global::android.widget.ListAdapter_._getItemViewType17334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount17335;
		int android.widget.Adapter.getViewTypeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ListAdapter_.staticClass, "getViewTypeCount", "()I", ref global::android.widget.ListAdapter_._getViewTypeCount17335);
		}
		static ListAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ListAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
