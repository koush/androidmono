namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HeaderViewListAdapter : java.lang.Object, WrapperListAdapter, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HeaderViewListAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty17182;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "isEmpty", "()Z", ref global::android.widget.HeaderViewListAdapter._isEmpty17182);
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled17183;
		public virtual bool isEnabled(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "isEnabled", "(I)Z", ref global::android.widget.HeaderViewListAdapter._isEnabled17183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount17184;
		public virtual int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getCount", "()I", ref global::android.widget.HeaderViewListAdapter._getCount17184);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver17185;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.HeaderViewListAdapter._registerDataSetObserver17185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver17186;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver17186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItem17187;
		public virtual global::java.lang.Object getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;", ref global::android.widget.HeaderViewListAdapter._getItem17187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId17188;
		public virtual long getItemId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getItemId", "(I)J", ref global::android.widget.HeaderViewListAdapter._getItemId17188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.Filter Filter
		{
			get
			{
				return getFilter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilter17189;
		public virtual global::android.widget.Filter getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;", ref global::android.widget.HeaderViewListAdapter._getFilter17189) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled17190;
		public virtual bool areAllItemsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "areAllItemsEnabled", "()Z", ref global::android.widget.HeaderViewListAdapter._areAllItemsEnabled17190);
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds17191;
		public virtual bool hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "hasStableIds", "()Z", ref global::android.widget.HeaderViewListAdapter._hasStableIds17191);
		}
		internal static global::MonoJavaBridge.MethodId _getView17192;
		public virtual global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.HeaderViewListAdapter._getView17192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType17193;
		public virtual int getItemViewType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getItemViewType", "(I)I", ref global::android.widget.HeaderViewListAdapter._getItemViewType17193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ViewTypeCount
		{
			get
			{
				return getViewTypeCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount17194;
		public virtual int getViewTypeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getViewTypeCount", "()I", ref global::android.widget.HeaderViewListAdapter._getViewTypeCount17194);
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader17195;
		public virtual bool removeHeader(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "removeHeader", "(Landroid/view/View;)Z", ref global::android.widget.HeaderViewListAdapter._removeHeader17195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int HeadersCount
		{
			get
			{
				return getHeadersCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeadersCount17196;
		public virtual int getHeadersCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getHeadersCount", "()I", ref global::android.widget.HeaderViewListAdapter._getHeadersCount17196);
		}
		public new int FootersCount
		{
			get
			{
				return getFootersCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFootersCount17197;
		public virtual int getFootersCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "getFootersCount", "()I", ref global::android.widget.HeaderViewListAdapter._getFootersCount17197);
		}
		internal static global::MonoJavaBridge.MethodId _removeFooter17198;
		public virtual bool removeFooter(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, "removeFooter", "(Landroid/view/View;)Z", ref global::android.widget.HeaderViewListAdapter._removeFooter17198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.ListAdapter WrappedAdapter
		{
			get
			{
				return getWrappedAdapter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWrappedAdapter17199;
		public virtual global::android.widget.ListAdapter getWrappedAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.ListAdapter>(this, global::android.widget.HeaderViewListAdapter.staticClass, "getWrappedAdapter", "()Landroid/widget/ListAdapter;", ref global::android.widget.HeaderViewListAdapter._getWrappedAdapter17199) as android.widget.ListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _HeaderViewListAdapter17200;
		public HeaderViewListAdapter(java.util.ArrayList arg0, java.util.ArrayList arg1, android.widget.ListAdapter arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.HeaderViewListAdapter._HeaderViewListAdapter17200.native == global::System.IntPtr.Zero)
				global::android.widget.HeaderViewListAdapter._HeaderViewListAdapter17200 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "<init>", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Landroid/widget/ListAdapter;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._HeaderViewListAdapter17200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static HeaderViewListAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.HeaderViewListAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/HeaderViewListAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
