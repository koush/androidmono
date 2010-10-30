namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.BaseAdapter_))]
	public abstract partial class BaseAdapter : java.lang.Object, ListAdapter, SpinnerAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BaseAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract int getCount();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.lang.Object getItem(int arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract long getItemId(int arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, "isEmpty", "()Z", ref global::android.widget.BaseAdapter._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isEnabled(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, "isEnabled", "(I)Z", ref global::android.widget.BaseAdapter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.BaseAdapter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.BaseAdapter._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool areAllItemsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, "areAllItemsEnabled", "()Z", ref global::android.widget.BaseAdapter._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.BaseAdapter.staticClass, "hasStableIds", "()Z", ref global::android.widget.BaseAdapter._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getItemViewType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.BaseAdapter.staticClass, "getItemViewType", "(I)I", ref global::android.widget.BaseAdapter._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getViewTypeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.BaseAdapter.staticClass, "getViewTypeCount", "()I", ref global::android.widget.BaseAdapter._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.BaseAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.BaseAdapter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void notifyDataSetChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseAdapter.staticClass, "notifyDataSetChanged", "()V", ref global::android.widget.BaseAdapter._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void notifyDataSetInvalidated()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseAdapter.staticClass, "notifyDataSetInvalidated", "()V", ref global::android.widget.BaseAdapter._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public BaseAdapter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseAdapter._m15.native == global::System.IntPtr.Zero)
				global::android.widget.BaseAdapter._m15 = @__env.GetMethodIDNoThrow(global::android.widget.BaseAdapter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.BaseAdapter.staticClass, global::android.widget.BaseAdapter._m15);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.BaseAdapter_.staticClass, "getCount", "()I", ref global::android.widget.BaseAdapter_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.BaseAdapter_.staticClass, "getItem", "(I)Ljava/lang/Object;", ref global::android.widget.BaseAdapter_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override long getItemId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.BaseAdapter_.staticClass, "getItemId", "(I)J", ref global::android.widget.BaseAdapter_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.BaseAdapter_.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.BaseAdapter_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
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
