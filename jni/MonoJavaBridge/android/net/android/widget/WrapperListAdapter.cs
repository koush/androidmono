namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface WrapperListAdapter : ListAdapter
	{ 
		android.widget.ListAdapter getWrappedAdapter(); 
	} 

	public partial class WrapperListAdapter_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __WrapperListAdapter.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __WrapperListAdapter : java.lang.Object, WrapperListAdapter
	{ 
		internal static global::java.lang.Class staticClass; 
		static __WrapperListAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.__WrapperListAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.__WrapperListAdapter(@__env); 
			} 
		} 
		internal __WrapperListAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWrappedAdapter11329; 
		 android.widget.ListAdapter android.widget.WrapperListAdapter.getWrappedAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__WrapperListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, _getWrappedAdapter11329)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.__WrapperListAdapter.staticClass, _getWrappedAdapter11329)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled11330; 
		 bool android.widget.ListAdapter.isEnabled(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__WrapperListAdapter)) 
				return @__env.CallBooleanMethod(this, _isEnabled11330, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.__WrapperListAdapter.staticClass, _isEnabled11330, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _areAllItemsEnabled11331; 
		 bool android.widget.ListAdapter.areAllItemsEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__WrapperListAdapter)) 
				return @__env.CallBooleanMethod(this, _areAllItemsEnabled11331); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.__WrapperListAdapter.staticClass, _areAllItemsEnabled11331); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty11332; 
		 bool android.widget.Adapter.isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__WrapperListAdapter)) 
				return @__env.CallBooleanMethod(this, _isEmpty11332); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.__WrapperListAdapter.staticClass, _isEmpty11332); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount11333; 
		 int android.widget.Adapter.getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__WrapperListAdapter)) 
				return @__env.CallIntMethod(this, _getCount11333); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.__WrapperListAdapter.staticClass, _getCount11333); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver11334; 
		 void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__WrapperListAdapter)) 
				@__env.CallVoidMethod(this, _registerDataSetObserver11334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.__WrapperListAdapter.staticClass, _registerDataSetObserver11334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver11335; 
		 void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__WrapperListAdapter)) 
				@__env.CallVoidMethod(this, _unregisterDataSetObserver11335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.__WrapperListAdapter.staticClass, _unregisterDataSetObserver11335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItem11336; 
		 java.lang.Object android.widget.Adapter.getItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__WrapperListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getItem11336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.__WrapperListAdapter.staticClass, _getItem11336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemId11337; 
		 long android.widget.Adapter.getItemId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__WrapperListAdapter)) 
				return @__env.CallLongMethod(this, _getItemId11337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.__WrapperListAdapter.staticClass, _getItemId11337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds11338; 
		 bool android.widget.Adapter.hasStableIds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__WrapperListAdapter)) 
				return @__env.CallBooleanMethod(this, _hasStableIds11338); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.__WrapperListAdapter.staticClass, _hasStableIds11338); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getView11339; 
		 android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__WrapperListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getView11339, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.__WrapperListAdapter.staticClass, _getView11339, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemViewType11340; 
		 int android.widget.Adapter.getItemViewType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__WrapperListAdapter)) 
				return @__env.CallIntMethod(this, _getItemViewType11340, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.__WrapperListAdapter.staticClass, _getItemViewType11340, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getViewTypeCount11341; 
		 int android.widget.Adapter.getViewTypeCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__WrapperListAdapter)) 
				return @__env.CallIntMethod(this, _getViewTypeCount11341); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.__WrapperListAdapter.staticClass, _getViewTypeCount11341); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.__WrapperListAdapter.staticClass = @__class; 
			global::android.widget.__WrapperListAdapter._getWrappedAdapter11329 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.WrapperListAdapter.getWrappedAdapter", "()Landroid/widget/ListAdapter;"); 
			global::android.widget.__WrapperListAdapter._isEnabled11330 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.ListAdapter.isEnabled", "(I)Z"); 
			global::android.widget.__WrapperListAdapter._areAllItemsEnabled11331 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.ListAdapter.areAllItemsEnabled", "()Z"); 
			global::android.widget.__WrapperListAdapter._isEmpty11332 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.isEmpty", "()Z"); 
			global::android.widget.__WrapperListAdapter._getCount11333 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.getCount", "()I"); 
			global::android.widget.__WrapperListAdapter._registerDataSetObserver11334 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.__WrapperListAdapter._unregisterDataSetObserver11335 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.__WrapperListAdapter._getItem11336 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.getItem", "(I)Ljava/lang/Object;"); 
			global::android.widget.__WrapperListAdapter._getItemId11337 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.getItemId", "(I)J"); 
			global::android.widget.__WrapperListAdapter._hasStableIds11338 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.hasStableIds", "()Z"); 
			global::android.widget.__WrapperListAdapter._getView11339 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.__WrapperListAdapter._getItemViewType11340 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.getItemViewType", "(I)I"); 
			global::android.widget.__WrapperListAdapter._getViewTypeCount11341 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.getViewTypeCount", "()I"); 
		} 
	} 
} 
