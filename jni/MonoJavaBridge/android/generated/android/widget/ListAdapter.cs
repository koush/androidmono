namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ListAdapter_))]
	public interface ListAdapter : Adapter
	{
		bool isEnabled(int arg0);
		bool areAllItemsEnabled();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ListAdapter))]
	public sealed partial class ListAdapter_ : java.lang.Object, ListAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ListAdapter_()
		{
			InitJNI();
		}
		internal ListAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled12058;
		 bool android.widget.ListAdapter.isEnabled(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_._isEnabled12058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._isEnabled12058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled12059;
		 bool android.widget.ListAdapter.areAllItemsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_._areAllItemsEnabled12059);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._areAllItemsEnabled12059);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty12060;
		 bool android.widget.Adapter.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_._isEmpty12060);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._isEmpty12060);
		}
		internal static global::MonoJavaBridge.MethodId _getCount12061;
		 int android.widget.Adapter.getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListAdapter_._getCount12061);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._getCount12061);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver12062;
		 void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListAdapter_._registerDataSetObserver12062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._registerDataSetObserver12062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver12063;
		 void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListAdapter_._unregisterDataSetObserver12063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._unregisterDataSetObserver12063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItem12064;
		 global::java.lang.Object android.widget.Adapter.getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListAdapter_._getItem12064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._getItem12064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId12065;
		 long android.widget.Adapter.getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ListAdapter_._getItemId12065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._getItemId12065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds12066;
		 bool android.widget.Adapter.hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_._hasStableIds12066);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._hasStableIds12066);
		}
		internal static global::MonoJavaBridge.MethodId _getView12067;
		 global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListAdapter_._getView12067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._getView12067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType12068;
		 int android.widget.Adapter.getItemViewType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListAdapter_._getItemViewType12068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._getItemViewType12068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount12069;
		 int android.widget.Adapter.getViewTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListAdapter_._getViewTypeCount12069);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._getViewTypeCount12069);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ListAdapter"));
			global::android.widget.ListAdapter_._isEnabled12058 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "isEnabled", "(I)Z");
			global::android.widget.ListAdapter_._areAllItemsEnabled12059 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.ListAdapter_._isEmpty12060 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "isEmpty", "()Z");
			global::android.widget.ListAdapter_._getCount12061 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getCount", "()I");
			global::android.widget.ListAdapter_._registerDataSetObserver12062 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.ListAdapter_._unregisterDataSetObserver12063 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.ListAdapter_._getItem12064 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.ListAdapter_._getItemId12065 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getItemId", "(I)J");
			global::android.widget.ListAdapter_._hasStableIds12066 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "hasStableIds", "()Z");
			global::android.widget.ListAdapter_._getView12067 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ListAdapter_._getItemViewType12068 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getItemViewType", "(I)I");
			global::android.widget.ListAdapter_._getViewTypeCount12069 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getViewTypeCount", "()I");
		}
	}
}
