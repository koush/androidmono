namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.WrapperListAdapter_))]
	public interface WrapperListAdapter : ListAdapter
	{
		global::android.widget.ListAdapter getWrappedAdapter();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.WrapperListAdapter))]
	public sealed partial class WrapperListAdapter_ : java.lang.Object, WrapperListAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WrapperListAdapter_()
		{
			InitJNI();
		}
		internal WrapperListAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getWrappedAdapter12435;
		 global::android.widget.ListAdapter android.widget.WrapperListAdapter.getWrappedAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_._getWrappedAdapter12435)) as android.widget.ListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_.staticClass, global::android.widget.WrapperListAdapter_._getWrappedAdapter12435)) as android.widget.ListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled12436;
		 bool android.widget.ListAdapter.isEnabled(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_._isEnabled12436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_.staticClass, global::android.widget.WrapperListAdapter_._isEnabled12436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled12437;
		 bool android.widget.ListAdapter.areAllItemsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_._areAllItemsEnabled12437);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_.staticClass, global::android.widget.WrapperListAdapter_._areAllItemsEnabled12437);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty12438;
		 bool android.widget.Adapter.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_._isEmpty12438);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_.staticClass, global::android.widget.WrapperListAdapter_._isEmpty12438);
		}
		internal static global::MonoJavaBridge.MethodId _getCount12439;
		 int android.widget.Adapter.getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_._getCount12439);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_.staticClass, global::android.widget.WrapperListAdapter_._getCount12439);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver12440;
		 void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_._registerDataSetObserver12440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_.staticClass, global::android.widget.WrapperListAdapter_._registerDataSetObserver12440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver12441;
		 void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_._unregisterDataSetObserver12441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_.staticClass, global::android.widget.WrapperListAdapter_._unregisterDataSetObserver12441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItem12442;
		 global::java.lang.Object android.widget.Adapter.getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_._getItem12442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_.staticClass, global::android.widget.WrapperListAdapter_._getItem12442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId12443;
		 long android.widget.Adapter.getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_._getItemId12443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_.staticClass, global::android.widget.WrapperListAdapter_._getItemId12443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds12444;
		 bool android.widget.Adapter.hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_._hasStableIds12444);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_.staticClass, global::android.widget.WrapperListAdapter_._hasStableIds12444);
		}
		internal static global::MonoJavaBridge.MethodId _getView12445;
		 global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_._getView12445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_.staticClass, global::android.widget.WrapperListAdapter_._getView12445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType12446;
		 int android.widget.Adapter.getItemViewType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_._getItemViewType12446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_.staticClass, global::android.widget.WrapperListAdapter_._getItemViewType12446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount12447;
		 int android.widget.Adapter.getViewTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_._getViewTypeCount12447);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.WrapperListAdapter_.staticClass, global::android.widget.WrapperListAdapter_._getViewTypeCount12447);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.WrapperListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/WrapperListAdapter"));
			global::android.widget.WrapperListAdapter_._getWrappedAdapter12435 = @__env.GetMethodIDNoThrow(global::android.widget.WrapperListAdapter_.staticClass, "getWrappedAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.WrapperListAdapter_._isEnabled12436 = @__env.GetMethodIDNoThrow(global::android.widget.WrapperListAdapter_.staticClass, "isEnabled", "(I)Z");
			global::android.widget.WrapperListAdapter_._areAllItemsEnabled12437 = @__env.GetMethodIDNoThrow(global::android.widget.WrapperListAdapter_.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.WrapperListAdapter_._isEmpty12438 = @__env.GetMethodIDNoThrow(global::android.widget.WrapperListAdapter_.staticClass, "isEmpty", "()Z");
			global::android.widget.WrapperListAdapter_._getCount12439 = @__env.GetMethodIDNoThrow(global::android.widget.WrapperListAdapter_.staticClass, "getCount", "()I");
			global::android.widget.WrapperListAdapter_._registerDataSetObserver12440 = @__env.GetMethodIDNoThrow(global::android.widget.WrapperListAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.WrapperListAdapter_._unregisterDataSetObserver12441 = @__env.GetMethodIDNoThrow(global::android.widget.WrapperListAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.WrapperListAdapter_._getItem12442 = @__env.GetMethodIDNoThrow(global::android.widget.WrapperListAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.WrapperListAdapter_._getItemId12443 = @__env.GetMethodIDNoThrow(global::android.widget.WrapperListAdapter_.staticClass, "getItemId", "(I)J");
			global::android.widget.WrapperListAdapter_._hasStableIds12444 = @__env.GetMethodIDNoThrow(global::android.widget.WrapperListAdapter_.staticClass, "hasStableIds", "()Z");
			global::android.widget.WrapperListAdapter_._getView12445 = @__env.GetMethodIDNoThrow(global::android.widget.WrapperListAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.WrapperListAdapter_._getItemViewType12446 = @__env.GetMethodIDNoThrow(global::android.widget.WrapperListAdapter_.staticClass, "getItemViewType", "(I)I");
			global::android.widget.WrapperListAdapter_._getViewTypeCount12447 = @__env.GetMethodIDNoThrow(global::android.widget.WrapperListAdapter_.staticClass, "getViewTypeCount", "()I");
		}
	}
}
