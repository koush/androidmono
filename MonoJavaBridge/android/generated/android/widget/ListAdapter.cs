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
		private static global::MonoJavaBridge.MethodId _m0;
		bool android.widget.ListAdapter.isEnabled(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListAdapter_.staticClass, "isEnabled", "(I)Z", ref global::android.widget.ListAdapter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool android.widget.ListAdapter.areAllItemsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListAdapter_.staticClass, "areAllItemsEnabled", "()Z", ref global::android.widget.ListAdapter_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool android.widget.Adapter.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListAdapter_.staticClass, "isEmpty", "()Z", ref global::android.widget.ListAdapter_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int android.widget.Adapter.getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ListAdapter_.staticClass, "getCount", "()I", ref global::android.widget.ListAdapter_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.ListAdapter_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ListAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.ListAdapter_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.lang.Object android.widget.Adapter.getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ListAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;", ref global::android.widget.ListAdapter_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		long android.widget.Adapter.getItemId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ListAdapter_.staticClass, "getItemId", "(I)J", ref global::android.widget.ListAdapter_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool android.widget.Adapter.hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ListAdapter_.staticClass, "hasStableIds", "()Z", ref global::android.widget.ListAdapter_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ListAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ListAdapter_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		int android.widget.Adapter.getItemViewType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ListAdapter_.staticClass, "getItemViewType", "(I)I", ref global::android.widget.ListAdapter_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		int android.widget.Adapter.getViewTypeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ListAdapter_.staticClass, "getViewTypeCount", "()I", ref global::android.widget.ListAdapter_._m11);
		}
		static ListAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ListAdapter"));
		}
	}
}
