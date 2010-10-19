namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HeaderViewListAdapter : java.lang.Object, WrapperListAdapter, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HeaderViewListAdapter()
		{
			InitJNI();
		}
		protected HeaderViewListAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty11918;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._isEmpty11918);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._isEmpty11918);
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled11919;
		public virtual bool isEnabled(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._isEnabled11919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._isEnabled11919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount11920;
		public virtual int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getCount11920);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getCount11920);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver11921;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._registerDataSetObserver11921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._registerDataSetObserver11921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver11922;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver11922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver11922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItem11923;
		public virtual global::java.lang.Object getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getItem11923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getItem11923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId11924;
		public virtual long getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getItemId11924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getItemId11924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.Filter Filter
		{
			get
			{
				return getFilter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilter11925;
		public virtual global::android.widget.Filter getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getFilter11925)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getFilter11925)) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled11926;
		public virtual bool areAllItemsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._areAllItemsEnabled11926);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._areAllItemsEnabled11926);
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds11927;
		public virtual bool hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._hasStableIds11927);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._hasStableIds11927);
		}
		internal static global::MonoJavaBridge.MethodId _getView11928;
		public virtual global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getView11928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getView11928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType11929;
		public virtual int getItemViewType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getItemViewType11929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getItemViewType11929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ViewTypeCount
		{
			get
			{
				return getViewTypeCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount11930;
		public virtual int getViewTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getViewTypeCount11930);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getViewTypeCount11930);
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader11931;
		public virtual bool removeHeader(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._removeHeader11931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._removeHeader11931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int HeadersCount
		{
			get
			{
				return getHeadersCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeadersCount11932;
		public virtual int getHeadersCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getHeadersCount11932);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getHeadersCount11932);
		}
		public new int FootersCount
		{
			get
			{
				return getFootersCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFootersCount11933;
		public virtual int getFootersCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getFootersCount11933);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getFootersCount11933);
		}
		internal static global::MonoJavaBridge.MethodId _removeFooter11934;
		public virtual bool removeFooter(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._removeFooter11934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._removeFooter11934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.ListAdapter WrappedAdapter
		{
			get
			{
				return getWrappedAdapter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWrappedAdapter11935;
		public virtual global::android.widget.ListAdapter getWrappedAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getWrappedAdapter11935)) as android.widget.ListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getWrappedAdapter11935)) as android.widget.ListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _HeaderViewListAdapter11936;
		public HeaderViewListAdapter(java.util.ArrayList arg0, java.util.ArrayList arg1, android.widget.ListAdapter arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._HeaderViewListAdapter11936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.HeaderViewListAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/HeaderViewListAdapter"));
			global::android.widget.HeaderViewListAdapter._isEmpty11918 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "isEmpty", "()Z");
			global::android.widget.HeaderViewListAdapter._isEnabled11919 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "isEnabled", "(I)Z");
			global::android.widget.HeaderViewListAdapter._getCount11920 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getCount", "()I");
			global::android.widget.HeaderViewListAdapter._registerDataSetObserver11921 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver11922 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.HeaderViewListAdapter._getItem11923 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.HeaderViewListAdapter._getItemId11924 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.HeaderViewListAdapter._getFilter11925 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.HeaderViewListAdapter._areAllItemsEnabled11926 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.HeaderViewListAdapter._hasStableIds11927 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.HeaderViewListAdapter._getView11928 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.HeaderViewListAdapter._getItemViewType11929 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getItemViewType", "(I)I");
			global::android.widget.HeaderViewListAdapter._getViewTypeCount11930 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getViewTypeCount", "()I");
			global::android.widget.HeaderViewListAdapter._removeHeader11931 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "removeHeader", "(Landroid/view/View;)Z");
			global::android.widget.HeaderViewListAdapter._getHeadersCount11932 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getHeadersCount", "()I");
			global::android.widget.HeaderViewListAdapter._getFootersCount11933 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getFootersCount", "()I");
			global::android.widget.HeaderViewListAdapter._removeFooter11934 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "removeFooter", "(Landroid/view/View;)Z");
			global::android.widget.HeaderViewListAdapter._getWrappedAdapter11935 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getWrappedAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.HeaderViewListAdapter._HeaderViewListAdapter11936 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "<init>", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Landroid/widget/ListAdapter;)V");
		}
	}
}
