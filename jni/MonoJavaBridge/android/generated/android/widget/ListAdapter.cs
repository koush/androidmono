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
		internal static global::MonoJavaBridge.MethodId _isEnabled11512;
		 bool android.widget.ListAdapter.isEnabled(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_._isEnabled11512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._isEnabled11512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled11513;
		 bool android.widget.ListAdapter.areAllItemsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_._areAllItemsEnabled11513);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._areAllItemsEnabled11513);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty11514;
		 bool android.widget.Adapter.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_._isEmpty11514);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._isEmpty11514);
		}
		internal static global::MonoJavaBridge.MethodId _getCount11515;
		 int android.widget.Adapter.getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListAdapter_._getCount11515);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._getCount11515);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver11516;
		 void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListAdapter_._registerDataSetObserver11516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._registerDataSetObserver11516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver11517;
		 void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ListAdapter_._unregisterDataSetObserver11517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._unregisterDataSetObserver11517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItem11518;
		 global::java.lang.Object android.widget.Adapter.getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListAdapter_._getItem11518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._getItem11518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId11519;
		 long android.widget.Adapter.getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ListAdapter_._getItemId11519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._getItemId11519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds11520;
		 bool android.widget.Adapter.hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_._hasStableIds11520);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._hasStableIds11520);
		}
		internal static global::MonoJavaBridge.MethodId _getView11521;
		 global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ListAdapter_._getView11521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._getView11521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType11522;
		 int android.widget.Adapter.getItemViewType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListAdapter_._getItemViewType11522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._getItemViewType11522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount11523;
		 int android.widget.Adapter.getViewTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ListAdapter_._getViewTypeCount11523);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ListAdapter_.staticClass, global::android.widget.ListAdapter_._getViewTypeCount11523);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ListAdapter"));
			global::android.widget.ListAdapter_._isEnabled11512 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "isEnabled", "(I)Z");
			global::android.widget.ListAdapter_._areAllItemsEnabled11513 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.ListAdapter_._isEmpty11514 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "isEmpty", "()Z");
			global::android.widget.ListAdapter_._getCount11515 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getCount", "()I");
			global::android.widget.ListAdapter_._registerDataSetObserver11516 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.ListAdapter_._unregisterDataSetObserver11517 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.ListAdapter_._getItem11518 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.ListAdapter_._getItemId11519 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getItemId", "(I)J");
			global::android.widget.ListAdapter_._hasStableIds11520 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "hasStableIds", "()Z");
			global::android.widget.ListAdapter_._getView11521 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ListAdapter_._getItemViewType11522 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getItemViewType", "(I)I");
			global::android.widget.ListAdapter_._getViewTypeCount11523 = @__env.GetMethodIDNoThrow(global::android.widget.ListAdapter_.staticClass, "getViewTypeCount", "()I");
		}
	}
}
