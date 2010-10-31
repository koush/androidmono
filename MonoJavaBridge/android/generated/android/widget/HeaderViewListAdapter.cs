namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HeaderViewListAdapter : java.lang.Object, WrapperListAdapter, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HeaderViewListAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "isEmpty", "()Z", ref global::android.widget.HeaderViewListAdapter._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool isEnabled(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "isEnabled", "(I)Z", ref global::android.widget.HeaderViewListAdapter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getCount", "()I", ref global::android.widget.HeaderViewListAdapter._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.HeaderViewListAdapter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.HeaderViewListAdapter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.Object getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;", ref global::android.widget.HeaderViewListAdapter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual long getItemId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getItemId", "(I)J", ref global::android.widget.HeaderViewListAdapter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.Filter Filter
		{
			get
			{
				return getFilter();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.widget.Filter getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;", ref global::android.widget.HeaderViewListAdapter._m7) as android.widget.Filter;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool areAllItemsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "areAllItemsEnabled", "()Z", ref global::android.widget.HeaderViewListAdapter._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "hasStableIds", "()Z", ref global::android.widget.HeaderViewListAdapter._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.HeaderViewListAdapter._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getItemViewType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getItemViewType", "(I)I", ref global::android.widget.HeaderViewListAdapter._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ViewTypeCount
		{
			get
			{
				return getViewTypeCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int getViewTypeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getViewTypeCount", "()I", ref global::android.widget.HeaderViewListAdapter._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool removeHeader(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "removeHeader", "(Landroid/view/View;)Z", ref global::android.widget.HeaderViewListAdapter._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int HeadersCount
		{
			get
			{
				return getHeadersCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int getHeadersCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getHeadersCount", "()I", ref global::android.widget.HeaderViewListAdapter._m14);
		}
		public new int FootersCount
		{
			get
			{
				return getFootersCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int getFootersCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getFootersCount", "()I", ref global::android.widget.HeaderViewListAdapter._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool removeFooter(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "removeFooter", "(Landroid/view/View;)Z", ref global::android.widget.HeaderViewListAdapter._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.ListAdapter WrappedAdapter
		{
			get
			{
				return getWrappedAdapter();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::android.widget.ListAdapter getWrappedAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.ListAdapter>(this, global::android.widget.HeaderViewListAdapter.staticClass, "getWrappedAdapter", "()Landroid/widget/ListAdapter;", ref global::android.widget.HeaderViewListAdapter._m17) as android.widget.ListAdapter;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public HeaderViewListAdapter(java.util.ArrayList arg0, java.util.ArrayList arg1, android.widget.ListAdapter arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.HeaderViewListAdapter._m18.native == global::System.IntPtr.Zero)
				global::android.widget.HeaderViewListAdapter._m18 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "<init>", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Landroid/widget/ListAdapter;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static HeaderViewListAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.HeaderViewListAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/HeaderViewListAdapter"));
		}
	}
}
