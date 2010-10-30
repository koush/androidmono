namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.BaseAdapter_))]
	public abstract partial class BaseAdapter : java.lang.Object, ListAdapter, SpinnerAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BaseAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCount16782;
		public abstract int getCount();
		internal static global::MonoJavaBridge.MethodId _getItem16783;
		public abstract global::java.lang.Object getItem(int arg0);
		internal static global::MonoJavaBridge.MethodId _getItemId16784;
		public abstract long getItemId(int arg0);
		internal static global::MonoJavaBridge.MethodId _getView16785;
		public abstract global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2);
		internal static global::MonoJavaBridge.MethodId _isEmpty16786;
		public virtual bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter._isEmpty16786.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter._isEmpty16786 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "isEmpty", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._isEmpty16786);
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled16787;
		public virtual bool isEnabled(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter._isEnabled16787.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter._isEnabled16787 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "isEnabled", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._isEnabled16787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver16788;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter._registerDataSetObserver16788.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter._registerDataSetObserver16788 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._registerDataSetObserver16788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver16789;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter._unregisterDataSetObserver16789.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter._unregisterDataSetObserver16789 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._unregisterDataSetObserver16789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled16790;
		public virtual bool areAllItemsEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter._areAllItemsEnabled16790.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter._areAllItemsEnabled16790 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "areAllItemsEnabled", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._areAllItemsEnabled16790);
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds16791;
		public virtual bool hasStableIds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter._hasStableIds16791.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter._hasStableIds16791 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "hasStableIds", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._hasStableIds16791);
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType16792;
		public virtual int getItemViewType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter._getItemViewType16792.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter._getItemViewType16792 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getItemViewType", "(I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getItemViewType16792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount16793;
		public virtual int getViewTypeCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter._getViewTypeCount16793.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter._getViewTypeCount16793 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getViewTypeCount", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getViewTypeCount16793);
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownView16794;
		public virtual global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter._getDropDownView16794.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter._getDropDownView16794 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._getDropDownView16794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged16795;
		public virtual void notifyDataSetChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter._notifyDataSetChanged16795.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter._notifyDataSetChanged16795 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._notifyDataSetChanged16795);
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetInvalidated16796;
		public virtual void notifyDataSetInvalidated()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter._notifyDataSetInvalidated16796.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter._notifyDataSetInvalidated16796 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "notifyDataSetInvalidated", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._notifyDataSetInvalidated16796);
		}
		internal static global::MonoJavaBridge.MethodId _BaseAdapter16797;
		public BaseAdapter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter._BaseAdapter16797.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter._BaseAdapter16797 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._BaseAdapter16797);
			Init(@__env, handle);
		}
		static BaseAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.BaseAdapter))]
	internal sealed partial class BaseAdapter_ : android.widget.BaseAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BaseAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCount16798;
		public override int getCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter_._getCount16798.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter_._getCount16798 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter_.staticClass, "getCount", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseAdapter_._getCount16798);
		}
		internal static global::MonoJavaBridge.MethodId _getItem16799;
		public override global::java.lang.Object getItem(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter_._getItem16799.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter_._getItem16799 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter_._getItem16799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId16800;
		public override long getItemId(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter_._getItemId16800.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter_._getItemId16800 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter_.staticClass, "getItemId", "(I)J");
			return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseAdapter_._getItemId16800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getView16801;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter_._getView16801.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter_._getView16801 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseAdapter_._getView16801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		static BaseAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
