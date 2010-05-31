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
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty10291; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter._isEmpty10291); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._isEmpty10291); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled10292; 
		public virtual bool isEnabled(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter._isEnabled10292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._isEnabled10292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount10293; 
		public virtual int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.HeaderViewListAdapter._getCount10293); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getCount10293); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver10294; 
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.HeaderViewListAdapter._registerDataSetObserver10294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._registerDataSetObserver10294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver10295; 
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver10295, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver10295, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItem10296; 
		public virtual global::java.lang.Object getItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter._getItem10296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getItem10296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemId10297; 
		public virtual long getItemId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.widget.HeaderViewListAdapter._getItemId10297, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getItemId10297, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilter10298; 
		public virtual global::android.widget.Filter getFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter._getFilter10298)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Filter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getFilter10298)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _areAllItemsEnabled10299; 
		public virtual bool areAllItemsEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter._areAllItemsEnabled10299); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._areAllItemsEnabled10299); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds10300; 
		public virtual bool hasStableIds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter._hasStableIds10300); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._hasStableIds10300); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getView10301; 
		public virtual global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter._getView10301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getView10301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemViewType10302; 
		public virtual int getItemViewType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.HeaderViewListAdapter._getItemViewType10302, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getItemViewType10302, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getViewTypeCount10303; 
		public virtual int getViewTypeCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.HeaderViewListAdapter._getViewTypeCount10303); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getViewTypeCount10303); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeadersCount10304; 
		public virtual int getHeadersCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.HeaderViewListAdapter._getHeadersCount10304); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getHeadersCount10304); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFootersCount10305; 
		public virtual int getFootersCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.HeaderViewListAdapter._getFootersCount10305); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getFootersCount10305); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeHeader10306; 
		public virtual bool removeHeader(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter._removeHeader10306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._removeHeader10306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeFooter10307; 
		public virtual bool removeFooter(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.HeaderViewListAdapter._removeFooter10307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._removeFooter10307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWrappedAdapter10308; 
		public virtual global::android.widget.ListAdapter getWrappedAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter._getWrappedAdapter10308)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._getWrappedAdapter10308)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HeaderViewListAdapter10309; 
		public HeaderViewListAdapter(java.util.ArrayList arg0, java.util.ArrayList arg1, android.widget.ListAdapter arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.HeaderViewListAdapter.staticClass, global::android.widget.HeaderViewListAdapter._HeaderViewListAdapter10309, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.HeaderViewListAdapter.staticClass = @__class; 
			global::android.widget.HeaderViewListAdapter._isEmpty10291 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "isEmpty", "()Z"); 
			global::android.widget.HeaderViewListAdapter._isEnabled10292 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "isEnabled", "(I)Z"); 
			global::android.widget.HeaderViewListAdapter._getCount10293 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getCount", "()I"); 
			global::android.widget.HeaderViewListAdapter._registerDataSetObserver10294 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.HeaderViewListAdapter._unregisterDataSetObserver10295 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.HeaderViewListAdapter._getItem10296 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;"); 
			global::android.widget.HeaderViewListAdapter._getItemId10297 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getItemId", "(I)J"); 
			global::android.widget.HeaderViewListAdapter._getFilter10298 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;"); 
			global::android.widget.HeaderViewListAdapter._areAllItemsEnabled10299 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "areAllItemsEnabled", "()Z"); 
			global::android.widget.HeaderViewListAdapter._hasStableIds10300 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "hasStableIds", "()Z"); 
			global::android.widget.HeaderViewListAdapter._getView10301 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.HeaderViewListAdapter._getItemViewType10302 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getItemViewType", "(I)I"); 
			global::android.widget.HeaderViewListAdapter._getViewTypeCount10303 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getViewTypeCount", "()I"); 
			global::android.widget.HeaderViewListAdapter._getHeadersCount10304 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getHeadersCount", "()I"); 
			global::android.widget.HeaderViewListAdapter._getFootersCount10305 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getFootersCount", "()I"); 
			global::android.widget.HeaderViewListAdapter._removeHeader10306 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "removeHeader", "(Landroid/view/View;)Z"); 
			global::android.widget.HeaderViewListAdapter._removeFooter10307 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "removeFooter", "(Landroid/view/View;)Z"); 
			global::android.widget.HeaderViewListAdapter._getWrappedAdapter10308 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "getWrappedAdapter", "()Landroid/widget/ListAdapter;"); 
			global::android.widget.HeaderViewListAdapter._HeaderViewListAdapter10309 = @__env.GetMethodID(global::android.widget.HeaderViewListAdapter.staticClass, "<init>", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Landroid/widget/ListAdapter;)V"); 
		} 
	} 
} 
