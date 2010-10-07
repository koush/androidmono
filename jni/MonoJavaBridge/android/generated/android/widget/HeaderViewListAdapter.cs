namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class HeaderViewListAdapter : java.lang.Object, WrapperListAdapter, Filterable
	{
		internal static global::java.lang.Class staticClass;
		static HeaderViewListAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.HeaderViewListAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.HeaderViewListAdapter(@__env);
			}
		}
		protected HeaderViewListAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty10993;
		public virtual bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter._isEmpty10993);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._isEmpty10993);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled10994;
		public virtual bool isEnabled(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter._isEnabled10994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._isEnabled10994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount10995;
		public virtual int getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.HeaderViewListAdapter._getCount10995);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getCount10995);
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver10996;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HeaderViewListAdapter._registerDataSetObserver10996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._registerDataSetObserver10996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver10997;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver10997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver10997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItem10998;
		public virtual global::java.lang.Object getItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter._getItem10998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getItem10998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemId10999;
		public virtual long getItemId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.HeaderViewListAdapter._getItemId10999, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getItemId10999, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilter11000;
		public virtual global::android.widget.Filter getFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter._getFilter11000));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getFilter11000));
		}
		internal static global::net.sf.jni4net.jni.MethodId _areAllItemsEnabled11001;
		public virtual bool areAllItemsEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter._areAllItemsEnabled11001);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._areAllItemsEnabled11001);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds11002;
		public virtual bool hasStableIds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter._hasStableIds11002);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._hasStableIds11002);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getView11003;
		public virtual global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter._getView11003, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getView11003, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemViewType11004;
		public virtual int getItemViewType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.HeaderViewListAdapter._getItemViewType11004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getItemViewType11004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getViewTypeCount11005;
		public virtual int getViewTypeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.HeaderViewListAdapter._getViewTypeCount11005);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getViewTypeCount11005);
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeHeader11006;
		public virtual bool removeHeader(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter._removeHeader11006, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._removeHeader11006, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeadersCount11007;
		public virtual int getHeadersCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.HeaderViewListAdapter._getHeadersCount11007);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getHeadersCount11007);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFootersCount11008;
		public virtual int getFootersCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.HeaderViewListAdapter._getFootersCount11008);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getFootersCount11008);
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeFooter11009;
		public virtual bool removeFooter(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter._removeFooter11009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._removeFooter11009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWrappedAdapter11010;
		public virtual global::android.widget.ListAdapter getWrappedAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter._getWrappedAdapter11010));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getWrappedAdapter11010));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HeaderViewListAdapter11011;
		public HeaderViewListAdapter(java.util.ArrayList arg0, java.util.ArrayList arg1, android.widget.ListAdapter arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._HeaderViewListAdapter11011, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.HeaderViewListAdapter.staticClass = @__class;
			global::android.widget.HeaderViewListAdapter._isEmpty10993 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "isEmpty", "()Z");
			global::android.widget.HeaderViewListAdapter._isEnabled10994 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "isEnabled", "(I)Z");
			global::android.widget.HeaderViewListAdapter._getCount10995 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getCount", "()I");
			global::android.widget.HeaderViewListAdapter._registerDataSetObserver10996 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver10997 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.HeaderViewListAdapter._getItem10998 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.HeaderViewListAdapter._getItemId10999 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.HeaderViewListAdapter._getFilter11000 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.HeaderViewListAdapter._areAllItemsEnabled11001 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.HeaderViewListAdapter._hasStableIds11002 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.HeaderViewListAdapter._getView11003 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.HeaderViewListAdapter._getItemViewType11004 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getItemViewType", "(I)I");
			global::android.widget.HeaderViewListAdapter._getViewTypeCount11005 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getViewTypeCount", "()I");
			global::android.widget.HeaderViewListAdapter._removeHeader11006 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "removeHeader", "(Landroid/view/View;)Z");
			global::android.widget.HeaderViewListAdapter._getHeadersCount11007 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getHeadersCount", "()I");
			global::android.widget.HeaderViewListAdapter._getFootersCount11008 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getFootersCount", "()I");
			global::android.widget.HeaderViewListAdapter._removeFooter11009 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "removeFooter", "(Landroid/view/View;)Z");
			global::android.widget.HeaderViewListAdapter._getWrappedAdapter11010 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getWrappedAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.HeaderViewListAdapter._HeaderViewListAdapter11011 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "<init>", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Landroid/widget/ListAdapter;)V");
		}
	}
}
