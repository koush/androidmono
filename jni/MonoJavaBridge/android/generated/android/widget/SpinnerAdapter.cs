namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SpinnerAdapter_))]
	public interface SpinnerAdapter : Adapter
	{
		global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SpinnerAdapter))]
	public sealed partial class SpinnerAdapter_ : java.lang.Object, SpinnerAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SpinnerAdapter_()
		{
			InitJNI();
		}
		internal SpinnerAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownView11999;
		 global::android.view.View android.widget.SpinnerAdapter.getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getDropDownView11999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_.staticClass, global::android.widget.SpinnerAdapter_._getDropDownView11999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty12000;
		 bool android.widget.Adapter.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._isEmpty12000);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_.staticClass, global::android.widget.SpinnerAdapter_._isEmpty12000);
		}
		internal static global::MonoJavaBridge.MethodId _getCount12001;
		 int android.widget.Adapter.getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getCount12001);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_.staticClass, global::android.widget.SpinnerAdapter_._getCount12001);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver12002;
		 void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._registerDataSetObserver12002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_.staticClass, global::android.widget.SpinnerAdapter_._registerDataSetObserver12002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver12003;
		 void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._unregisterDataSetObserver12003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_.staticClass, global::android.widget.SpinnerAdapter_._unregisterDataSetObserver12003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItem12004;
		 global::java.lang.Object android.widget.Adapter.getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getItem12004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_.staticClass, global::android.widget.SpinnerAdapter_._getItem12004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId12005;
		 long android.widget.Adapter.getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getItemId12005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_.staticClass, global::android.widget.SpinnerAdapter_._getItemId12005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds12006;
		 bool android.widget.Adapter.hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._hasStableIds12006);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_.staticClass, global::android.widget.SpinnerAdapter_._hasStableIds12006);
		}
		internal static global::MonoJavaBridge.MethodId _getView12007;
		 global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getView12007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_.staticClass, global::android.widget.SpinnerAdapter_._getView12007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType12008;
		 int android.widget.Adapter.getItemViewType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getItemViewType12008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_.staticClass, global::android.widget.SpinnerAdapter_._getItemViewType12008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount12009;
		 int android.widget.Adapter.getViewTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_._getViewTypeCount12009);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.SpinnerAdapter_.staticClass, global::android.widget.SpinnerAdapter_._getViewTypeCount12009);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SpinnerAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SpinnerAdapter"));
			global::android.widget.SpinnerAdapter_._getDropDownView11999 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.SpinnerAdapter_._isEmpty12000 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "isEmpty", "()Z");
			global::android.widget.SpinnerAdapter_._getCount12001 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getCount", "()I");
			global::android.widget.SpinnerAdapter_._registerDataSetObserver12002 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.SpinnerAdapter_._unregisterDataSetObserver12003 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.SpinnerAdapter_._getItem12004 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.SpinnerAdapter_._getItemId12005 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getItemId", "(I)J");
			global::android.widget.SpinnerAdapter_._hasStableIds12006 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "hasStableIds", "()Z");
			global::android.widget.SpinnerAdapter_._getView12007 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.SpinnerAdapter_._getItemViewType12008 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getItemViewType", "(I)I");
			global::android.widget.SpinnerAdapter_._getViewTypeCount12009 = @__env.GetMethodIDNoThrow(global::android.widget.SpinnerAdapter_.staticClass, "getViewTypeCount", "()I");
		}
	}
}
