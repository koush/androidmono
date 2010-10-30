namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.BaseExpandableListAdapter_))]
	public abstract partial class BaseExpandableListAdapter : java.lang.Object, ExpandableListAdapter, HeterogeneousExpandableList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BaseExpandableListAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract long getGroupId(int arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract bool hasStableIds();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract int getGroupCount();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract int getChildrenCount(int arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.lang.Object getGroup(int arg0);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.lang.Object getChild(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract long getChildId(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3);
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract bool isChildSelectable(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "isEmpty", "()Z", ref global::android.widget.BaseExpandableListAdapter._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.BaseExpandableListAdapter._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.BaseExpandableListAdapter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool areAllItemsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "areAllItemsEnabled", "()Z", ref global::android.widget.BaseExpandableListAdapter._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void onGroupExpanded(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "onGroupExpanded", "(I)V", ref global::android.widget.BaseExpandableListAdapter._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void onGroupCollapsed(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "onGroupCollapsed", "(I)V", ref global::android.widget.BaseExpandableListAdapter._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual long getCombinedChildId(long arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "getCombinedChildId", "(JJ)J", ref global::android.widget.BaseExpandableListAdapter._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual long getCombinedGroupId(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "getCombinedGroupId", "(J)J", ref global::android.widget.BaseExpandableListAdapter._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void notifyDataSetChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "notifyDataSetChanged", "()V", ref global::android.widget.BaseExpandableListAdapter._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void notifyDataSetInvalidated()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "notifyDataSetInvalidated", "()V", ref global::android.widget.BaseExpandableListAdapter._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int getChildType(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "getChildType", "(II)I", ref global::android.widget.BaseExpandableListAdapter._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int getChildTypeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "getChildTypeCount", "()I", ref global::android.widget.BaseExpandableListAdapter._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual int getGroupType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupType", "(I)I", ref global::android.widget.BaseExpandableListAdapter._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual int getGroupTypeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupTypeCount", "()I", ref global::android.widget.BaseExpandableListAdapter._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public BaseExpandableListAdapter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.BaseExpandableListAdapter._m24.native == global::System.IntPtr.Zero)
				global::android.widget.BaseExpandableListAdapter._m24 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._m24);
			Init(@__env, handle);
		}
		static BaseExpandableListAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseExpandableListAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseExpandableListAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.BaseExpandableListAdapter))]
	internal sealed partial class BaseExpandableListAdapter_ : android.widget.BaseExpandableListAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BaseExpandableListAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override long getGroupId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroupId", "(I)J", ref global::android.widget.BaseExpandableListAdapter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.BaseExpandableListAdapter_.staticClass, "hasStableIds", "()Z", ref global::android.widget.BaseExpandableListAdapter_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int getGroupCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroupCount", "()I", ref global::android.widget.BaseExpandableListAdapter_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int getChildrenCount(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.BaseExpandableListAdapter_.staticClass, "getChildrenCount", "(I)I", ref global::android.widget.BaseExpandableListAdapter_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.Object getGroup(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroup", "(I)Ljava/lang/Object;", ref global::android.widget.BaseExpandableListAdapter_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.lang.Object getChild(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.BaseExpandableListAdapter_.staticClass, "getChild", "(II)Ljava/lang/Object;", ref global::android.widget.BaseExpandableListAdapter_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override long getChildId(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.BaseExpandableListAdapter_.staticClass, "getChildId", "(II)J", ref global::android.widget.BaseExpandableListAdapter_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.BaseExpandableListAdapter_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.BaseExpandableListAdapter_.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.BaseExpandableListAdapter_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool isChildSelectable(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.BaseExpandableListAdapter_.staticClass, "isChildSelectable", "(II)Z", ref global::android.widget.BaseExpandableListAdapter_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static BaseExpandableListAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseExpandableListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseExpandableListAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
