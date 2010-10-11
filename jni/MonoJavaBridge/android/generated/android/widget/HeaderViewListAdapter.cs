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
		internal static global::MonoJavaBridge.MethodId _isEmpty11372;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._isEmpty11372);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._isEmpty11372);
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled11373;
		public virtual bool isEnabled(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._isEnabled11373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._isEnabled11373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCount11374;
		public virtual int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getCount11374);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getCount11374);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver11375;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._registerDataSetObserver11375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._registerDataSetObserver11375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver11376;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver11376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver11376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getItem11377;
		public virtual global::java.lang.Object getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getItem11377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getItem11377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId11378;
		public virtual long getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getItemId11378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getItemId11378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilter11379;
		public virtual global::android.widget.Filter getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getFilter11379)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getFilter11379)) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled11380;
		public virtual bool areAllItemsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._areAllItemsEnabled11380);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._areAllItemsEnabled11380);
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds11381;
		public virtual bool hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._hasStableIds11381);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._hasStableIds11381);
		}
		internal static global::MonoJavaBridge.MethodId _getView11382;
		public virtual global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getView11382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getView11382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getItemViewType11383;
		public virtual int getItemViewType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getItemViewType11383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getItemViewType11383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getViewTypeCount11384;
		public virtual int getViewTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getViewTypeCount11384);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getViewTypeCount11384);
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader11385;
		public virtual bool removeHeader(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._removeHeader11385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._removeHeader11385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeadersCount11386;
		public virtual int getHeadersCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getHeadersCount11386);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getHeadersCount11386);
		}
		internal static global::MonoJavaBridge.MethodId _getFootersCount11387;
		public virtual int getFootersCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getFootersCount11387);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getFootersCount11387);
		}
		internal static global::MonoJavaBridge.MethodId _removeFooter11388;
		public virtual bool removeFooter(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._removeFooter11388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._removeFooter11388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWrappedAdapter11389;
		public virtual global::android.widget.ListAdapter getWrappedAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter._getWrappedAdapter11389)) as android.widget.ListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getWrappedAdapter11389)) as android.widget.ListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _HeaderViewListAdapter11390;
		public HeaderViewListAdapter(java.util.ArrayList arg0, java.util.ArrayList arg1, android.widget.ListAdapter arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._HeaderViewListAdapter11390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.HeaderViewListAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/HeaderViewListAdapter"));
			global::android.widget.HeaderViewListAdapter._isEmpty11372 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "isEmpty", "()Z");
			global::android.widget.HeaderViewListAdapter._isEnabled11373 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "isEnabled", "(I)Z");
			global::android.widget.HeaderViewListAdapter._getCount11374 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getCount", "()I");
			global::android.widget.HeaderViewListAdapter._registerDataSetObserver11375 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver11376 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.HeaderViewListAdapter._getItem11377 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.HeaderViewListAdapter._getItemId11378 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.HeaderViewListAdapter._getFilter11379 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.HeaderViewListAdapter._areAllItemsEnabled11380 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.HeaderViewListAdapter._hasStableIds11381 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.HeaderViewListAdapter._getView11382 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.HeaderViewListAdapter._getItemViewType11383 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getItemViewType", "(I)I");
			global::android.widget.HeaderViewListAdapter._getViewTypeCount11384 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getViewTypeCount", "()I");
			global::android.widget.HeaderViewListAdapter._removeHeader11385 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "removeHeader", "(Landroid/view/View;)Z");
			global::android.widget.HeaderViewListAdapter._getHeadersCount11386 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getHeadersCount", "()I");
			global::android.widget.HeaderViewListAdapter._getFootersCount11387 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getFootersCount", "()I");
			global::android.widget.HeaderViewListAdapter._removeFooter11388 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "removeFooter", "(Landroid/view/View;)Z");
			global::android.widget.HeaderViewListAdapter._getWrappedAdapter11389 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "getWrappedAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.HeaderViewListAdapter._HeaderViewListAdapter11390 = @__env.GetMethodIDNoThrow(global::android.widget.HeaderViewListAdapter.staticClass, "<init>", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Landroid/widget/ListAdapter;)V");
		}
	}
}
