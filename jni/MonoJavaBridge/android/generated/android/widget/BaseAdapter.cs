namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.BaseAdapter_))]
	public abstract partial class BaseAdapter : java.lang.Object, ListAdapter, SpinnerAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BaseAdapter()
		{
			InitJNI();
		}
		protected BaseAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCount10997;
		public abstract int getCount();
		internal static global::MonoJavaBridge.MethodId _getItem10998;
		public abstract global::java.lang.Object getItem(int arg0);
		internal static global::MonoJavaBridge.MethodId _getItemId10999;
		public abstract long getItemId(int arg0);
		internal static global::MonoJavaBridge.MethodId _getView11000;
		public abstract global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2);
		internal static global::MonoJavaBridge.MethodId _isEmpty11001;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter._isEmpty11001);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._isEmpty11001);
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled11002;
		public virtual bool isEnabled(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter._isEnabled11002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._isEnabled11002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver11003;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter._registerDataSetObserver11003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._registerDataSetObserver11003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver11004;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter._unregisterDataSetObserver11004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._unregisterDataSetObserver11004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled11005;
		public virtual bool areAllItemsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter._areAllItemsEnabled11005);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._areAllItemsEnabled11005);
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds11006;
		public virtual bool hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter._hasStableIds11006);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._hasStableIds11006);
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType11007;
		public virtual int getItemViewType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseAdapter._getItemViewType11007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getItemViewType11007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount11008;
		public virtual int getViewTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseAdapter._getViewTypeCount11008);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getViewTypeCount11008);
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownView11009;
		public virtual global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter._getDropDownView11009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getDropDownView11009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged11010;
		public virtual void notifyDataSetChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter._notifyDataSetChanged11010);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._notifyDataSetChanged11010);
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetInvalidated11011;
		public virtual void notifyDataSetInvalidated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter._notifyDataSetInvalidated11011);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._notifyDataSetInvalidated11011);
		}
		internal static global::MonoJavaBridge.MethodId _BaseAdapter11012;
		public BaseAdapter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._BaseAdapter11012);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseAdapter"));
			global::android.widget.BaseAdapter._getCount10997 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getCount", "()I");
			global::android.widget.BaseAdapter._getItem10998 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.BaseAdapter._getItemId10999 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.BaseAdapter._getView11000 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseAdapter._isEmpty11001 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "isEmpty", "()Z");
			global::android.widget.BaseAdapter._isEnabled11002 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "isEnabled", "(I)Z");
			global::android.widget.BaseAdapter._registerDataSetObserver11003 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseAdapter._unregisterDataSetObserver11004 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseAdapter._areAllItemsEnabled11005 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.BaseAdapter._hasStableIds11006 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.BaseAdapter._getItemViewType11007 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getItemViewType", "(I)I");
			global::android.widget.BaseAdapter._getViewTypeCount11008 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getViewTypeCount", "()I");
			global::android.widget.BaseAdapter._getDropDownView11009 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseAdapter._notifyDataSetChanged11010 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.BaseAdapter._notifyDataSetInvalidated11011 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "notifyDataSetInvalidated", "()V");
			global::android.widget.BaseAdapter._BaseAdapter11012 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.BaseAdapter))]
	public sealed partial class BaseAdapter_ : android.widget.BaseAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BaseAdapter_()
		{
			InitJNI();
		}
		internal BaseAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCount11013;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseAdapter_._getCount11013);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseAdapter_.staticClass, global::android.widget.BaseAdapter_._getCount11013);
		}
		internal static global::MonoJavaBridge.MethodId _getItem11014;
		public override global::java.lang.Object getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter_._getItem11014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter_.staticClass, global::android.widget.BaseAdapter_._getItem11014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId11015;
		public override long getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseAdapter_._getItemId11015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseAdapter_.staticClass, global::android.widget.BaseAdapter_._getItemId11015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getView11016;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter_._getView11016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter_.staticClass, global::android.widget.BaseAdapter_._getView11016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseAdapter"));
			global::android.widget.BaseAdapter_._getCount11013 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter_.staticClass, "getCount", "()I");
			global::android.widget.BaseAdapter_._getItem11014 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.BaseAdapter_._getItemId11015 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter_.staticClass, "getItemId", "(I)J");
			global::android.widget.BaseAdapter_._getView11016 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
		}
	}
}
