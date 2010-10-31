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
		private static global::MonoJavaBridge.MethodId _m0;
		global::android.view.View android.widget.SpinnerAdapter.getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SpinnerAdapter_.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.SpinnerAdapter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool android.widget.Adapter.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SpinnerAdapter_.staticClass, "isEmpty", "()Z", ref global::android.widget.SpinnerAdapter_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int android.widget.Adapter.getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.SpinnerAdapter_.staticClass, "getCount", "()I", ref global::android.widget.SpinnerAdapter_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SpinnerAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.SpinnerAdapter_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SpinnerAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.SpinnerAdapter_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.Object android.widget.Adapter.getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SpinnerAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;", ref global::android.widget.SpinnerAdapter_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		long android.widget.Adapter.getItemId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.SpinnerAdapter_.staticClass, "getItemId", "(I)J", ref global::android.widget.SpinnerAdapter_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool android.widget.Adapter.hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SpinnerAdapter_.staticClass, "hasStableIds", "()Z", ref global::android.widget.SpinnerAdapter_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SpinnerAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.SpinnerAdapter_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		int android.widget.Adapter.getItemViewType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.SpinnerAdapter_.staticClass, "getItemViewType", "(I)I", ref global::android.widget.SpinnerAdapter_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		int android.widget.Adapter.getViewTypeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.SpinnerAdapter_.staticClass, "getViewTypeCount", "()I", ref global::android.widget.SpinnerAdapter_._m10);
		}
		static SpinnerAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SpinnerAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SpinnerAdapter"));
		}
	}
}
