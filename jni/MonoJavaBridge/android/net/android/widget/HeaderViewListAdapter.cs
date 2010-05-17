namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class HeaderViewListAdapter : java.lang.Object, WrapperListAdapter, Filterable
	{ 
		internal static global::java.lang.Class staticClass; 
		static HeaderViewListAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.HeaderViewListAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty9547; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return @__env.CallBooleanMethod(this, _isEmpty9547); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HeaderViewListAdapter.staticClass, _isEmpty9547); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled9548; 
		public virtual bool isEnabled(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return @__env.CallBooleanMethod(this, _isEnabled9548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HeaderViewListAdapter.staticClass, _isEnabled9548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount9549; 
		public virtual int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return @__env.CallIntMethod(this, _getCount9549); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.HeaderViewListAdapter.staticClass, _getCount9549); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver9550; 
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				@__env.CallVoidMethod(this, _registerDataSetObserver9550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HeaderViewListAdapter.staticClass, _registerDataSetObserver9550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver9551; 
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				@__env.CallVoidMethod(this, _unregisterDataSetObserver9551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HeaderViewListAdapter.staticClass, _unregisterDataSetObserver9551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItem9552; 
		public virtual java.lang.Object getItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getItem9552, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.HeaderViewListAdapter.staticClass, _getItem9552, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemId9553; 
		public virtual long getItemId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return @__env.CallLongMethod(this, _getItemId9553, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.HeaderViewListAdapter.staticClass, _getItemId9553, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilter9554; 
		public virtual android.widget.Filter getFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, _getFilter9554)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.HeaderViewListAdapter.staticClass, _getFilter9554)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _areAllItemsEnabled9555; 
		public virtual bool areAllItemsEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return @__env.CallBooleanMethod(this, _areAllItemsEnabled9555); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HeaderViewListAdapter.staticClass, _areAllItemsEnabled9555); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds9556; 
		public virtual bool hasStableIds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return @__env.CallBooleanMethod(this, _hasStableIds9556); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HeaderViewListAdapter.staticClass, _hasStableIds9556); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getView9557; 
		public virtual android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getView9557, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.HeaderViewListAdapter.staticClass, _getView9557, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemViewType9558; 
		public virtual int getItemViewType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return @__env.CallIntMethod(this, _getItemViewType9558, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.HeaderViewListAdapter.staticClass, _getItemViewType9558, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getViewTypeCount9559; 
		public virtual int getViewTypeCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return @__env.CallIntMethod(this, _getViewTypeCount9559); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.HeaderViewListAdapter.staticClass, _getViewTypeCount9559); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeadersCount9560; 
		public virtual int getHeadersCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return @__env.CallIntMethod(this, _getHeadersCount9560); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.HeaderViewListAdapter.staticClass, _getHeadersCount9560); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFootersCount9561; 
		public virtual int getFootersCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return @__env.CallIntMethod(this, _getFootersCount9561); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.HeaderViewListAdapter.staticClass, _getFootersCount9561); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeHeader9562; 
		public virtual bool removeHeader(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return @__env.CallBooleanMethod(this, _removeHeader9562, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HeaderViewListAdapter.staticClass, _removeHeader9562, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeFooter9563; 
		public virtual bool removeFooter(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return @__env.CallBooleanMethod(this, _removeFooter9563, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HeaderViewListAdapter.staticClass, _removeFooter9563, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWrappedAdapter9564; 
		public virtual android.widget.ListAdapter getWrappedAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HeaderViewListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, _getWrappedAdapter9564)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.HeaderViewListAdapter.staticClass, _getWrappedAdapter9564)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HeaderViewListAdapter9565; 
		public HeaderViewListAdapter(java.util.ArrayList arg0, java.util.ArrayList arg1, android.widget.ListAdapter arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.HeaderViewListAdapter.staticClass, _HeaderViewListAdapter9565, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.HeaderViewListAdapter.staticClass = @__class; 
			global::android.widget.HeaderViewListAdapter._isEmpty9547 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "isEmpty", "()Z"); 
			global::android.widget.HeaderViewListAdapter._isEnabled9548 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "isEnabled", "(I)Z"); 
			global::android.widget.HeaderViewListAdapter._getCount9549 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getCount", "()I"); 
			global::android.widget.HeaderViewListAdapter._registerDataSetObserver9550 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver9551 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.HeaderViewListAdapter._getItem9552 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;"); 
			global::android.widget.HeaderViewListAdapter._getItemId9553 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getItemId", "(I)J"); 
			global::android.widget.HeaderViewListAdapter._getFilter9554 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;"); 
			global::android.widget.HeaderViewListAdapter._areAllItemsEnabled9555 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "areAllItemsEnabled", "()Z"); 
			global::android.widget.HeaderViewListAdapter._hasStableIds9556 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "hasStableIds", "()Z"); 
			global::android.widget.HeaderViewListAdapter._getView9557 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.HeaderViewListAdapter._getItemViewType9558 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getItemViewType", "(I)I"); 
			global::android.widget.HeaderViewListAdapter._getViewTypeCount9559 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getViewTypeCount", "()I"); 
			global::android.widget.HeaderViewListAdapter._getHeadersCount9560 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getHeadersCount", "()I"); 
			global::android.widget.HeaderViewListAdapter._getFootersCount9561 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getFootersCount", "()I"); 
			global::android.widget.HeaderViewListAdapter._removeHeader9562 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "removeHeader", "(Landroid/view/View;)Z"); 
			global::android.widget.HeaderViewListAdapter._removeFooter9563 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "removeFooter", "(Landroid/view/View;)Z"); 
			global::android.widget.HeaderViewListAdapter._getWrappedAdapter9564 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getWrappedAdapter", "()Landroid/widget/ListAdapter;"); 
			global::android.widget.HeaderViewListAdapter._HeaderViewListAdapter9565 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "<init>", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Landroid/widget/ListAdapter;)V"); 
		} 
	} 
} 
