namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.Adapter_))]
	public interface Adapter  : global::MonoJavaBridge.IJavaObject 
	{
		bool isEmpty();
		int getCount();
		void registerDataSetObserver(android.database.DataSetObserver arg0);
		void unregisterDataSetObserver(android.database.DataSetObserver arg0);
		global::java.lang.Object getItem(int arg0);
		long getItemId(int arg0);
		bool hasStableIds();
		global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2);
		int getItemViewType(int arg0);
		int getViewTypeCount();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.Adapter))]
	public sealed partial class Adapter_ : java.lang.Object, Adapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Adapter_()
		{
			InitJNI();
		}
		internal Adapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty10839;
		 bool android.widget.Adapter.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Adapter_._isEmpty10839);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Adapter_.staticClass, global::android.widget.Adapter_._isEmpty10839);
		}
		internal static global::MonoJavaBridge.MethodId _getCount10840;
		 int android.widget.Adapter.getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Adapter_._getCount10840);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Adapter_.staticClass, global::android.widget.Adapter_._getCount10840);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver10841;
		 void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Adapter_._registerDataSetObserver10841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Adapter_.staticClass, global::android.widget.Adapter_._registerDataSetObserver10841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver10842;
		 void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Adapter_._unregisterDataSetObserver10842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Adapter_.staticClass, global::android.widget.Adapter_._unregisterDataSetObserver10842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItem10843;
		 global::java.lang.Object android.widget.Adapter.getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Adapter_._getItem10843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Adapter_.staticClass, global::android.widget.Adapter_._getItem10843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId10844;
		 long android.widget.Adapter.getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.Adapter_._getItemId10844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.Adapter_.staticClass, global::android.widget.Adapter_._getItemId10844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds10845;
		 bool android.widget.Adapter.hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Adapter_._hasStableIds10845);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Adapter_.staticClass, global::android.widget.Adapter_._hasStableIds10845);
		}
		internal static global::MonoJavaBridge.MethodId _getView10846;
		 global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Adapter_._getView10846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Adapter_.staticClass, global::android.widget.Adapter_._getView10846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType10847;
		 int android.widget.Adapter.getItemViewType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Adapter_._getItemViewType10847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Adapter_.staticClass, global::android.widget.Adapter_._getItemViewType10847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount10848;
		 int android.widget.Adapter.getViewTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Adapter_._getViewTypeCount10848);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Adapter_.staticClass, global::android.widget.Adapter_._getViewTypeCount10848);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Adapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Adapter"));
			global::android.widget.Adapter_._isEmpty10839 = @__env.GetMethodIDNoThrow(global::android.widget.Adapter_.staticClass, "isEmpty", "()Z");
			global::android.widget.Adapter_._getCount10840 = @__env.GetMethodIDNoThrow(global::android.widget.Adapter_.staticClass, "getCount", "()I");
			global::android.widget.Adapter_._registerDataSetObserver10841 = @__env.GetMethodIDNoThrow(global::android.widget.Adapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.Adapter_._unregisterDataSetObserver10842 = @__env.GetMethodIDNoThrow(global::android.widget.Adapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.Adapter_._getItem10843 = @__env.GetMethodIDNoThrow(global::android.widget.Adapter_.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.Adapter_._getItemId10844 = @__env.GetMethodIDNoThrow(global::android.widget.Adapter_.staticClass, "getItemId", "(I)J");
			global::android.widget.Adapter_._hasStableIds10845 = @__env.GetMethodIDNoThrow(global::android.widget.Adapter_.staticClass, "hasStableIds", "()Z");
			global::android.widget.Adapter_._getView10846 = @__env.GetMethodIDNoThrow(global::android.widget.Adapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.Adapter_._getItemViewType10847 = @__env.GetMethodIDNoThrow(global::android.widget.Adapter_.staticClass, "getItemViewType", "(I)I");
			global::android.widget.Adapter_._getViewTypeCount10848 = @__env.GetMethodIDNoThrow(global::android.widget.Adapter_.staticClass, "getViewTypeCount", "()I");
		}
	}
}
