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
		internal static global::MonoJavaBridge.MethodId _getCount16688;
		public abstract int getCount();
		internal static global::MonoJavaBridge.MethodId _getItem16689;
		public abstract global::java.lang.Object getItem(int arg0);
		internal static global::MonoJavaBridge.MethodId _getItemId16690;
		public abstract long getItemId(int arg0);
		internal static global::MonoJavaBridge.MethodId _getView16691;
		public abstract global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2);
		internal static global::MonoJavaBridge.MethodId _isEmpty16692;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter._isEmpty16692);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._isEmpty16692);
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled16693;
		public virtual bool isEnabled(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter._isEnabled16693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._isEnabled16693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver16694;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter._registerDataSetObserver16694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._registerDataSetObserver16694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver16695;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter._unregisterDataSetObserver16695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._unregisterDataSetObserver16695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled16696;
		public virtual bool areAllItemsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter._areAllItemsEnabled16696);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._areAllItemsEnabled16696);
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds16697;
		public virtual bool hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter._hasStableIds16697);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._hasStableIds16697);
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType16698;
		public virtual int getItemViewType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseAdapter._getItemViewType16698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getItemViewType16698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount16699;
		public virtual int getViewTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseAdapter._getViewTypeCount16699);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getViewTypeCount16699);
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownView16700;
		public virtual global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter._getDropDownView16700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getDropDownView16700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged16701;
		public virtual void notifyDataSetChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter._notifyDataSetChanged16701);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._notifyDataSetChanged16701);
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetInvalidated16702;
		public virtual void notifyDataSetInvalidated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter._notifyDataSetInvalidated16702);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._notifyDataSetInvalidated16702);
		}
		internal static global::MonoJavaBridge.MethodId _BaseAdapter16703;
		public BaseAdapter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._BaseAdapter16703);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseAdapter"));
			global::android.widget.BaseAdapter._getCount16688 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getCount", "()I");
			global::android.widget.BaseAdapter._getItem16689 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.BaseAdapter._getItemId16690 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.BaseAdapter._getView16691 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseAdapter._isEmpty16692 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "isEmpty", "()Z");
			global::android.widget.BaseAdapter._isEnabled16693 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "isEnabled", "(I)Z");
			global::android.widget.BaseAdapter._registerDataSetObserver16694 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseAdapter._unregisterDataSetObserver16695 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseAdapter._areAllItemsEnabled16696 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.BaseAdapter._hasStableIds16697 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.BaseAdapter._getItemViewType16698 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getItemViewType", "(I)I");
			global::android.widget.BaseAdapter._getViewTypeCount16699 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getViewTypeCount", "()I");
			global::android.widget.BaseAdapter._getDropDownView16700 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseAdapter._notifyDataSetChanged16701 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.BaseAdapter._notifyDataSetInvalidated16702 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "notifyDataSetInvalidated", "()V");
			global::android.widget.BaseAdapter._BaseAdapter16703 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _getCount16704;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseAdapter_._getCount16704);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseAdapter_.staticClass, global::android.widget.BaseAdapter_._getCount16704);
		}
		internal static global::MonoJavaBridge.MethodId _getItem16705;
		public override global::java.lang.Object getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter_._getItem16705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter_.staticClass, global::android.widget.BaseAdapter_._getItem16705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId16706;
		public override long getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseAdapter_._getItemId16706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseAdapter_.staticClass, global::android.widget.BaseAdapter_._getItemId16706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getView16707;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter_._getView16707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter_.staticClass, global::android.widget.BaseAdapter_._getView16707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseAdapter"));
			global::android.widget.BaseAdapter_._getCount16704 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter_.staticClass, "getCount", "()I");
			global::android.widget.BaseAdapter_._getItem16705 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.BaseAdapter_._getItemId16706 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter_.staticClass, "getItemId", "(I)J");
			global::android.widget.BaseAdapter_._getView16707 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
		}
	}
}
